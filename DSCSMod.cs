using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.Json;

namespace Cyber_Sleuth_Mod_Evolution_Analyzer
{
    internal class DSCSMod
    {
        public string Name;
        public string Description;

        string folder;
        string Author;
        string Version;
        string Category;

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
                Description = dict["Description"];
                Author = dict["Author"];
                Version = dict["Version"];
                Category = dict["Category"];
            }

 
        }
    }
}
