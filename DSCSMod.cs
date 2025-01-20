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
    }
}
