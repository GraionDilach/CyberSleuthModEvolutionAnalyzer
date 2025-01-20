using System.IO;
using System.Windows.Forms;

namespace Cyber_Sleuth_Mod_Evolution_Analyzer
{
    public partial class Form1 : Form
    {
        readonly List<DSCSMod> dscsMods = [];

        public Form1()
        {
            InitializeComponent();
        }

        private void modsLocationBrowser_Click(object sender, EventArgs e)
        {
            DialogResult result = modFolderLocator.ShowDialog();
            if (result == DialogResult.OK)
            {
                dscsMods.Clear();
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
                        LogMessage("Failed to parse " + potentialMod + " folder as mod.");
                    }
                }
                modsLocation.Text = modFolderLocator.SelectedPath;
                modListBox.DataSource = dscsMods;
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
                for (int i = 0; i < modListBox.Items.Count; i++)
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
                for (int i = 0; i < modListBox.Items.Count; i++)
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
    }
}
