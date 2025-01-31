namespace Cyber_Sleuth_Mod_Evolution_Analyzer
{
    public partial class Form3 : Form
    {
        Form1 sourceForm;

        public Form3(Form1 source)
        {
            InitializeComponent();
            sourceForm = source;
        }

        public void LogMessage(string message, bool timestamp = true)
        {
            if (timestamp)
            {
                analyzerLogBox.AppendText("[" + DateTime.Now.ToShortTimeString() + "] " + message + Environment.NewLine);
            }
            else
            {
                analyzerLogBox.AppendText("\t" + message + Environment.NewLine);
            }

        }

        private void validateEvoButton_Click(object sender, EventArgs e)
        {
            bool valid = true;
            var levels = new string[] { "In-Training 1", "In-Training 2", "Rookie", "Champion", "Armor", "Ultimate", "Mega", "Ultra" };
            var digimonPreEvos = new List<Digimon>[8];
            var digimonEvos = new List<Digimon>[8];
            LogMessage("Looking for Digimons with more than 6 evolution options...");

            for (var i = 0; i < sourceForm.DigimonLists.Length; i++)
            {
                digimonPreEvos[i] = sourceForm.DigimonLists[i].Item1.Where(x => x.Devolutions.Count > 6).Select(x => x.Digimon).ToList();
                digimonEvos[i] = sourceForm.DigimonLists[i].Item1.Where(x => x.Evolutions.Count > 6).Select(x => x.Digimon).ToList();

                if (digimonPreEvos[i].Count != 0)
                {
                    valid = false;
                    LogMessage("The following " + levels[i] + " Digimon can be evolved from more than 6 mons:");
                    foreach (var mon in digimonPreEvos[i])
                    {
                        LogMessage(mon.ToString(), false);
                    }
                }

                if (digimonEvos[i].Count != 0)
                {
                    valid = false;
                    LogMessage("The following " + levels[i] + " Digimon can be evolved to more than 6 mons:");
                    foreach (var mon in digimonEvos[i])
                    {
                        LogMessage(mon.ToString(), false);
                    }
                }
            }

            if (valid)
            {
                LogMessage("No such Digimons encountered.");
            }
        }
    }
}
