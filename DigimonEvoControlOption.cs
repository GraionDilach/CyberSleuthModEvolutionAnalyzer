using System.ComponentModel;

namespace Cyber_Sleuth_Mod_Evolution_Analyzer
{
    public partial class DigimonEvoControlOption : UserControl
    {
        List<Digimon> knownMons = [];
        List<DigimonItem> knownItems = [];

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
                // Flag/Story Cleared
                /*
                case 10:
                    valueTextBox.Visible = false;
                    break;
                */
                // Item
                case 11:
                    valueDropBox.DataSource = knownItems;
                    valueDropBox.Visible = true;
                    if (!String.IsNullOrEmpty(evoCondition.Item2))
                    {
                        var selectedItem = knownItems.SingleOrDefault(x => String.Equals(x.ID, evoCondition.Item2));
                        if (selectedItem != null)
                        {
                            valueDropBox.SelectedIndex = valueDropBox.Items.IndexOf(selectedItem);
                        }
                        else
                        {
                            valueDropBox.SelectedIndex = -1;
                        }
                    }
                    valueTextBox.Visible = false;
                    break;
                // DNA
                case 12:
                    valueDropBox.DataSource = knownMons;
                    valueDropBox.Visible = true;
                    if (!String.IsNullOrEmpty(evoCondition.Item2))
                    {
                        var selectedMon = knownMons.SingleOrDefault(x => String.Equals(x.ID, evoCondition.Item2));
                        if (selectedMon != null)
                        {
                            valueDropBox.SelectedIndex = valueDropBox.Items.IndexOf(selectedMon);
                        }
                        else
                        {
                            valueDropBox.SelectedIndex = -1;
                        }
                    }
                    valueTextBox.Visible = false;
                    break;
                // DLC
                /*
                case 14:
                    valueTextBox.Visible = false;
                    break;
                // Flag/Quest complete (using condUnk)
                case 15:
                    valueTextBox.Visible = false;
                    break;
                */
                case 0:
                case 10: //?! - can't find an example
                case 13:
                    valueDropBox.DataSource = null;
                    valueDropBox.Visible = false;
                    valueTextBox.Visible = false;
                    break;
                // load simple values into textbox as default
                // that's being 1,2,3,4,5,6,7,8,9
                default:
                    valueDropBox.DataSource = null;
                    valueDropBox.Visible = false;
                    valueTextBox.Text = evoCondition.Item2;
                    valueTextBox.Visible = true;
                    break;
            }
        }

        private void valueBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (valueDropBox.Visible)
            {
                switch (modeBox.SelectedIndex)
                {
                    case 11:
                        evoCondition = new(modeBox.SelectedIndex, knownItems[valueDropBox.SelectedIndex].ID);
                        UpdateEvoControlState();
                        SelectedEvoOptionChanged?.Invoke(this, e);
                        break;
                    case 12:
                        evoCondition = new(modeBox.SelectedIndex, knownMons[valueDropBox.SelectedIndex].ID);
                        UpdateEvoControlState();
                        SelectedEvoOptionChanged?.Invoke(this, e);
                        break;
                    default:
                        break;
                }
            }
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

        public void UpdateConditionOption(List<Digimon> knownmons, List<DigimonItem> knownitems)
        {
            knownMons = knownmons;
            knownItems = knownitems;
        }
    }
}
