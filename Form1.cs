using System.Linq;
using System.Windows.Forms;

namespace Cyber_Sleuth_Mod_Evolution_Analyzer
{
    public partial class Form1 : Form
    {
        readonly List<DSCSMod> dscsMods = [];
        readonly Dictionary<string, Digimon> digimons = new(StringComparer.OrdinalIgnoreCase);
        readonly DigimonEvolutionOption[] deevos;
        readonly DigimonEvolutionOption[] evos;

        DigimonListEntry? selectedDigimon;
        bool edited;
        string? rootFolder;
        Tuple<List<DigimonListEntry>, BindingSource>[] digimonLists = new Tuple<List<DigimonListEntry>, BindingSource>[8];

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
            if (edited)
            {
                var warningResult = MessageBox.Show(
                    "Reloading the mods will overwrite the ongoing changes.\n"
                    + "Are you sure you want to continue?",
                    "Warning!", MessageBoxButtons.YesNo);
                if (warningResult == DialogResult.No)
                {
                    return;
                }
            }
            modList.Visible = false;
            dscsMods.Clear();
            digimons.Clear();
            selectedDigimon = null;
            UpdateSelectedDigimon();
            for (int i = 0; i < digimonLists.Length; i++)
            {
                digimonLists[i] = new Tuple<List<DigimonListEntry>, BindingSource>([], []);
            }
            DialogResult result = modFolderLocator.ShowDialog();
            digimonDataContainer.Visible = false;
            if (result == DialogResult.OK)
            {
                rootFolder = modFolderLocator.SelectedPath;
                var potentialMods = Directory.GetDirectories(rootFolder)
                    .Select(x => x.Substring(rootFolder.Length + 1));
                var unorderedMods = new List<DSCSMod>();
                foreach (var potentialMod in potentialMods)
                {
                    try
                    {
                        if (File.Exists(rootFolder + "\\" + potentialMod + @"\METADATA.json"))
                        {
                            var dscsMod = new DSCSMod(rootFolder, potentialMod);
                            unorderedMods.Add(dscsMod);

                            LogMessage("Parsed " + potentialMod + " as " + dscsMod.Name + ".");
                        }
                    }
                    catch (Exception)
                    {
                        LogMessage("Failed to parse " + potentialMod + " folder as a DSCS mod.");
                    }
                }
                var generatedMods = unorderedMods.Where(x => x.Generated);

                foreach (var generatedMod in generatedMods)
                {
                    for (int i = 0; i < generatedMod.SourceMods.Length; i++)
                    {
                        var mod = unorderedMods.SingleOrDefault(x => x.Folder == generatedMod.SourceMods[i]);
                        if (mod != null && !dscsMods.Contains(mod))
                        {
                            dscsMods.Add(mod);
                        }
                    }
                }

                foreach (var mod in unorderedMods)
                {
                    if (!dscsMods.Contains(mod))
                    {
                        dscsMods.Add(mod);
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
            if (edited)
            {
                var warningResult = MessageBox.Show(
                    "Reloading the mods will overwrite the ongoing changes.\n"
                    + "Are you sure you want to continue?",
                    "Warning!", MessageBoxButtons.YesNo);
                if (warningResult == DialogResult.No)
                {
                    return;
                }
            }
            digimonListWrapper.Visible = false;
            digimonDataContainer.Visible = false;
            digimons.Clear();
            for (int i = 0; i < digimonLists.Length; i++)
            {
                digimonLists[i] = new Tuple<List<DigimonListEntry>, BindingSource>([], []);
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

            var baseMons = BaseDigimonStats.CollectDigimonData(this);

            foreach (var item in baseMons)
            {
                digimons.Add(item.Key, item.Value);
            }

            foreach (var i in checkedItems)
            {
                var modDigimonData = i.CollectDigimonData(this, checkedItems.IndexOf(i) + 1);
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

            var digimonEvolutions = BaseDigimonStats.LoadDigimonEvolutions(this);

            foreach (var i in checkedItems)
            {
                i.LoadDigimonEvolutions(this, digimons.Keys.ToHashSet(StringComparer.OrdinalIgnoreCase), digimonEvolutions);
            }

            LogMessage("Loaded evolution records for " + digimonEvolutions.Count + " digimons from all mods.");

            Dictionary<string, List<string>> digimonDevolutions = new(StringComparer.OrdinalIgnoreCase);

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

            foreach (var mon in digimons)
            {
                if (!digimonDevolutions.ContainsKey(mon.Key))
                {
                    digimonDevolutions.Add(mon.Key, new List<string>());
                }
                if (!digimonEvolutions.ContainsKey(mon.Key))
                {
                    digimonEvolutions.Add(mon.Key, new List<string>());
                }
            }

            var sortedList = digimons.Values.ToList();
            sortedList.Sort();

            foreach (var item in deevos)
            {
                item.Options = sortedList;
            }

            foreach (var item in evos)
            {
                item.Options = sortedList;
            }

            var ultraList = digimons.Values.Where(x => x.Level == 7)
                .Select(x => new DigimonListEntry(x, digimonDevolutions[x.ID], digimonEvolutions[x.ID]))
                .ToList();
            ultraList.Sort();
            var ultraBind = new BindingSource();
            digimonLists[7] = new Tuple<List<DigimonListEntry>, BindingSource>(ultraList, ultraBind);
            digimonLists[7].Item2.DataSource = digimonLists[7].Item1;
            digimonUltraList.DataSource = digimonLists[7].Item2;
            if (digimonLists[7].Item1.Count != 0)
            {
                digimonList.SelectedIndex = 7;
            }

            var megaList = digimons.Values.Where(x => x.Level == 6)
                .Select(x => new DigimonListEntry(x, digimonDevolutions[x.ID], digimonEvolutions[x.ID]))
                .ToList();
            megaList.Sort();
            var megaBind = new BindingSource();
            digimonLists[6] = new Tuple<List<DigimonListEntry>, BindingSource>(megaList, megaBind);
            digimonLists[6].Item2.DataSource = digimonLists[6].Item1;
            digimonMegaList.DataSource = digimonLists[6].Item2;
            if (digimonLists[6].Item1.Count != 0)
            {
                digimonList.SelectedIndex = 6;
            }

            var ultimateList = digimons.Values.Where(x => x.Level == 5)
                .Select(x => new DigimonListEntry(x, digimonDevolutions[x.ID], digimonEvolutions[x.ID]))
                .ToList();
            ultimateList.Sort();
            var ultimateBind = new BindingSource();
            digimonLists[5] = new Tuple<List<DigimonListEntry>, BindingSource>(ultimateList, ultimateBind);
            digimonLists[5].Item2.DataSource = digimonLists[5].Item1;
            digimonUltimateList.DataSource = digimonLists[5].Item2;
            if (digimonLists[5].Item1.Count != 0)
            {
                digimonList.SelectedIndex = 5;
            }

            var armorList = digimons.Values.Where(x => x.Level == 8)
                .Select(x => new DigimonListEntry(x, digimonDevolutions[x.ID], digimonEvolutions[x.ID]))
                .ToList();
            armorList.Sort();
            var armorBind = new BindingSource();
            digimonLists[4] = new Tuple<List<DigimonListEntry>, BindingSource>(armorList, armorBind);
            digimonLists[4].Item2.DataSource = digimonLists[4].Item1;
            digimonArmorList.DataSource = digimonLists[4].Item2;
            if (digimonLists[4].Item1.Count != 0)
            {
                digimonList.SelectedIndex = 4;
            }

            var championList = digimons.Values.Where(x => x.Level == 4)
                .Select(x => new DigimonListEntry(x, digimonDevolutions[x.ID], digimonEvolutions[x.ID]))
                .ToList();
            championList.Sort();
            var championBind = new BindingSource();
            digimonLists[3] = new Tuple<List<DigimonListEntry>, BindingSource>(championList, championBind);
            digimonLists[3].Item2.DataSource = digimonLists[3].Item1;
            digimonChampionList.DataSource = digimonLists[3].Item2;
            if (digimonLists[3].Item1.Count != 0)
            {
                digimonList.SelectedIndex = 3;
            }

            var rookieList = digimons.Values.Where(x => x.Level == 3)
                .Select(x => new DigimonListEntry(x, digimonDevolutions[x.ID], digimonEvolutions[x.ID]))
                .ToList();
            rookieList.Sort();
            var rookieBind = new BindingSource();
            digimonLists[2] = new Tuple<List<DigimonListEntry>, BindingSource>(rookieList, rookieBind);
            digimonLists[2].Item2.DataSource = digimonLists[2].Item1;
            digimonRookieList.DataSource = digimonLists[2].Item2;
            if (digimonLists[2].Item1.Count != 0)
            {
                digimonList.SelectedIndex = 2;
            }

            var it2List = digimons.Values.Where(x => x.Level == 2)
                .Select(x => new DigimonListEntry(x, digimonDevolutions[x.ID], digimonEvolutions[x.ID]))
                .ToList();
            it2List.Sort();
            var it2Bind = new BindingSource();
            digimonLists[1] = new Tuple<List<DigimonListEntry>, BindingSource>(it2List, it2Bind);
            digimonLists[1].Item2.DataSource = digimonLists[1].Item1;
            digimonInTraining2List.DataSource = digimonLists[1].Item2;
            if (digimonLists[1].Item1.Count != 0)
            {
                digimonList.SelectedIndex = 1;
            }

            var it1List = digimons.Values.Where(x => x.Level == 1)
                .Select(x => new DigimonListEntry(x, digimonDevolutions[x.ID], digimonEvolutions[x.ID]))
                .ToList();
            it1List.Sort();
            var it1Bind = new BindingSource();
            digimonLists[0] = new Tuple<List<DigimonListEntry>, BindingSource>(it1List, it1Bind);
            digimonLists[0].Item2.DataSource = digimonLists[0].Item1;
            digimonInTraining1List.DataSource = digimonLists[0].Item2;
            if (digimonLists[0].Item1.Count != 0)
            {
                digimonList.SelectedIndex = 0;
            }

            digimonListWrapper.Visible = true;
            ValidateEvolutions();
            modGenerator.Visible = true;
            edited = false;
        }

        private bool ValidateEvolutions()
        {
            var valid = true;
            var levels = new string[] { "In-Training 1", "In-Training 2", "Rookie", "Champion", "Armor", "Ultimate", "Mega", "Ultra" };
            var digimonPreEvos = new List<Digimon>[8];
            var digimonEvos = new List<Digimon>[8];

            for (var i = 0; i < digimonLists.Length; i++)
            {
                digimonPreEvos[i] = digimonLists[i].Item1.Where(x => x.Devolutions.Count > 6).Select(x => x.Digimon).ToList();
                digimonEvos[i] = digimonLists[i].Item1.Where(x => x.Evolutions.Count > 6).Select(x => x.Digimon).ToList();

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

            return valid;
        }

        private void UpdateSelectedDigimon(bool resetBind = true)
        {
            if (!selectedDigimon.IsNullOrEmpty())
            {
                digimonName.Text = selectedDigimon.Digimon.ToString();

                for (var i = 0; i < selectedDigimon.Devolutions.Count && i < deevos.Length; i++)
                {
                    deevos[i].SelectedDigimon = digimons[selectedDigimon.Devolutions[i]];
                    deevos[i].Visible = true;
                }
                for (var i = selectedDigimon.Devolutions.Count; i < deevos.Length; i++)
                {
                    deevos[i].SelectedDigimon = new Digimon();
                    deevos[i].Visible = false;
                }
                if (selectedDigimon.Devolutions.Count < 6)
                {
                    deevos[selectedDigimon.Devolutions.Count].Visible = true;
                }
                for (var i = 0; i < selectedDigimon.Evolutions.Count && i < evos.Length; i++)
                {
                    evos[i].SelectedDigimon = digimons[selectedDigimon.Evolutions[i]];
                    evos[i].Visible = true;
                }
                for (var i = selectedDigimon.Evolutions.Count; i < evos.Length; i++)
                {
                    evos[i].SelectedDigimon = new Digimon();
                    evos[i].Visible = false;
                }
                if (selectedDigimon.Evolutions.Count < 6)
                {
                    evos[selectedDigimon.Evolutions.Count].Visible = true;
                }

                if (resetBind)
                {
                    digimonLists[digimonList.SelectedIndex].Item2.ResetBindings(false);
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
            if (sender is ListBox sourceBox)
            {
                var dataSource = sourceBox.DataSource;
                if (dataSource != null)
                {
                    var bind = dataSource as BindingSource;
                    if (bind != null && sourceBox.SelectedIndex > -1)
                    {
                        for (var i = 0; i < digimonLists.Length; i++)
                        {
                            if (digimonLists[i].Item2 == bind)
                            {
                                selectedDigimon = digimonLists[i].Item1[sourceBox.SelectedIndex];
                                UpdateSelectedDigimon(false);
                            }
                        }
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
            if (sender is TabControl tabControl)
            {
                var list = new ListBox[]
                {
                    digimonInTraining1List,
                    digimonInTraining2List,
                    digimonRookieList,
                    digimonChampionList,
                    digimonArmorList,
                    digimonUltimateList,
                    digimonMegaList,
                    digimonUltraList
                };

                var bind = list[tabControl.SelectedIndex].DataSource as BindingSource;
                if (bind != null && list[tabControl.SelectedIndex].SelectedIndex > -1)
                {
                    for (var i = 0; i < digimonLists.Length; i++)
                    {
                        if (digimonLists[i].Item2 == bind)
                        {
                            selectedDigimon = digimonLists[i].Item1[list[tabControl.SelectedIndex].SelectedIndex];
                            UpdateSelectedDigimon();
                        }
                    }
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
            if (digimonDataContainer.Visible && !selectedDigimon.IsNullOrEmpty())
            {
                digimonDataContainer.Visible = false;

                if (sender is DigimonEvolutionOption deevooption)
                {
                    var index = Array.IndexOf(deevos, deevooption);
                    if (index != -1)
                    {
                        if (index < selectedDigimon.Devolutions.Count)
                        {
                            var oldDeevo = selectedDigimon.Devolutions[index];
                            if (deevooption.SelectedDigimon != null && !String.IsNullOrEmpty(deevooption.SelectedDigimon.ID))
                            {
                                selectedDigimon.Devolutions[index] = deevooption.SelectedDigimon.ID;

                                foreach (var lists in digimonLists)
                                {
                                    foreach (var evoMon in lists.Item1)
                                    {
                                        if (String.Equals(evoMon.Digimon.ID, oldDeevo))
                                        {
                                            evoMon.Evolutions.Remove(selectedDigimon.Digimon.ID);
                                        }

                                        if (String.Equals(evoMon.Digimon.ID, selectedDigimon.Devolutions[index]))
                                        {
                                            evoMon.Evolutions.Add(selectedDigimon.Digimon.ID);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                selectedDigimon.Devolutions.Remove(oldDeevo);

                                foreach (var lists in digimonLists)
                                {
                                    foreach (var evoMon in lists.Item1)
                                    {
                                        if (String.Equals(evoMon.Digimon.ID, oldDeevo))
                                        {
                                            evoMon.Evolutions.Remove(selectedDigimon.Digimon.ID);
                                            deevooption.SelectedDigimon = deevos[index+1].SelectedDigimon;
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (index == selectedDigimon.Devolutions.Count)
                            {
                                selectedDigimon.Devolutions.Add(deevooption.SelectedDigimon.ID);

                                foreach (var lists in digimonLists)
                                {
                                    foreach (var evoMon in lists.Item1)
                                    {
                                        if (String.Equals(evoMon.Digimon.ID, selectedDigimon.Devolutions[index]))
                                        {
                                            evoMon.Evolutions.Add(selectedDigimon.Digimon.ID);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                edited = true;
                UpdateSelectedDigimon();
                digimonDataContainer.Visible = true;
            }
        }

        private void digimonEvo_SelectedDigimonChanged(object sender, EventArgs e)
        {
            if (digimonDataContainer.Visible && !selectedDigimon.IsNullOrEmpty())
            {
                digimonDataContainer.Visible = false;

                if (sender is DigimonEvolutionOption evooption)
                {
                    var index = Array.IndexOf(evos, evooption);
                    if (index != -1)
                    {
                        if (index < selectedDigimon.Evolutions.Count)
                        {
                            var oldEvo = selectedDigimon.Evolutions[index];
                            if (evooption.SelectedDigimon != null && !String.IsNullOrEmpty(evooption.SelectedDigimon.ID))
                            {
                                selectedDigimon.Evolutions[index] = evooption.SelectedDigimon.ID;

                                foreach (var lists in digimonLists)
                                {
                                    foreach (var deEvoMon in lists.Item1)
                                    {
                                        if (String.Equals(deEvoMon.Digimon.ID, oldEvo))
                                        {
                                            deEvoMon.Devolutions.Remove(selectedDigimon.Digimon.ID);
                                        }

                                        if (String.Equals(deEvoMon.Digimon.ID, selectedDigimon.Evolutions[index]))
                                        {
                                            deEvoMon.Devolutions.Add(selectedDigimon.Digimon.ID);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                selectedDigimon.Evolutions.Remove(oldEvo);

                                foreach (var list in digimonLists)
                                {
                                    foreach (var deevoMon in list.Item1)
                                    {
                                        if (String.Equals(deevoMon.Digimon.ID, oldEvo))
                                        {
                                            deevoMon.Devolutions.Remove(selectedDigimon.Digimon.ID);
                                            evooption.SelectedDigimon = evos[index + 1].SelectedDigimon;
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (index == selectedDigimon.Evolutions.Count)
                            {
                                selectedDigimon.Evolutions.Add(evooption.SelectedDigimon.ID);

                                foreach (var lists in digimonLists)
                                {
                                    foreach (var deEvoMon in lists.Item1)
                                    {
                                        if (String.Equals(deEvoMon.Digimon.ID, selectedDigimon.Evolutions[index]))
                                        {
                                            deEvoMon.Devolutions.Add(selectedDigimon.Digimon.ID);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                edited = true;
                UpdateSelectedDigimon();
                digimonDataContainer.Visible = true;
            }
        }

        private void jumpToSelectedDigimon(object sender, EventArgs e)
        {
            if (digimonDataContainer.Visible && !selectedDigimon.IsNullOrEmpty())
            {
                digimonDataContainer.Visible = false;

                if (sender is DigimonEvolutionOption senderEvoControlOption)
                {
                    var jumpDigimonTarget = senderEvoControlOption.SelectedDigimon;
                    if (jumpDigimonTarget != null && !String.IsNullOrEmpty(jumpDigimonTarget.ID))
                    {
                        var boxList = new ListBox[]
                        {
                            digimonInTraining1List,
                            digimonInTraining2List,
                            digimonRookieList,
                            digimonChampionList,
                            digimonArmorList,
                            digimonUltimateList,
                            digimonMegaList,
                            digimonUltraList
                        };
                        bool jumped = false;

                        for (int i = 0; i < digimonLists.Length && !jumped; i++)
                        {
                            for (var item = 0; item < digimonLists[i].Item1.Count() && !jumped; item++)
                            {
                                if (String.Equals(digimonLists[i].Item1[item].Digimon.ID, jumpDigimonTarget.ID))
                                {
                                    if (boxList[i].DataSource as BindingSource == digimonLists[i].Item2)
                                    {
                                        selectedDigimon = digimonLists[i].Item1[item];
                                        boxList[i].SelectedIndex = item;
                                        digimonList.SelectedIndex = i;
                                        jumped = true;
                                    }
                                }
                            }
                        }
                    }
                }

                UpdateSelectedDigimon();
                digimonDataContainer.Visible = true;
            }
        }

        private void modGenerator_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(rootFolder))
            {
                return;
            }

            if (ValidateEvolutions())
            {
                using (Form2 dialog = new(dscsMods))
                {
                    DialogResult result = dialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        DSCSMod export;
                        if (File.Exists(rootFolder + "\\" + dialog.ModFolder + @"\METADATA.json"))
                        {
                            export = dscsMods.Single(x => String.Equals(x.Folder, dialog.ModFolder));
                            if (!export.Generated)
                            {
                                LogMessage("Save ABORTED! Prevented overwriting source " + export.Name + " mod.");
                                return;
                            }
                        }
                        else
                        {
                            export = new DSCSMod(rootFolder, dialog.ModFolder, dialog.ModName);
                        }

                        var checkedmods = new List<DSCSMod>();
                        for (var i = 0; i < modListBox.Items.Count; i++)
                        {
                            if (modListBox.GetItemChecked(i))
                            {
                                checkedmods.Add(dscsMods[i]);
                            }
                        }

                        export.WriteMetadata(checkedmods);

                        Dictionary<string, List<string>> digimonDevolutions = new(StringComparer.OrdinalIgnoreCase);
                        Dictionary<string, List<string>> digimonEvolutions = new(StringComparer.OrdinalIgnoreCase);

                        foreach (var list in digimonLists)
                        {
                            foreach (var item in list.Item1)
                            {
                                digimonDevolutions.Add(item.Digimon.ID, item.Devolutions);
                                digimonEvolutions.Add(item.Digimon.ID, item.Evolutions);
                            }
                        }

                        export.WriteEvolutions(digimonDevolutions, digimonEvolutions);

                        LogMessage("Successfully saved generated " + export.Name + " mod.");

                        edited = false;
                    }
                }
            }
        }

        private void aboutLabel_Click(object sender, EventArgs e)
        {
            string message = "Digimon Cyber Sleuth Mod Evolution Analyzer\n"
                + "Version: " + Application.ProductVersion + "\n"
                + "2025, Graion Dilach\n"
                + "Licensed under the MIT license.\n\n"
                + "For support and source code, please visit\n"
                + "https://github.com/GraionDilach/CyberSleuthModEvolutionAnalyzer";
            string caption = "Cyber Sleuth Mod Evolution Analyzer";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.OK)
            {
            }
        }

        private void digimonList_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = digimonList.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = digimonList.GetTabRect(e.Index);

            Font _tabFont = digimonList.Font;

            if (e.State == DrawItemState.Selected)
            {
                _textBrush = new SolidBrush(e.BackColor);
                _tabFont = new Font(_tabFont, FontStyle.Bold);
                e.DrawFocusRectangle();
            }
            else
            {
                _textBrush = new SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }
    }
}
