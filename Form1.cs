namespace Cyber_Sleuth_Mod_Evolution_Analyzer
{
    public partial class Form1 : Form
    {
        readonly List<DSCSMod> dscsMods = [];
        readonly Dictionary<string, Digimon> digimons = new(StringComparer.OrdinalIgnoreCase);
        readonly Dictionary<string, List<string>> digimonEvolutions = new(StringComparer.OrdinalIgnoreCase);
        readonly Dictionary<string, List<string>> digimonDevolutions = new(StringComparer.OrdinalIgnoreCase);

        List<Digimon>[] digimonLists = new List<Digimon>[8];

        public Form1()
        {
            InitializeComponent();
        }

        private void modsLocationBrowser_Click(object sender, EventArgs e)
        {
            modList.Visible = false;
            dscsMods.Clear();
            digimons.Clear();
            digimonEvolutions.Clear();
            digimonDevolutions.Clear();
            for (int i = 0; i < digimonLists.Length; i++)
            {
                digimonLists[i] = new List<Digimon>();
            }
            DialogResult result = modFolderLocator.ShowDialog();
            if (result == DialogResult.OK)
            {
                var potentialMods = Directory.GetDirectories(modFolderLocator.SelectedPath);
                foreach (var potentialMod in potentialMods)
                {
                    try
                    {
                        if (File.Exists(potentialMod + @"\METADATA.json"))
                        {
                            var dscsMod = new DSCSMod(potentialMod);
                            dscsMods.Add(dscsMod);

                            LogMessage("Parsed " + potentialMod + " as " + dscsMod.Name + ".");
                        }
                    }
                    catch (Exception)
                    {
                        LogMessage("Failed to parse " + potentialMod + " folder as a DSCS mod.");
                    }
                }

                if (dscsMods.Count > 0)
                {
                    modList.Visible = true;
                    modsLocation.Text = modFolderLocator.SelectedPath;
                    modListBox.DataSource = dscsMods;
                }

                LogMessage("Detected " + dscsMods.Count + " mods.");
            }
        }

        public void LogMessage(string message, bool timestamp = true)
        {
            if (timestamp)
            {
                logBox.AppendText("[" + DateTime.Now.ToShortTimeString() + "] " + message + Environment.NewLine);
            }
            else
            {
                logBox.AppendText("\t" + message + Environment.NewLine);
            }

        }

        private void modListBox_DragDrop(object sender, DragEventArgs e)
        {
            if (modListBox.SelectedItem == null) { return; }
            var selectedIndex = modListBox.SelectedIndex;

            Point point = modListBox.PointToClient(new Point(e.X, e.Y));
            int index = modListBox.IndexFromPoint(point);
            if (index < 0)
            {
                index = modListBox.Items.Count - 1;
            }
            if (index != selectedIndex)
            {
                var checkedItems = new HashSet<DSCSMod>();
                for (var i = 0; i < modListBox.Items.Count; i++)
                {
                    if (modListBox.GetItemChecked(i))
                    {
                        checkedItems.Add(dscsMods[i]);
                    }
                }
                var item = dscsMods[selectedIndex];
                dscsMods.Remove(item);
                dscsMods.Insert(index, item);
                modListBox.DataSource = null;
                modListBox.DataSource = dscsMods;
                modListBox.SelectedIndex = index;
                for (var i = 0; i < modListBox.Items.Count; i++)
                {
                    if (checkedItems.Contains(dscsMods[i]))
                    {
                        modListBox.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void modListBox_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void modListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (modListBox.SelectedItem == null) return;
            modListBox.DoDragDrop(modListBox.SelectedItem, DragDropEffects.Move);
        }

        private void modLoaderButton_Click(object sender, EventArgs e)
        {
            digimonListWrapper.Visible = false;
            digimons.Clear();
            digimonEvolutions.Clear();
            digimonDevolutions.Clear();
            HashSet<string> digimonIDs = new(StringComparer.OrdinalIgnoreCase);
            var checkedItems = new List<DSCSMod>();
            for (var i = 0; i < modListBox.Items.Count; i++)
            {
                if (modListBox.GetItemChecked(i))
                {
                    checkedItems.Add(dscsMods[i]);
                }
            }
            foreach (var i in checkedItems)
            {
                var modDigimonIDs = i.CollectDigimonIDs(this);
                digimonIDs.UnionWith(modDigimonIDs);
            }
            LogMessage("Found information about " + digimonIDs.Count + " digimons from all mods.");

            foreach (var i in checkedItems)
            {
                var modDigimonData = i.CollectDigimonData(this, checkedItems.IndexOf(i), digimonIDs);
                foreach (var item in modDigimonData.Keys)
                {
                    if (!digimons.ContainsKey(item))
                    {
                        digimons.Add(item, modDigimonData[item]);
                    }
                    else
                    {
                        digimons[item] = modDigimonData[item];
                    }
                }
            }
            LogMessage("Loaded " + digimons.Count + " digimons from all mods.");

            foreach (var i in checkedItems)
            {
                i.LoadDigimonEvolutions(this, digimons.Keys.ToHashSet(StringComparer.OrdinalIgnoreCase), digimonEvolutions);
            }

            LogMessage("Loaded evolution records for " + digimonEvolutions.Count + " digimons from all mods.");

            foreach(var mon in digimonEvolutions.Keys)
            {
                foreach (var evomon in digimonEvolutions[mon])
                {
                    if (digimonDevolutions.ContainsKey(evomon))
                    {
                        digimonDevolutions[evomon].Add(mon);
                    }
                    else
                    {
                        digimonDevolutions.Add(evomon, [mon]);
                    }
                }
            }
            LogMessage("Generated devolution records for " + digimonDevolutions.Count + " digimons from all mods.");

            digimonLists[0] = digimons.Values.Where(x => x.Level == 1).ToList();
            digimonLists[0].Sort();
            digimonInTraining1List.DataSource = digimonLists[0];
            digimonLists[1] = digimons.Values.Where(x => x.Level == 2).ToList();
            digimonLists[1].Sort();
            digimonInTraining2List.DataSource = digimonLists[1];
            digimonLists[2] = digimons.Values.Where(x => x.Level == 3).ToList();
            digimonLists[2].Sort();
            digimonRookieList.DataSource = digimonLists[2];
            digimonLists[3] = digimons.Values.Where(x => x.Level == 4).ToList();
            digimonLists[3].Sort();
            digimonChampionList.DataSource = digimonLists[3];
            digimonLists[4] = digimons.Values.Where(x => x.Level == 8).ToList();
            digimonLists[4].Sort();
            digimonArmorList.DataSource = digimonLists[4];
            digimonLists[5] = digimons.Values.Where(x => x.Level == 5).ToList();
            digimonLists[5].Sort();
            digimonUltimateList.DataSource = digimonLists[5];
            digimonLists[6] = digimons.Values.Where(x => x.Level == 6).ToList();
            digimonLists[6].Sort();
            digimonMegaList.DataSource = digimonLists[6];
            digimonLists[7] = digimons.Values.Where(x => x.Level == 7).ToList();
            digimonLists[7].Sort();
            digimonUltraList.DataSource = digimonLists[7];
            ValidateEvolutions();

            digimonListWrapper.Visible = true;
        }

        private bool ValidateEvolutions()
        {
            var valid = true;
            var levels = new string[] { "In-Training 1", "In-Training 2", "Rookie", "Champion", "Armor", "Ultimate", "Mega", "Ultra" };
            var digimonPreEvos = new List<Digimon>[8];
            var digimonEvos = new List<Digimon>[8];

            for (var i = 0; i < digimonLists.Length; i++)
            {
                digimonPreEvos[i] = digimonLists[i].Where(x => digimonDevolutions.ContainsKey(x.ID) && digimonDevolutions[x.ID].Count > 6).ToList();
                digimonEvos[i] = digimonLists[i].Where(x => digimonEvolutions.ContainsKey(x.ID) && digimonEvolutions[x.ID].Count > 6).ToList();

                if (digimonPreEvos[i].Any())
                {
                    valid = false;
                    LogMessage("The following " + levels[i] + " Digimon can be evolved from more than 6 mons:");
                    foreach (var mon in digimonPreEvos[i])
                    {
                        LogMessage(mon.ToString(), false);
                    }
                }

                if (digimonEvos[i].Any())
                {
                    valid = false;
                    LogMessage("The following " + levels[i] + " Digimon can be evolved to more than 6 mons:");
                    foreach (var mon in digimonEvos[i])
                    {
                        LogMessage(mon.ToString(), false);
                    }
                }
            }

            return valid;
        }
    }
}
