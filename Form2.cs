using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cyber_Sleuth_Mod_Evolution_Analyzer
{
    public partial class Form2 : Form
    {
        readonly List<DSCSMod> dscsMods;
        public Form2(List<DSCSMod> mods)
        {
            InitializeComponent();
            dscsMods = mods;
        }

        private void folderName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
