namespace Cyber_Sleuth_Mod_Evolution_Analyzer
{
    public partial class Form3 : Form
    {
        Form1 sourceForm;

        public List<Digimon> KnownMons = [];

        List<string> evoConditionTypes = [
            "All",
            "Level",
            "Max. HP",
            "Max. SP",
            "ATK",
            "DEF",
            "INT",
            "SPD",
            "ABI",
            "CAM",
            "Game Cleared",
            "Item Held",
            "DNA (Other Digimon)",
            "Mode Change",
            "DLC Flag",
            "Flag Cleared"
        ];

        List<string> vanillaMonHandlingStates = [
            "Ignore",
            "Only load Digimon IDs",
            "Only load full data",
            "Load and export full data"
            ];

        public Form3(Form1 source)
        {
            InitializeComponent();
            sourceForm = source;
            massEvoDeleterComboBox.DataSource = evoConditionTypes;
            baseMonHandlerComboBox.DataSource = vanillaMonHandlingStates.ToArray();
            baseMonHandlerComboBox.SelectedIndex = 3;
            costumedAgumonLoaderComboBox.DataSource = vanillaMonHandlingStates.ToArray();
        }

        public int VanillaMonHandle
        {
            get { return baseMonHandlerComboBox.SelectedIndex; }
        }

        public int CostumedAgumonHandle
        {
            get { return costumedAgumonLoaderComboBox.SelectedIndex; }
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
                digimonEvos[i] = sourceForm.DigimonLists[i].Item1
                    .Where(x => x.Evolutions.Count > 6
                     || (x.Evolutions.Count > 5 && x.Digimon.EvoConditions.Any(y => y.Item1 == 13)))
                    .Select(x => x.Digimon).ToList();

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
            else
            {
                LogMessage("Analysis completed.");
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
            else
            {
                LogMessage("Analysis completed.");
            }
        }

        public void SetupForm()
        {
            analyzerLayoutPanel.Visible = modsAlreadyLoadedLabel.Visible = KnownMons.Count > 0;
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

                        foreach (var item in mon.Devolutions)
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
            else
            {
                LogMessage("Analysis completed.");
            }
        }

        private void massEvoDeleterButton_Click(object sender, EventArgs e)
        {
            if (massEvoDeleterComboBox.SelectedIndex == 0)
            {
                LogMessage("Deleting all evolution requirements from all Digimon...");
            }
            else
            {
                LogMessage("Deleting all evolution requirements of type " + evoConditionTypes[massEvoDeleterComboBox.SelectedIndex] + " from all Digimon...");
            }

            foreach (var list in sourceForm.DigimonLists)
            {
                foreach (var item in list.Item1)
                {
                    for (var i = 0; i < item.Digimon.EvoConditions.Count; i++)
                    {
                        if (massEvoDeleterComboBox.SelectedIndex == 0)
                        {
                            item.Digimon.EvoConditions[i] = new(0, "");
                        }
                        else
                        {
                            if (massEvoDeleterComboBox.SelectedIndex == item.Digimon.EvoConditions[i].Item1)
                            {
                                item.Digimon.EvoConditions[i] = new(0, "");
                            }
                        }
                    }
                }
            }

            sourceForm.Edited = true;
            LogMessage("Operation completed.");
        }

        private void baseMonHandlerComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            costumedAgumonLoaderComboBox.SelectedIndex = 0;
            costumedAgumonLoaderComboBox.DataSource = vanillaMonHandlingStates.Take(baseMonHandlerComboBox.SelectedIndex + 1).ToList();
        }

        private void modeChangeValidatorButton_Click(object sender, EventArgs e)
        {
            LogMessage("Looking for Digimons with the Mode Change evolution option");

            var valid = true;
            var levels = new string[] { "In-Training 1", "In-Training 2", "Rookie", "Champion", "Armor", "Ultimate", "Mega", "Ultra" };

            for (var i = 0; i < sourceForm.DigimonLists.Length; i++)
            {
                var monlist = sourceForm.DigimonLists[i].Item1.Where(x =>
                    (x.Digimon.EvoConditions.Any(y => y.Item1 == 13)))
                    .ToList();

                if (monlist.Count > 0)
                {
                    foreach (var mon in monlist)
                    {
                        var monstring = "";
                        var modechanges = mon.Digimon.EvoConditions.Where(x => x.Item1 == 13).Select(x => x.Item2).ToList();

                        if (modechanges.Count > 1)
                        {
                            monstring += "\t > Has multiple Mode Changes" + Environment.NewLine;
                        }

                        foreach (var item in modechanges)
                        {
                            if (String.IsNullOrEmpty(item) || String.Equals("0", item))
                            {
                                monstring += "\t > Missing Mode Change parameter";
                            }

                            for (var j = 0; j < sourceForm.DigimonLists.Length; j++)
                            {
                                var targetMon = sourceForm.DigimonLists[j].Item1.SingleOrDefault(x => String.Equals(x.Digimon.ID, item));
                                if (targetMon != null)
                                {
                                    var targetModeChanges = targetMon.Digimon.EvoConditions.Where(x =>  x.Item1 == 13).ToList();
                                    foreach (var targetModeChange in targetModeChanges)
                                    {
                                        if (targetModeChange != null)
                                        {
                                            if (!String.Equals(targetModeChange.Item2, mon.Digimon.ID))
                                            {
                                                monstring += "\t > Mode Change link broken: " + targetMon.Digimon.ID + " lacks the Mode Change condition to revert.";
                                            }
                                        }
                                    }
                                }
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
            else
            {
                LogMessage("Analysis completed.");
            }
        }
    }
}
