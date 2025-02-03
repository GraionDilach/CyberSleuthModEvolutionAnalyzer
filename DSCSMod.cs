using Microsoft.VisualBasic.FileIO;
using System.Text.Json;

namespace Cyber_Sleuth_Mod_Evolution_Analyzer
{
    public class DSCSMod
    {
        public readonly string Name;
        public readonly bool Generated;
        public readonly string[] SourceMods = [];

        readonly string Version;
        readonly string path;
        readonly string folder;
        readonly int formatVersion = 1;

        public string Folder { get => folder; }

        readonly HashSet<string> digimonIDs = [];

        /*
        string Description;
        string Author;
        string Category;
        */

        public DSCSMod(string rootFolder, string modFolder, string modName = "")
        {
            if (String.IsNullOrEmpty(modName))
            {
                using var reader = new StreamReader(rootFolder + "\\" + modFolder + @"\METADATA.json");
                {
                    var dict = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(reader.BaseStream) ?? throw new Exception();
                    path = rootFolder + "\\" + modFolder;
                    folder = modFolder;

                    if (dict.TryGetValue("Name", out var name))
                    {
                        Name = name.ToString();
                    }
                    else
                    {
                        Name = modFolder;
                    }
                    if (dict.TryGetValue("Version", out var version))
                    {
                        Version = version.ToString();
                    }
                    else
                    {
                        Version = "";
                    }
                    Generated = dict.ContainsKey("GeneratedByCSMEA");
                    if (dict.TryGetValue("SourceMods", out var sourcemods))
                    {
                        SourceMods = sourcemods.ToString().Split(",").ToArray();
                    }

                    if (dict.TryGetValue("FormatVersion", out var formatversionjson))
                    {
                        formatVersion = formatversionjson.GetInt32();
                    }

                    /*
                    Description = dict["Description"];
                    Author = dict["Author"];
                    Category = dict["Category"];
                    */
                }
            }
            else
            {
                Name = modName;
                path = rootFolder + "\\" + modFolder;
                folder = modFolder;
                Version = "";
                Directory.CreateDirectory(path);
            }
        }

        public override string ToString()
        {
            return Name + " (" + Version + ")";
        }

        public HashSet<string> CollectDigimonIDs(Form1 form)
        {
            digimonIDs.Clear();
            var digimonlistpath = (formatVersion > 1)
                ? @"\modfiles\DSDBP\data\digimon_list.mbe\digimon.csv"
                : @"\modfiles\data\digimon_list.mbe\digimon.csv";
            if (File.Exists(path + digimonlistpath))
            {
                try
                {
                    using (var parser = new TextFieldParser(path + digimonlistpath))
                    {
                        parser.Delimiters = [","];
                        parser.HasFieldsEnclosedInQuotes = true;
                        bool readHeader = false;
                        while (readHeader == false)
                        {
                            var tableRow = parser.ReadFields()!;
                            if (tableRow.Length == 0)
                            {
                                throw new Exception();
                            }
                            readHeader = true;
                        }
                        while (!parser.EndOfData)
                        {
                            var tableRow = parser.ReadFields()!;
                            if (!string.IsNullOrEmpty(tableRow[0]))
                            {
                                digimonIDs.Add(tableRow[0]);
                            }
                        }

                        form.LogMessage("Found information about " + digimonIDs.Count + " digimons in " + Name + ".");
                    }
                }
                catch (Exception)
                {
                    form.LogMessage("Failed to parse Digimon data from " + Name + ", skipped...");
                }
            }
            else
            {
                form.LogMessage("Mod " + Name + " lacks Digimon data, skipped...");
            }

            return digimonIDs;
        }

        public Dictionary<string, Digimon> CollectDigimonData(Form1 form, int modIndex, Dictionary<string, Digimon> baseMons)
        {
            var digimonData = new Dictionary<string, Digimon>();

            if (digimonIDs.Count == 0)
            {
                return digimonData;
            }

            // only read Digimons which appeared within the mod's own Digimon ID list
            // parse each CSV individually then build up the Digimon thenafter
            var digimonNames = new Dictionary<string, string>();
            var digimonLevels = new Dictionary<string, int>();

            try
            {
                #region charname.mbe
                var charnamepath = (formatVersion > 1)
                    ? @"\modfiles\DSDBP\text\charname.mbe\Sheet1.csv"
                    : @"\modfiles\text\charname.mbe\Sheet1.csv";

                using (var parser = new TextFieldParser(path + charnamepath))
                {
                    parser.Delimiters = [","];
                    parser.HasFieldsEnclosedInQuotes = true;
                    bool readHeader = false;
                    while (readHeader == false)
                    {
                        var tableRow = parser.ReadFields()!;
                        if (tableRow.Length == 0)
                        {
                            throw new Exception();
                        }
                        readHeader = true;
                    }
                    while (!parser.EndOfData)
                    {
                        var tableRow = parser.ReadFields()!;
                        if (!string.IsNullOrEmpty(tableRow[0]) && !string.IsNullOrEmpty(tableRow[2]))
                        {
                            if (int.TryParse(tableRow[0], out var num))
                            {
                                digimonNames.Add((num - 1000).ToString(), tableRow[2]);                            
                            }
                            else
                            {
                                if (tableRow[0].EndsWith("::4ID()]"))
                                {
                                    var normalizedDigimonName = string.Concat(tableRow[0].AsSpan(0, tableRow[0].Length - 8), "]");
                                    digimonNames.Add(normalizedDigimonName, tableRow[2]);
                                }
                            }
                        }
                    }

                }
                #endregion
            }
            catch (Exception){ }

            try
            {
                #region digimon_common_para.mbe
                var digimoncommonparapath = (formatVersion > 1)
                    ? @"\modfiles\DSDBP\data\digimon_common_para.mbe\digimon.csv"
                    : @"\modfiles\data\digimon_common_para.mbe\digimon.csv";

                using (var parser = new TextFieldParser(path + digimoncommonparapath))
                {
                    parser.Delimiters = [","];
                    parser.HasFieldsEnclosedInQuotes = true;
                    bool readHeader = false;
                    while (readHeader == false)
                    {
                        var tableRow = parser.ReadFields()!;
                        if (tableRow.Length == 0)
                        {
                            throw new Exception();
                        }
                        readHeader = true;
                    }
                    while (!parser.EndOfData)
                    {
                        var tableRow = parser.ReadFields()!;
                        if (!string.IsNullOrEmpty(tableRow[0]) && !string.IsNullOrEmpty(tableRow[1]))
                        {
                            if (int.TryParse(tableRow[1], out var level))
                            {
                                digimonLevels.Add(tableRow[0], level);
                            }
                        }
                    }

                }
                #endregion
            }
            catch (Exception) { }

            if (digimonNames.Count == 0 && digimonLevels.Count == 0)
            {
                form.LogMessage("Failed to parse Digimon data from " + Name + ", skipped...");
                return digimonData;
            }

            foreach (var id in digimonIDs)
            {
                if (digimonNames.ContainsKey(id)
                    && digimonLevels.ContainsKey(id))
                {
                    var digimon = new Digimon(id, digimonNames[id], digimonLevels[id], modIndex, new());
                    digimonData.Add(id, digimon);
                }

                if (!digimonNames.ContainsKey(id) && baseMons.ContainsKey(id) && digimonLevels.ContainsKey(id))
                {
                    var digimon = new Digimon(id, baseMons[id].Name, digimonLevels[id], modIndex, new());
                    digimonData.Add(id, digimon);
                }
            }

            form.LogMessage("Loaded " + digimonData.Count + " digimons from " + Name + ".");
            return digimonData;
        }

        public void UpdateDigimonEvoConditions(Form1 form, Dictionary<string, Digimon> digimons)
        {
            try
            {
                #region evolution_condition_para.mbe
                var evoconditionpath = (formatVersion > 1)
                    ? @"\modfiles\DSDBP\data\evolution_condition_para.mbe\digimon.csv"
                    : @"\modfiles\data\evolution_condition_para.mbe\digimon.csv";
                using (var parser = new TextFieldParser(path + evoconditionpath))
                {
                    parser.Delimiters = [","];
                    parser.HasFieldsEnclosedInQuotes = true;
                    bool readHeader = false;
                    while (readHeader == false)
                    {
                        var tableRow = parser.ReadFields()!;
                        if (tableRow.Length == 0)
                        {
                            throw new Exception();
                        }
                        readHeader = true;
                    }
                    while (!parser.EndOfData)
                    {
                        var tableRow = parser.ReadFields()!;
                        var monID = tableRow[0];
                        if (BaseDigimonStats.ModLoaderLUT.TryGetValue(monID, out string? monIDvalue))
                        {
                            monID = monIDvalue;
                        }
                        if (!string.IsNullOrEmpty(monID))
                        {
                            var evoConditions = new List<Tuple<int, string>>();
                            for (var i = 1; i < tableRow.Length; i += 3)
                            {
                                if (int.TryParse(tableRow[i], out var condition))
                                {
                                    switch (condition)
                                    {
                                        // separately handle "Cleared Hacker's Memory" condition
                                        case 15:
                                            evoConditions.Add(new Tuple<int, string>(condition, tableRow[i + 2]));
                                            break;
                                        // ignore nonexistant mons as DNA options
                                        case 12:
                                            var evomon = tableRow[i + 1];
                                            if (BaseDigimonStats.ModLoaderLUT.TryGetValue(evomon, out string? evomonvalue))
                                            {
                                                evomon = evomonvalue;
                                            }
                                            if (digimons.ContainsKey(evomon))
                                            {
                                                evoConditions.Add(new Tuple<int, string>(condition, evomon));
                                            }
                                            else
                                            {
                                                form.LogMessage("Mod " + Name + " - " + monID + ": Ignored unknown Digimon ID of DNA option  " + tableRow[i + 1] + ", skipped...");
                                            }
                                            break;
                                        // same for mode change
                                        case 13:
                                            var modemon = tableRow[i + 1];
                                            if (BaseDigimonStats.ModLoaderLUT.TryGetValue(modemon, out string? modemonvalue))
                                            {
                                                modemon = modemonvalue;
                                            }
                                            if (digimons.ContainsKey(modemon))
                                            {
                                                evoConditions.Add(new Tuple<int, string>(condition, modemon));
                                            }
                                            else
                                            {
                                                form.LogMessage("Mod " + Name + " - " + monID + ": Ignored unknown Digimon ID of Mode Change  " + tableRow[i + 1] + ", skipped...");
                                            }
                                            break;
                                        default:
                                            evoConditions.Add(new Tuple<int, string>(condition, tableRow[i + 1]));
                                            break;
                                    }
                                }
                            }

                            while (evoConditions.Count < 10)
                            {
                                evoConditions.Add(new(0, ""));
                            }

                            if (digimons.ContainsKey(monID))
                            {
                                digimons[monID].EvoConditions = evoConditions;
                            }
                        }
                    }
                }
                #endregion

                form.LogMessage("Loaded evolution conditions from " + Name + " mod.");
            }
            catch
            {

            }
        }

        public void LoadDigimonEvolutions(Form1 form, HashSet<string> globalIDs, Dictionary<string, List<string>> digimonEvolutions)
        {
            try
            {
                #region evolution_next_para.mbe
                var evonextpath = (formatVersion > 1)
                    ? @"\modfiles\DSDBP\data\evolution_next_para.mbe\digimon.csv"
                    : @"\modfiles\data\evolution_next_para.mbe\digimon.csv";

                if (File.Exists(path + evonextpath))
                {
                    using (var parser = new TextFieldParser(path + evonextpath))
                    {
                        parser.Delimiters = [","];
                        parser.HasFieldsEnclosedInQuotes = true;
                        bool readHeader = false;
                        while (readHeader == false)
                        {
                            var tableRow = parser.ReadFields()!;
                            if (tableRow.Length == 0)
                            {
                                throw new Exception();
                            }
                            readHeader = true;
                        }
                        while (!parser.EndOfData)
                        {
                            var tableRow = parser.ReadFields()!;
                            if (!string.IsNullOrEmpty(tableRow[0]))
                            {
                                var monID = tableRow[0];
                                if (BaseDigimonStats.ModLoaderLUT.TryGetValue(monID, out string? monIDvalue))
                                {
                                    monID = monIDvalue;
                                }
                                if (globalIDs.Contains(monID))
                                {
                                    var evolutions = new List<string>();
                                    for (var i = 1; i < tableRow.Length; i++)
                                    {
                                        var evoID = tableRow[i];
                                        if (BaseDigimonStats.ModLoaderLUT.TryGetValue(evoID, out string? evoIDvalue))
                                        {
                                            evoID = evoIDvalue;
                                        }
                                        if (!int.TryParse(evoID, out var numericDigimonID)
                                            || numericDigimonID != 0)
                                        {
                                            if (!globalIDs.Contains(evoID))
                                            {
                                                form.LogMessage("Mod " + Name + " - " + monID + ": Ignored unknown Digimon ID of evolution " + evoID + ", skipped...");
                                            }
                                            else
                                            {
                                                evolutions.Add(evoID);
                                            }
                                        }
                                    }

                                    // extend data of evolution if already loaded from prior and this isn't a generated mod
                                    if (!Generated)
                                    {
                                        if (!digimonEvolutions.ContainsKey(monID))
                                        {
                                            digimonEvolutions.Add(monID, evolutions);
                                        }
                                        else
                                        {
                                            digimonEvolutions[monID] = digimonEvolutions[monID].Concat(evolutions).Distinct().ToList();
                                        }
                                    }
                                    else
                                    {
                                        digimonEvolutions[monID] = evolutions;
                                    }
                                }
                                else
                                {
                                    form.LogMessage("Mod " + Name + ": Ignored evolution data for unknown Digimon ID " + monID + ", skipped...");
                                }
                            }
                        }
                    }
                }
                #endregion

                #region degeneration_para.mbe
                var degenpath = (formatVersion > 1)
                    ? @"\modfiles\DSDBP\data\degeneration_para.mbe\digimon.csv"
                    : @"\modfiles\data\degeneration_para.mbe\digimon.csv";

                // generated mods shouldn't need to read degen_para, because all generated mods have 2-way evos
                if (!Generated && File.Exists(path + degenpath))
                {
                    using (var parser = new TextFieldParser(path + degenpath))
                    {
                        parser.Delimiters = [","];
                        parser.HasFieldsEnclosedInQuotes = true;
                        bool readHeader = false;
                        while (readHeader == false)
                        {
                            var tableRow = parser.ReadFields()!;
                            if (tableRow.Length == 0)
                            {
                                throw new Exception();
                            }
                            readHeader = true;
                        }
                        while (!parser.EndOfData)
                        {
                            var tableRow = parser.ReadFields()!;
                            if (!string.IsNullOrEmpty(tableRow[0]))
                            {
                                var monID = tableRow[0];
                                if (BaseDigimonStats.ModLoaderLUT.TryGetValue(monID, out string? monIDvalue))
                                {
                                    monID = monIDvalue;
                                }
                                if (globalIDs.Contains(monID))
                                {
                                    for (var i = 1; i < tableRow.Length; i++)
                                    {
                                        var evoID = tableRow[i];
                                        if (BaseDigimonStats.ModLoaderLUT.TryGetValue(evoID, out string? evoIDvalue))
                                        {
                                            evoID = evoIDvalue;
                                        }
                                        if (!int.TryParse(evoID, out var numericDigimonID)
                                            || numericDigimonID != 0)
                                        {
                                            if (!globalIDs.Contains(evoID))
                                            {
                                                form.LogMessage("Mod " + Name + " - " + monID + ": Ignored unknown Digimon ID of devolution " + evoID + ", skipped...");
                                            }
                                            else
                                            {
                                                if (digimonEvolutions.ContainsKey(evoID))
                                                {
                                                    if (!digimonEvolutions[evoID].Contains(monID))
                                                    {
                                                        digimonEvolutions[evoID].Add(monID);
                                                    }
                                                }
                                                else
                                                {
                                                    digimonEvolutions.Add(evoID, [monID]);
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    form.LogMessage("Mod " + Name + ": Ignored devolution data for unknown Digimon ID " + monID + ", skipped...");
                                }
                            }
                        }
                    }
                }
                #endregion
            }
            catch (Exception)
            {
                form.LogMessage("Failed to parse Digimon evolution data from " + Name + ", skipped...");
            }
        }

        public void WriteMetadata(List<DSCSMod> sourceMods)
        {
            var metadata = new Dictionary<string, string>
            {
                ["Name"] = Name,
                ["Version"] = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffZ"),
                ["GeneratedByCSMEA"] = "true",
                ["Description"] = "Auto-generated evolution results based on the following mods:\n",
                ["SourceMods"] = ""
            };
            foreach (DSCSMod mod in sourceMods)
            {
                metadata["Description"] += "\t" + mod.Name + "\n";
                metadata["SourceMods"] += mod.Folder + ",";
            }

            string metadataJSON = JsonSerializer.Serialize(metadata);
            File.WriteAllText(path + @"\METADATA.json", metadataJSON);
        }

        public void WriteEvolutions(Dictionary<string, List<string>> digimonDevolutions,
            Dictionary<string, List<string>> digimonEvolutions,
            Dictionary<string, List<Tuple<int, string>>> digimonEvoConditions)
        {
            if (!Directory.Exists(path + @"\modfiles"))
            {
                Directory.CreateDirectory(path + @"\modfiles");
            }

            if (!Directory.Exists(path + @"\modfiles\data"))
            {
                Directory.CreateDirectory(path + @"\modfiles\data");
            }

            if (!Directory.Exists(path + @"\modfiles\data\degeneration_para.mbe"))
            {
                Directory.CreateDirectory(path + @"\modfiles\data\degeneration_para.mbe");
            }

            var degeneration = "id,digi1,digi2,digi3,digi4,digi5,digi6\r\n";
            foreach (var mon in digimonDevolutions)
            {
                degeneration += mon.Key;
                for (int i = 0; i < 6; i++)
                {
                    if (i < digimonDevolutions[mon.Key].Count)
                    {
                        degeneration += "," + digimonDevolutions[mon.Key][i];
                    }
                    else
                    {
                        degeneration += ",0";
                    }
                }
                degeneration += "\r\n";
            }
            File.WriteAllText(path + @"\modfiles\data\degeneration_para.mbe\digimon.csv", degeneration);

            if (!Directory.Exists(path + @"\modfiles\data\evolution_next_para.mbe"))
            {
                Directory.CreateDirectory(path + @"\modfiles\data\evolution_next_para.mbe");
            }

            var evolution = "id,digi1,digi2,digi3,digi4,digi5,digi6\r\n";
            foreach (var mon in digimonEvolutions)
            {
                evolution += mon.Key;
                for (int i = 0; i < 5; i++)
                {
                    if (i < digimonEvolutions[mon.Key].Count)
                    {
                        evolution += "," + digimonEvolutions[mon.Key][i];
                    }
                    else
                    {
                        evolution += ",0";
                    }
                }

                var modeChangeCondition = digimonEvoConditions[mon.Key].SingleOrDefault(x => x.Item1 == 13);
                if (modeChangeCondition != null)
                {
                    evolution += "," + modeChangeCondition.Item2;
                }
                else
                {
                    if (5 < digimonEvolutions[mon.Key].Count)
                    {
                        evolution += "," + digimonEvolutions[mon.Key][5];
                    }
                    else
                    {
                        evolution += ",0";
                    }
                }

                evolution += "\r\n";
            }
            File.WriteAllText(path + @"\modfiles\data\evolution_next_para.mbe\digimon.csv", evolution);
        }

        public void WriteEvoConditions(Dictionary<string, List<Tuple<int, string>>> digimonEvoConditions)
        {
            if (!Directory.Exists(path + @"\modfiles"))
            {
                Directory.CreateDirectory(path + @"\modfiles");
            }

            if (!Directory.Exists(path + @"\modfiles\data"))
            {
                Directory.CreateDirectory(path + @"\modfiles\data");
            }

            if (!Directory.Exists(path + @"\modfiles\data\evolution_condition_para.mbe"))
            {
                Directory.CreateDirectory(path + @"\modfiles\data\evolution_condition_para.mbe");
            }

            var conditions = "id,condType1,condValue1,condUnk1,condType2,condValue2,condUnk2,condType3,condValue3,condUnk3,condType4,condValue4,condUnk4,condType5,condValue5,condUnk5,condType6,condValue6,condUnk6,condType7,condValue7,condUnk7,condType8,condValue8,condUnk8,condType9,condValue9,condUnk9,condType10,condValue10,condUnk10\r\n";
            foreach (var mon in digimonEvoConditions)
            {
                conditions += mon.Key;
                for (var i = 0;i < 10; i++)
                {
                    var validConditions = mon.Value.Where(x => x.Item1 != 0).ToList();
                    if (i < validConditions.Count)
                    {
                        if (validConditions[i].Item1 == 15)
                        {
                            conditions += "," + validConditions[i].Item1.ToString() + ",0," + validConditions[i].Item2;
                        } 
                        else
                        {
                            conditions += "," + validConditions[i].Item1.ToString() + "," + validConditions[i].Item2 + ",0";
                        }
                    }
                    else
                    {
                        conditions += ",0,0,0";
                    }
                }
                conditions += "\r\n";
            }

            File.WriteAllText(path + @"\modfiles\data\evolution_condition_para.mbe\digimon.csv", conditions);
        }

        public List<DigimonItem> CollectItems (Form1 form, int modIndex)
        {
            var itemList = new List<DigimonItem>();

            try
            {
                #region item_name.mbe
                var digimoncommonparapath = (formatVersion > 1)
                    ? @"\modfiles\DSDBP\text\item_name.mbe\Sheet1.csv"
                    : @"\modfiles\text\item_name.mbe\Sheet1.csv";

                using (var parser = new TextFieldParser(path + digimoncommonparapath))
                {
                    parser.Delimiters = [","];
                    parser.HasFieldsEnclosedInQuotes = true;
                    bool readHeader = false;
                    while (readHeader == false)
                    {
                        var tableRow = parser.ReadFields()!;
                        if (tableRow.Length == 0)
                        {
                            throw new Exception();
                        }
                        readHeader = true;
                    }
                    while (!parser.EndOfData)
                    {
                        var tableRow = parser.ReadFields()!;
                        if (!string.IsNullOrEmpty(tableRow[0]) && !string.IsNullOrEmpty(tableRow[2]))
                        {
                            itemList.Add(new DigimonItem(tableRow[0], tableRow[2], modIndex));
                        }
                    }
                }
                #endregion
            }
            catch (Exception) { }

            return itemList;
        }
    }
}
