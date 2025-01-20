using System.Windows.Forms;

namespace Cyber_Sleuth_Mod_Evolution_Analyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void modsLocationBrowser_Click(object sender, EventArgs e)
        {
            DialogResult result = modFolderLocator.ShowDialog();
            if (result == DialogResult.OK)
            {
                modsLocation.Text = modFolderLocator.SelectedPath;
            }
        }
    }
}
