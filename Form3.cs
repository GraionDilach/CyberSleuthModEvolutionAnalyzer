﻿namespace Cyber_Sleuth_Mod_Evolution_Analyzer
{
    public partial class Form3 : Form
    {
        Form1 sourceForm;
        
        public List<Digimon> KnownMons = [];

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
            var valid = true;
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
                LogMessage("Analysis completed. No such Digimon encountered.");
            }
        }

        private void pipeEvolutionsButton_Click(object sender, EventArgs e)
        {
            LogMessage("Looking for Digimons with only 1 evolution options in both directions...");

            var valid = true;
            var levels = new string[] { "In-Training 1", "In-Training 2", "Rookie", "Champion", "Armor", "Ultimate", "Mega", "Ultra" };

            for (var i = 0; i < sourceForm.DigimonLists.Length; i++)
            {
                var monlist = sourceForm.DigimonLists[i].Item1.Where(x =>
                    (x.Devolutions.Count == 1 && x.Evolutions.Count == 1))
                    .ToList();

                if (monlist.Count > 0)
                {
                    valid = false;
                    LogMessage("The following " + levels[i] + " Digimon are pipe Digimons:");
                    foreach (var mon in monlist)
                    {
                        LogMessage(mon.ToString(), false);
                    }
                }
            }

            if (valid)
            {
                LogMessage("Analysis completed. No such Digimon encountered.");
            }
        }

        public void SetupForm()
        {
            analyzerLayoutPanel.Visible = KnownMons.Count > 0;
        }

        private void dumpModSourcingButton_Click(object sender, EventArgs e)
        {
            var levels = new string[] { "In-Training 1", "In-Training 2", "Rookie", "Champion", "Armor", "Ultimate", "Mega", "Ultra" };

            for (var i = 0; i < sourceForm.ActiveMods.Count + 1; i++)
            {
                if (i == 0)
                {
                    LogMessage("The following Digimons are loaded from " + Environment.NewLine + "Cyber Sleuth:");
                }
                else
                {
                    LogMessage("The following Digimons are loaded from" + Environment.NewLine + sourceForm.ActiveMods[i - 1].Name + ":");
                }

                for (var j = 0; j < sourceForm.DigimonLists.Length; j++)
                {
                    var monlist = sourceForm.DigimonLists[j].Item1.Where(x => x.Digimon.ModIndex == i).ToList();

                    if (monlist.Count > 0)
                    {
                        LogMessage(levels[j] + " Digimon:", false);
                        foreach (var mon in monlist)
                        {
                            LogMessage("  > " + mon.ToString(), false);
                        }
                    }
                }
            }
        }

        private void validateJogressButton_Click(object sender, EventArgs e)
        {
            LogMessage("Looking for Digimons whose prior forms aren't equal to their DNA/Jogress requirements...");

            var valid = true;
            var levels = new string[] { "In-Training 1", "In-Training 2", "Rookie", "Champion", "Armor", "Ultimate", "Mega", "Ultra" };

            for (var i = 0; i < sourceForm.DigimonLists.Length; i++)
            {
                var monlist = sourceForm.DigimonLists[i].Item1.Where(x =>
                    (x.Digimon.EvoConditions.Any(y => y.Item1 == 12)))
                    .ToList();

                if (monlist.Count > 0)
                {
                    foreach (var mon in monlist)
                    {
                        var monstring = "";
                        var jogressevos = mon.Digimon.EvoConditions.Where(x => x.Item1 == 12).Select(x => x.Item2).ToList();


                        if (jogressevos.Count == 1)
                        {
                            monstring += "\t > Lacks multiple DNA digivolution options" + Environment.NewLine;
                        }

                        foreach (var item in jogressevos)
                        {
                            if (!mon.Devolutions.Contains(item))
                            {
                                var faultyMon = KnownMons.SingleOrDefault(x => String.Equals(x.ID, item));
                                if (faultyMon == null)
                                {
                                    monstring += "\t > Requires external mon ID " + item + " as DNA digivolution option" + Environment.NewLine;
                                }
                                else
                                {
                                    monstring += "\t > Requires external mon " + faultyMon.Name + " as DNA digivolution option" + Environment.NewLine;
                                }
                            }
                        }

                        foreach(var item in mon.Devolutions)
                        {
                            if (!jogressevos.Contains(item))
                            {
                                monstring += "\t > Missing devolution " + KnownMons.Single(x => String.Equals(x.ID, item)).Name + " as DNA digivolution option" + Environment.NewLine;
                            }
                        }

                        if (monstring.Length > 0)
                        {
                            valid = false;
                            LogMessage(mon + " [" + levels[i] + "]" + Environment.NewLine + monstring);
                        }
                    }
                }
            }

            if (valid)
            {
                LogMessage("Analysis completed. No such Digimon encountered.");
            }
        }
    }
}
