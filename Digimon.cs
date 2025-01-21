namespace Cyber_Sleuth_Mod_Evolution_Analyzer
{
    class Digimon
    {
        public readonly string Name;
        public readonly int Level;
        public readonly HashSet<string> Preevolutions = new();
        public readonly HashSet<string> Evolutions = new();

        public Digimon(string name, int level)
        {
            Name = name;
            Level = level;
        }
        public Digimon()
        {
            Name = "TEMP";
            Level = -1;
        }
    }
}
