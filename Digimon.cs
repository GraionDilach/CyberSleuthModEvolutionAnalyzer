namespace Cyber_Sleuth_Mod_Evolution_Analyzer
{
    class Digimon
    {
        public readonly string Name;
        public readonly int Level;
        public readonly List<Tuple<int, string>> EvoConditions;

        public Digimon(string name, int level, List<Tuple<int, string>> evoConditions)
        {
            Name = name;
            Level = level;
            EvoConditions = evoConditions != null
                ? evoConditions
                : [];
        }
        public Digimon()
        {
            Name = "TEMP";
            Level = -1;
            EvoConditions = [];
        }
    }
}
