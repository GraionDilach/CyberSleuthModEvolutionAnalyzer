using System.Diagnostics.CodeAnalysis;

namespace Cyber_Sleuth_Mod_Evolution_Analyzer
{
    public class DigimonListEntry : IComparable
    {
        public readonly Digimon Digimon;
        public readonly List<string> Devolutions;
        public readonly List<string> Evolutions;

        public DigimonListEntry(Digimon digimon, List<string> devolutions, List<string> evolutions)
        {
            Digimon = digimon;
            Devolutions = devolutions;
            Evolutions = evolutions;
        }

        public DigimonListEntry()
        {
            Digimon = new Digimon();
            Devolutions = new List<string>();
            Evolutions = new List<string>();
        }

        public override string ToString()
        {
            return Digimon.Name + " [" + Digimon.ID + "] -{ D:"
                + Devolutions.Count.ToString() + "; E:"
                + Evolutions.Count.ToString() + " }-";
        }

        public int CompareTo(object? obj)
        {
            if (obj == null)
            {
                return 0;
            }

            var other = (obj as DigimonListEntry)!;

            return Digimon.CompareTo(other.Digimon);
        }
    }

    public static class DigimonListEntryExtension
    {
        [MemberNotNullWhen(true)]
        public static bool IsNullOrEmpty(this DigimonListEntry? dle)
        {
            if (dle == null || dle.Digimon == null || String.IsNullOrEmpty(dle.Digimon.ID))
            {
                return true;
            }
            return false;
        }
    }
}