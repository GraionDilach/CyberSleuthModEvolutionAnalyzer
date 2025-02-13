﻿namespace Cyber_Sleuth_Mod_Evolution_Analyzer
{
    public partial class Form2 : Form
    {
        readonly List<DSCSMod> dscsMods;
        string[] modFolders;
        public Form2(List<DSCSMod> mods)
        {
            InitializeComponent();
            dscsMods = mods.Where(x => x.Generated).ToList();
            var empty = new string[] { "" };
            modFolders = empty.Concat(dscsMods.Select(x => x.Folder)).ToArray();
            folderName.Items.AddRange(modFolders);
        }

        private void folderName_TextChanged(object sender, EventArgs e)
        {
            if (folderName.SelectedIndex > 0)
            {
                modName.Text = dscsMods[folderName.SelectedIndex - 1].Name;
            }
            else
            {
                modName.Text = folderName.Text;
            }
        }

        private void modName_TextChanged(object sender, EventArgs e)
        {
            folderName.Text = modName.Text.Trim().ToLower();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (folderName.Text.Length > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        public string ModName { get { return modName.Text; } }

        public string ModFolder { get { return folderName.Text; } }

    }
}
