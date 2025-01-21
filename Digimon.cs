namespace Cyber_Sleuth_Mod_Evolution_Analyzer
{
    class Digimon : IComparable
    {
        public readonly string Name;
        public readonly int Level;
        readonly List<Tuple<int, string>> evoConditions;

        public List<Tuple<int, string>> EvoConditions { get { return evoConditions; } }

        public Digimon(string name, int level, List<Tuple<int, string>> evoConditions)
        {
            Name = name;
            Level = level;
            this.evoConditions = evoConditions ?? ([]);
        }
        public Digimon()
        {
            Name = "TEMP";
            Level = -1;
            evoConditions = [];
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
                return -1;
            }

            if (digimon.Level > Level)
            {
                return 1;
            }

            return (string.Compare(Name, digimon.Name));
        }
    }
}
