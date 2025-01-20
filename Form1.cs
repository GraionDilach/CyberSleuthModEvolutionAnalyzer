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

                            LogMessage("Parsed " + potentialMod + " as " + dscsMod.Name +".");
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
    }
}
