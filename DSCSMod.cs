using Microsoft.VisualBasic.FileIO;
using System.Text.Json;

namespace Cyber_Sleuth_Mod_Evolution_Analyzer
{
    public class DSCSMod
    {
        public readonly string Name;
        public readonly bool Generated;

        readonly string Version;
        readonly string path;
        readonly string folder;

        public string Folder { get => folder; }

        readonly HashSet<string> digimonIDs = new(StringComparer.OrdinalIgnoreCase);

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
                    var dict = JsonSerializer.Deserialize<Dictionary<string, string>>(reader.BaseStream) ?? throw new Exception();
                    path = rootFolder + "\\" + modFolder;
                    folder = modFolder;
                    Name = dict["Name"];
                    Version = dict["Version"];
                    Generated = dict.ContainsKey("GeneratedByCSMEA");
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
            if (File.Exists(path + @"\modfiles\data\digimon_list.mbe\digimon.csv"))
            {
                try
                {
                    using (var parser = new TextFieldParser(path + @"\modfiles\data\digimon_list.mbe\digimon.csv"))
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

        public Dictionary<string, Digimon> CollectDigimonData(Form1 form, int modIndex, HashSet<string> globalIDs)
        {
            var digimonData = new Dictionary<string, Digimon>(StringComparer.OrdinalIgnoreCase);

            if (digimonIDs.Count == 0)
            {
                return digimonData;
            }

            // only read Digimons which appeared within the mod's own Digimon ID list
            // parse each CSV individually then build up the Digimon thenafter
            var digimonNames = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            var digimonLevels = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            var digimonEvoConditions = new Dictionary<string, List<Tuple<int, string>>>(StringComparer.OrdinalIgnoreCase);

            try
            {
                #region charname.mbe
                using (var parser = new TextFieldParser(path + @"\modfiles\text\charname.mbe\Sheet1.csv"))
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

                #region digimon_common_para.mbe
                using (var parser = new TextFieldParser(path + @"\modfiles\data\digimon_common_para.mbe\digimon.csv"))
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

                #region evolution_condition_para.mbe
                using (var parser = new TextFieldParser(path + @"\modfiles\data\evolution_condition_para.mbe\digimon.csv"))
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
                            var evoConditions = new List<Tuple<int, string>>();
                            for (var i = 1; i < tableRow.Length; i += 3)
                            {
                                if (int.TryParse(tableRow[i], out var condition)
                                    && condition != 0)
                                {
                                    // separately handle "Cleared Hacker's Memory" condition
                                    if (condition != 15)
                                    {
                                        evoConditions.Add(new Tuple<int, string>(condition, tableRow[i + 1]));
                                    }
                                    else
                                    {
                                        evoConditions.Add(new Tuple<int, string>(condition, tableRow[i + 2]));
                                    }
                                }
                            }

                            digimonEvoConditions.Add(tableRow[0], evoConditions);
                        }
                    }

                }
                #endregion
            }
            catch (Exception)
            {
                form.LogMessage("Failed to parse Digimon data from " + Name + ", skipped...");
            }

            foreach (var id in digimonIDs)
            {
                if (digimonNames.ContainsKey(id)
                    && digimonLevels.ContainsKey(id))
                {
                    digimonEvoConditions.TryGetValue(id, out var evoCondition);
                    var digimon = new Digimon(id, digimonNames[id], digimonLevels[id], modIndex, evoCondition!);
                    digimonData.Add(id, digimon);
                }
            }

            form.LogMessage("Loaded " + digimonData.Count + " digimons from " + Name + ".");
            return digimonData;
        }

        public void LoadDigimonEvolutions(Form1 form, HashSet<string> globalIDs, Dictionary<string, List<string>> digimonEvolutions)
        {
            try
            {
                #region evolution_next_para.mbe
                if (File.Exists(path + @"\modfiles\data\evolution_next_para.mbe\digimon.csv"))
                {
                    using (var parser = new TextFieldParser(path + @"\modfiles\data\evolution_next_para.mbe\digimon.csv"))
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
                                if (globalIDs.Contains(tableRow[0]))
                                {
                                    var evolutions = new List<string>();
                                    for (var i = 1; i < tableRow.Length; i++)
                                    {
                                        if (!int.TryParse(tableRow[i], out var numericDigimonID)
                                            || numericDigimonID != 0)
                                        {
                                            if (!globalIDs.Contains(tableRow[i]))
                                            {
                                                form.LogMessage("Mod " + Name + " - " + tableRow[0] + ": Ignored unknown Digimon ID of evolution " + tableRow[i] + ", skipped...");
                                            }
                                            else
                                            {
                                                evolutions.Add(tableRow[i]);
                                            }
                                        }
                                    }

                                    // extend data of evolution if already loaded from prior
                                    if (!digimonEvolutions.ContainsKey(tableRow[0]))
                                    {
                                        digimonEvolutions.Add(tableRow[0], evolutions);
                                    }
                                    else
                                    {
                                        digimonEvolutions[tableRow[0]] = digimonEvolutions[tableRow[0]].Concat(evolutions).Distinct().ToList();
                                    }
                                }
                                else
                                {
                                    form.LogMessage("Mod " + Name + ": Ignored evolution data for unknown Digimon ID " + tableRow[0] + ", skipped...");
                                }
                            }
                        }
                    }
                }
                #endregion

                #region degeneration_para.mbe
                if (File.Exists(path + @"\modfiles\data\degeneration_para.mbe\digimon.csv"))
                {
                    using (var parser = new TextFieldParser(path + @"\modfiles\data\degeneration_para.mbe\digimon.csv"))
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
                                if (globalIDs.Contains(tableRow[0]))
                                {
                                    for (var i = 1; i < tableRow.Length; i++)
                                    {
                                        if (!int.TryParse(tableRow[i], out var numericDigimonID)
                                            || numericDigimonID != 0)
                                        {
                                            if (!globalIDs.Contains(tableRow[i]))
                                            {
                                                form.LogMessage("Mod " + Name + " - " + tableRow[0] + ": Ignored unknown Digimon ID of devolution " + tableRow[i] + ", skipped...");
                                            }
                                            else
                                            {
                                                if (digimonEvolutions.ContainsKey(tableRow[i]))
                                                {
                                                    if (!digimonEvolutions[tableRow[i]].Contains(tableRow[0]))
                                                    {
                                                        digimonEvolutions[tableRow[i]].Add(tableRow[0]);
                                                    }
                                                }
                                                else
                                                {
                                                    digimonEvolutions.Add(tableRow[i], [tableRow[0]]);
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    form.LogMessage("Mod " + Name + ": Ignored devolution data for unknown Digimon ID " + tableRow[0] + ", skipped...");
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
            var metadata = new Dictionary<string, string>();
            metadata["Name"] = Name;
            metadata["Version"] = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");
            metadata["GeneratedByCSMEA"] = "true";
            metadata["Description"] = "Auto-generated evolution results based on the following mods:\n";
            metadata["SourceMods"] = "[ ";
            foreach (DSCSMod mod in sourceMods)
            {
                metadata["Description"] += "\t" + mod.Name + "\n";
                metadata["SourceMods"] += "\"" + mod.Folder + "\", ";
            }
            metadata["SourceMods"] += "]";

            string metadataJSON = JsonSerializer.Serialize(metadata);
            File.WriteAllText(path + @"\METADATA.json", metadataJSON);
        }

        public void WriteEvolutions(Dictionary<string, List<string>> digimonDevolutions,
            Dictionary<string, List<string>> digimonEvolutions)
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

            var degeneration = "id,digi1,digi2,digi3,digi4,digi5,digi6\n";
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
                degeneration += "\n";
            }
            File.WriteAllText(path + @"\modfiles\data\degeneration_para.mbe\digimon.csv", degeneration);

            if (!Directory.Exists(path + @"\modfiles\data\evolution_next_para.mbe"))
            {
                Directory.CreateDirectory(path + @"\modfiles\data\evolution_next_para.mbe");
            }

            var evolution = "id,digi1,digi2,digi3,digi4,digi5,digi6\n";
            foreach (var mon in digimonEvolutions)
            {
                evolution += mon.Key;
                for (int i = 0; i < 6; i++)
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
                evolution += "\n";
            }
            File.WriteAllText(path + @"\modfiles\data\evolution_next_para.mbe\digimon.csv", evolution);
        }
    }
}
