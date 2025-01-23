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
    public partial class DigimonEvolutionOption : UserControl
    {
        List<Digimon> options = [];

        public DigimonEvolutionOption()
        {
            InitializeComponent();
            valueBox.DataSource = options;
            valueBox.SelectedIndex = -1;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            valueBox.SelectedIndex = -1;
            valueBox.Visible = false;
            clearButton.Visible = false;
            enableButton.Visible = true;
        }

        private void enableButton_Click(object sender, EventArgs e)
        {
            valueBox.SelectedIndex = 0;
            valueBox.Visible = true;
            clearButton.Visible = true;
            enableButton.Visible = false;
        }

        [Browsable(true)]
        public List<Digimon> Options
        {
            get => options;
            set
            {
                options = value;
                valueBox.DataSource = options;
            }
        }

        private Digimon selectedDigimon()
        {
            var digimon = new Digimon();
            if (valueBox.SelectedIndex > -1)
            {
                digimon = options[valueBox.SelectedIndex];
            }
            return digimon;
        }

        [Browsable(true)]
        public event EventHandler? SelectedDigimonChanged
        {
            add => valueBox.SelectedIndexChanged += value;
            remove => valueBox.SelectedIndexChanged -= value;
        }

        [Browsable(true)]
        public Digimon SelectedDigimon
        {
            get => selectedDigimon();
            set
            {
                if (options.Contains(value))
                {
                    valueBox.SelectedIndex = options.IndexOf(value);
                    valueBox.Visible = true;
                    clearButton.Visible = true;
                    enableButton.Visible = false;
                }
                else
                {
                    valueBox.SelectedIndex = -1;
                    valueBox.Visible = false;
                    clearButton.Visible = false;
                    enableButton.Visible = true;
                }
            }
        }
    }
}
