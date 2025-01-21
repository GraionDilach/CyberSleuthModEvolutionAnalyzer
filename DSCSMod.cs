using Microsoft.VisualBasic.FileIO;
using System.Text.Json;

namespace Cyber_Sleuth_Mod_Evolution_Analyzer
{
    internal class DSCSMod
    {
        public readonly string Name;

        readonly string Version;
        readonly string folder;

        /*
        string Description;
        string Author;
        string Category;
        */

        public DSCSMod(string modFolder)
        {
            using var reader = new StreamReader(modFolder + @"\METADATA.json");
            {
                var dict = JsonSerializer.Deserialize<Dictionary<string, string>>(reader.BaseStream);
                if (dict == null)
                {
                    throw new Exception();
                }
                folder = modFolder;
                Name = dict["Name"];
                Version = dict["Version"];
                /*
                Description = dict["Description"];
                Author = dict["Author"];
                Category = dict["Category"];
                */
            }
        }

        public override string ToString()
        {
            return Name + " (" + Version + ")";
        }

        public HashSet<string> CollectDigimonIDs(Form1 form)
        {
            var hashset = new HashSet<string>();
            if (File.Exists(folder + @"\modfiles\data\digimon_list.mbe\digimon.csv"))
            {
                try
                {
                    using (var parser = new TextFieldParser(folder + @"\modfiles\data\digimon_list.mbe\digimon.csv"))
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
                                hashset.Add(tableRow[0]);
                            }
                        }

                        form.LogMessage("Detected " + hashset.Count + " digimons in " + Name + ".");
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

            return hashset;
        }
    }
}
