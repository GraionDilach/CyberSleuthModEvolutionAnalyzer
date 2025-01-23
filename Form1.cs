namespace Cyber_Sleuth_Mod_Evolution_Analyzer
{
    public partial class Form1 : Form
    {
        readonly List<DSCSMod> dscsMods = [];
        readonly List<Digimon> monInTraining1List = new();
        readonly List<Digimon> monInTraining2List = new();
        readonly List<Digimon> monRookieList = new();
        readonly List<Digimon> monChampionList = new();
        readonly List<Digimon> monArmorList = new();
        readonly List<Digimon> monUltimateList = new();
        readonly List<Digimon> monMegaList = new();
        readonly List<Digimon> monUltraList = new();
        readonly Dictionary<string, Digimon> digimons = new(StringComparer.OrdinalIgnoreCase);
        readonly Dictionary<string, List<string>> digimonEvolutions = new(StringComparer.OrdinalIgnoreCase);
        readonly Dictionary<string, List<string>> digimonDevolutions = new(StringComparer.OrdinalIgnoreCase);

        public Form1()
        {
            InitializeComponent();
        }

        private void modsLocationBrowser_Click(object sender, EventArgs e)
        {
            modList.Visible = false;
            dscsMods.Clear();
            digimons.Clear();
            monInTraining1List.Clear();
            monInTraining2List.Clear();
            monRookieList.Clear();
            monChampionList.Clear();
            monArmorList.Clear();
            monUltimateList.Clear();
            monMegaList.Clear();
            monUltraList.Clear();
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

        public void LogMessage(string message)
        {
            logBox.AppendText("[" + DateTime.Now.ToShortTimeString() + "] " + message + Environment.NewLine);
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
            monInTraining1List.Clear();
            monInTraining2List.Clear();
            monRookieList.Clear();
            monChampionList.Clear();
            monArmorList.Clear();
            monUltimateList.Clear();
            monMegaList.Clear();
            monUltraList.Clear();
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

            monInTraining1List.AddRange(digimons.Values.Where(x => x.Level == 1).ToList());
            monInTraining1List.Sort();
            digimonInTraining1List.DataSource = monInTraining1List;
            monInTraining2List.AddRange(digimons.Values.Where(x => x.Level == 2).ToList());
            monInTraining2List.Sort();
            digimonInTraining2List.DataSource = monInTraining2List;
            monRookieList.AddRange(digimons.Values.Where(x => x.Level == 3).ToList());
            monRookieList.Sort();
            digimonRookieList.DataSource = monRookieList;
            monChampionList.AddRange(digimons.Values.Where(x => x.Level == 4).ToList());
            monChampionList.Sort();
            digimonChampionList.DataSource = monChampionList;
            monUltimateList.AddRange(digimons.Values.Where(x => x.Level == 5).ToList());
            monUltimateList.Sort();
            digimonUltimateList.DataSource = monUltimateList;
            monMegaList.AddRange(digimons.Values.Where(x => x.Level == 6).ToList());
            monMegaList.Sort();
            digimonMegaList.DataSource = monMegaList;
            monUltraList.AddRange(digimons.Values.Where(x => x.Level == 7).ToList());
            monUltraList.Sort();
            digimonUltraList.DataSource = monUltraList;
            monArmorList.AddRange(digimons.Values.Where(x => x.Level == 8).ToList());
            monArmorList.Sort();
            digimonArmorList.DataSource = monArmorList;

            digimonListWrapper.Visible = true;
        }
    }
}
