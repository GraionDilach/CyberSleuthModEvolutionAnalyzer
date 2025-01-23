using System.Linq;

namespace Cyber_Sleuth_Mod_Evolution_Analyzer
{
    public partial class Form1 : Form
    {
        readonly List<DSCSMod> dscsMods = [];
        //readonly Dictionary<string, Digimon> digimons = new(StringComparer.OrdinalIgnoreCase);
        readonly Dictionary<string, List<string>> digimonEvolutions = new(StringComparer.OrdinalIgnoreCase);
        readonly Dictionary<string, List<string>> digimonDevolutions = new(StringComparer.OrdinalIgnoreCase);
        readonly DigimonEvolutionOption[] deevos;
        readonly DigimonEvolutionOption[] evos;

        List<Digimon> listDigimons = [];
        List<Digimon>[] digimonLists = new List<Digimon>[8];
        Digimon? selectedDigimon;

        public Form1()
        {
            InitializeComponent();
            deevos = [digimonDeEvo1,
                digimonDeEvo2,
                digimonDeEvo3,
                digimonDeEvo4,
                digimonDeEvo5,
                digimonDeEvo6,
                digimonDeEvo7,
                digimonDeEvo8,
                digimonDeEvo9,
                digimonDeEvo10,
                digimonDeEvo11,
            ];
            evos = [digimonEvo1,
                digimonEvo2,
                digimonEvo3,
                digimonEvo4,
                digimonEvo5,
                digimonEvo6,
                digimonEvo7,
                digimonEvo8,
                digimonEvo9,
                digimonEvo10,
                digimonEvo11,
            ];
        }

        private void modsLocationBrowser_Click(object sender, EventArgs e)
        {
            modList.Visible = false;
            dscsMods.Clear();
            listDigimons.Clear();
            digimonEvolutions.Clear();
            digimonDevolutions.Clear();
            selectedDigimon = null;
            UpdateSelectedDigimon();
            for (int i = 0; i < digimonLists.Length; i++)
            {
                digimonLists[i] = new List<Digimon>();
            }
            DialogResult result = modFolderLocator.ShowDialog();
            digimonDataContainer.Visible = false;
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
            digimonDataContainer.Visible = false;
            listDigimons.Clear();
            digimonEvolutions.Clear();
            digimonDevolutions.Clear();
            foreach (var item in deevos)
            {
                item.Options = new List<Digimon>();
                item.Visible = false;
            }
            selectedDigimon = null;
            UpdateSelectedDigimon();
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

            Dictionary<string, Digimon> digimons = new(StringComparer.OrdinalIgnoreCase);

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

            foreach (var mon in digimonEvolutions.Keys)
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

            var sortedList = digimons.Values.ToList();
            sortedList.Sort();
            listDigimons = sortedList;

            foreach (var item in deevos)
            {
                item.Options = listDigimons;
            }

            foreach (var item in evos)
            {
                item.Options = listDigimons;
            }

            ValidateEvolutions();

            digimonLists[7] = digimons.Values.Where(x => x.Level == 7).ToList();
            digimonLists[7].Sort();
            digimonUltraList.DataSource = digimonLists[7];
            if (digimonLists[7].Any())
            {
                digimonList.SelectedIndex = 7;
            }

            digimonLists[6] = digimons.Values.Where(x => x.Level == 6).ToList();
            digimonLists[6].Sort();
            digimonMegaList.DataSource = digimonLists[6];
            if (digimonLists[6].Any())
            {
                digimonList.SelectedIndex = 6;
            }

            digimonLists[5] = digimons.Values.Where(x => x.Level == 5).ToList();
            digimonLists[5].Sort();
            digimonUltimateList.DataSource = digimonLists[5];
            if (digimonLists[5].Any())
            {
                digimonList.SelectedIndex = 5;
            }

            digimonLists[4] = digimons.Values.Where(x => x.Level == 8).ToList();
            digimonLists[4].Sort();
            digimonArmorList.DataSource = digimonLists[4];
            if (digimonLists[4].Any())
            {
                digimonList.SelectedIndex = 4;
            }

            digimonLists[3] = digimons.Values.Where(x => x.Level == 4).ToList();
            digimonLists[3].Sort();
            digimonChampionList.DataSource = digimonLists[3];
            if (digimonLists[3].Any())
            {
                digimonList.SelectedIndex = 3;
            }

            digimonLists[2] = digimons.Values.Where(x => x.Level == 3).ToList();
            digimonLists[2].Sort();
            digimonRookieList.DataSource = digimonLists[2];
            if (digimonLists[2].Any())
            {
                digimonList.SelectedIndex = 2;
            }

            digimonLists[1] = digimons.Values.Where(x => x.Level == 2).ToList();
            digimonLists[1].Sort();
            digimonInTraining2List.DataSource = digimonLists[1];
            if (digimonLists[1].Any())
            {
                digimonList.SelectedIndex = 1;
            }

            digimonLists[0] = digimons.Values.Where(x => x.Level == 1).ToList();
            digimonLists[0].Sort();
            digimonInTraining1List.DataSource = digimonLists[0];
            if (digimonLists[0].Any())
            {
                digimonList.SelectedIndex = 0;
            }

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

        private void UpdateSelectedDigimon()
        {
            if (selectedDigimon != null)
            {
                digimonName.Text = selectedDigimon.ToString();
                if (digimonDevolutions.ContainsKey(selectedDigimon.ID))
                {
                    for (var i = 0; i < digimonDevolutions[selectedDigimon.ID].Count && i < deevos.Length; i++)
                    {
                        var tempID = digimonDevolutions[selectedDigimon.ID][i];
                        deevos[i].SelectedDigimon = listDigimons.First(x => x.ID == tempID);
                        deevos[i].Visible = true;
                    }
                    if (digimonDevolutions[selectedDigimon.ID].Count < 6)
                    {
                        deevos[digimonDevolutions[selectedDigimon.ID].Count].SelectedDigimon = new Digimon();
                        deevos[digimonDevolutions[selectedDigimon.ID].Count].Visible = true;
                    }
                    for (var i = digimonDevolutions[selectedDigimon.ID].Count + 1; i < deevos.Length; i++)
                    {
                        deevos[i].SelectedDigimon = new Digimon();
                        deevos[i].Visible = false;
                    }
                }
                else
                {
                    deevos[0].SelectedDigimon = new Digimon();
                    deevos[0].Visible = true;

                    for (var i = 1; i < deevos.Length; i++)
                    {
                        deevos[i].SelectedDigimon = new Digimon();
                        deevos[i].Visible = false;
                    }
                }
                if (digimonEvolutions.ContainsKey(selectedDigimon.ID))
                {
                    for (var i = 0; i < digimonEvolutions[selectedDigimon.ID].Count && i < evos.Length; i++)
                    {
                        var tempID = digimonEvolutions[selectedDigimon.ID][i];
                        evos[i].SelectedDigimon = listDigimons.First(x => x.ID == tempID);
                        evos[i].Visible = true;
                    }
                    if (digimonEvolutions[selectedDigimon.ID].Count < 6)
                    {
                        evos[digimonEvolutions[selectedDigimon.ID].Count].SelectedDigimon = new Digimon();
                        evos[digimonEvolutions[selectedDigimon.ID].Count].Visible = true;
                    }
                    for (var i = digimonEvolutions[selectedDigimon.ID].Count + 1; i < evos.Length; i++)
                    {
                        evos[i].SelectedDigimon = new Digimon();
                        evos[i].Visible = false;
                    }
                }
                else
                {
                    evos[0].SelectedDigimon = new Digimon();
                    evos[0].Visible = true;

                    for (var i = 1; i < evos.Length; i++)
                    {
                        evos[i].SelectedDigimon = new Digimon();
                        evos[i].Visible = false;
                    }
                }
            }
            else
            {
                digimonName.Text = String.Empty;
                for (var i = 0; i < deevos.Length; i++)
                {
                    deevos[i].SelectedDigimon = new Digimon();
                    deevos[i].Visible = false;
                }
                for (var i = 0; i < evos.Length; i++)
                {
                    evos[i].SelectedDigimon = new Digimon();
                    evos[i].Visible = false;
                }
            }
        }

        private void digimonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            digimonDataContainer.Visible = false;
            var sourceBox = sender as ListBox;
            if (sourceBox != null)
            {
                var dataSource = sourceBox.DataSource;
                if (dataSource != null)
                {
                    var digimonList = dataSource as List<Digimon>;
                    if (digimonList != null && sourceBox.SelectedIndex > -1)
                    {
                        selectedDigimon = digimonList[sourceBox.SelectedIndex];
                        UpdateSelectedDigimon();
                    }
                    else
                    {
                        selectedDigimon = null;
                        UpdateSelectedDigimon();
                    }
                }
            }
            digimonDataContainer.Visible = true;
        }

        private void digimonList_SelectedTabIndexChanged(object sender, EventArgs e)
        {
            digimonDataContainer.Visible = false;
            var tabControl = sender as TabControl;
            if (tabControl != null)
            {
                var list = new ListBox[]{digimonInTraining1List,
                    digimonInTraining2List,
                    digimonRookieList,
                    digimonChampionList,
                    digimonArmorList,
                    digimonUltimateList,
                    digimonMegaList,
                    digimonUltraList
                };

                var selectedMonIndex = list[tabControl.SelectedIndex].SelectedIndex;
                var digimonList = list[tabControl.SelectedIndex].DataSource as List<Digimon>;

                if (digimonList != null && list[tabControl.SelectedIndex].SelectedIndex > -1)
                {
                    selectedDigimon = digimonList[list[tabControl.SelectedIndex].SelectedIndex];
                    UpdateSelectedDigimon();
                }
                else
                {
                    selectedDigimon = null;
                    UpdateSelectedDigimon();
                }
            }
            digimonDataContainer.Visible = true;
        }

        private void digimonDeEvo_SelectedDigimonChanged(object sender, EventArgs e)
        {
            if (digimonDataContainer.Visible && selectedDigimon != null)
            {
                digimonDataContainer.Visible = false;
                var updatedList = new List<string>();
                for (int i = 0; i < deevos.Length; i++)
                {
                    if (deevos[i].SelectedIndex > -1)
                    {
                        updatedList.Add(deevos[i].SelectedDigimon.ID);
                    }
                }

                if (digimonDevolutions.ContainsKey(selectedDigimon.ID))
                {
                    digimonDevolutions[selectedDigimon.ID] = new List<string>(updatedList);
                }
                else
                {
                    digimonDevolutions.Add(selectedDigimon.ID, new List<string>(updatedList));
                }

                var tempEvos = digimonEvolutions.Where(x => x.Value.Contains(selectedDigimon.ID)).ToList();
                foreach (var evo in tempEvos)
                {
                    if (updatedList.Contains(evo.Key))
                    {
                        updatedList.Remove(evo.Key);
                    }
                    else
                    {
                        digimonEvolutions[evo.Key].Remove(selectedDigimon.ID);
                    }
                }

                if (updatedList.Count == 1)
                {
                    if (digimonEvolutions.ContainsKey(updatedList[0]))
                    {
                        digimonEvolutions[updatedList[0]].Add(selectedDigimon.ID);
                    }
                    else
                    {
                        digimonEvolutions.Add(updatedList[0], new List<string> { selectedDigimon.ID });
                    }
                }

                UpdateSelectedDigimon();
                digimonDataContainer.Visible = true;
            }
        }

        private void digimonEvo_SelectedDigimonChanged(object sender, EventArgs e)
        {
            if (digimonDataContainer.Visible && selectedDigimon != null)
            {
                digimonDataContainer.Visible = false;
                var updatedList = new List<string>();
                for (int i = 0; i < evos.Length; i++)
                {
                    if (evos[i].SelectedIndex > -1)
                    {
                        updatedList.Add(evos[i].SelectedDigimon.ID);
                    }
                }

                if (digimonEvolutions.ContainsKey(selectedDigimon.ID))
                {
                    digimonEvolutions[selectedDigimon.ID] = new List<string>(updatedList);
                }
                else
                {
                    digimonEvolutions.Add(selectedDigimon.ID, new List<string>(updatedList));
                }

                var tempEvos = digimonDevolutions.Where(x => x.Value.Contains(selectedDigimon.ID)).ToList();
                foreach (var evo in tempEvos)
                {
                    if (updatedList.Contains(evo.Key))
                    {
                        updatedList.Remove(evo.Key);
                    }
                    else
                    {
                        digimonDevolutions[evo.Key].Remove(selectedDigimon.ID);
                    }
                }

                if (updatedList.Count == 1)
                {
                    if (digimonDevolutions.ContainsKey(updatedList[0]))
                    {
                        digimonDevolutions[updatedList[0]].Add(selectedDigimon.ID);
                    }
                    else
                    {
                        digimonDevolutions.Add(updatedList[0], new List<string> { selectedDigimon.ID });
                    }
                }

                UpdateSelectedDigimon();
                digimonDataContainer.Visible = true;
            }
        }
    }
}
