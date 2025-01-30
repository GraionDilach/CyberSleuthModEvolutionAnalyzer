namespace Cyber_Sleuth_Mod_Evolution_Analyzer
{
    public class DigimonItem : IComparable
    {
        public readonly string ID;
        public readonly string Name;
        public readonly int ModIndex;

        public DigimonItem(string id, string name, int modIndex)
        {
            ID = id;
            Name = name;
            ModIndex = modIndex;
        }

        public override string ToString()
        {
            if (int.TryParse(ID, out _))
            {
                return Name + " [" + ID + "]";
            }
            else
            {
                return Name + " [" + ID.Substring(5);
            }
        }

        public int CompareTo(object? obj)
        {
            if (obj == null)
            {
                return 0;
            }

            DigimonItem digimonItem = (obj as DigimonItem)!;

            if (digimonItem.ModIndex < ModIndex)
            {
                return 1;
            }

            if (digimonItem.ModIndex > ModIndex)
            {
                return -1;
            }

            return (string.Compare(Name, digimonItem.Name));
        }
    }
}

