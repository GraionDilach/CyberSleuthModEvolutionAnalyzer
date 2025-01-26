namespace Cyber_Sleuth_Mod_Evolution_Analyzer
{
    public class Digimon : IComparable
    {
        public readonly string ID;
        public readonly string Name;
        public readonly int Level;
        public readonly int ModIndex;
        readonly List<Tuple<int, string>> evoConditions;

        public List<Tuple<int, string>> EvoConditions { get { return evoConditions; } }

        public Digimon(string id, string name, int level, int modindex, List<Tuple<int, string>> evoConditions)
        {
            ID = id;
            Name = name;
            Level = level;
            ModIndex = modindex;
            this.evoConditions = evoConditions ?? ([]);
        }
        public Digimon()
        {
            ID = String.Empty;
            Name = "TEMP";
            Level = -1;
            ModIndex = 0;
            evoConditions = [];
        }

        public override string ToString()
        {
            if (int.TryParse(ID, out _))
            {
                return Name + " [" + ID + "]";
            }
            else
            {
                return Name + " [" + ID.Substring(8);
            }
        }

        public int CompareTo(object? obj)
        {
            if (obj == null)
            {
                return 0;
            }

            Digimon digimon = (obj as Digimon)!;
            if (digimon.Level < Level)
            {
                return 1;
            }

            if (digimon.Level > Level)
            {
                return -1;
            }

            if (digimon.ModIndex < ModIndex)
            {
                return 1;
            }

            if (digimon.ModIndex > ModIndex)
            {
                return -1;
            }

            return (string.Compare(Name, digimon.Name));
        }
    }
}
