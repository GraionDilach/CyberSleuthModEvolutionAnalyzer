using System.ComponentModel;

namespace Cyber_Sleuth_Mod_Evolution_Analyzer
{
    public partial class DigimonEvoControlOption : UserControl
    {
        List<Digimon> knownmons = [];

        Tuple<int, string> evoCondition = new(0,"");

        public DigimonEvoControlOption()
        {
            InitializeComponent();
        }

        void UpdateEvoControlState()
        {
            modeBox.SelectedIndex = evoCondition.Item1;
            switch (modeBox.SelectedIndex)
            {
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 0:
                case 13:
                    valueDropBox.Visible = false;
                    valueTextBox.Visible = false;
                    break;
                // load simple values into textbox as default
                // that's being 1,2,3,4,5,6,7,8,9
                default:
                    valueDropBox.Visible = false;
                    valueTextBox.Text = evoCondition.Item2;
                    valueTextBox.Visible = true;
                    break;
            }
        }

        private void valueBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SelectedEvoOptionChanged?.Invoke(this, e);
        }

        private void modeBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            evoCondition = new(modeBox.SelectedIndex, evoCondition.Item2);
            UpdateEvoControlState();
            if (valueTextBox.Visible)
            {
                valueTextBox.Text = 0.ToString();
            }
            SelectedEvoOptionChanged?.Invoke(this, e);
        }

        private void valueTextBox_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(valueTextBox.Text, out var _))
            {
                valueTextBox.Text = 0.ToString();
            }
            evoCondition = new(modeBox.SelectedIndex, valueTextBox.Text);
            UpdateEvoControlState();
            SelectedEvoOptionChanged?.Invoke(this, e);
        }

        [Browsable(true)]
        public Tuple<int, string>? EvoCondition
        {
            get
            {
                return evoCondition;
            }
            set
            {
                if (value != null)
                {
                    evoCondition = value;
                }
                else
                {
                    evoCondition = new(0, "");
                }
                UpdateEvoControlState();
            }
        }

        [Browsable(true)]
        public event EventHandler? SelectedEvoOptionChanged;

        /*
        [Browsable(true)]
        public Digimon? SelectedDigimon
        {
            get
            {
                if (valueDropBox.SelectedIndex > -1)
                {
                    return options[valueDropBox.SelectedIndex];
                }

                return null;
            }
            set
            {
                if (value != null && options.Contains(value))
                {
                    valueDropBox.DataSource = options;
                    valueDropBox.SelectedIndex = options.IndexOf(value);
                    valueDropBox.Visible = true;
                    clearButton.Visible = true;
                    enableButton.Visible = false;
                }
                else
                {
                    valueDropBox.DataSource = null;
                    valueDropBox.SelectedIndex = -1;
                    valueDropBox.Visible = false;
                    clearButton.Visible = false;
                    enableButton.Visible = true;
                }
            }
        }
        */
    }
}
