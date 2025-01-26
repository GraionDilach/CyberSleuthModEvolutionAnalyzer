using System.ComponentModel;

namespace Cyber_Sleuth_Mod_Evolution_Analyzer
{
    public partial class DigimonEvolutionOption : UserControl
    {
        List<Digimon> options = [];

        public DigimonEvolutionOption()
        {
            InitializeComponent();
            valueBox.DataSource = new List<Digimon>(options);
            valueBox.SelectedIndex = -1;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            valueBox.DataSource = null;
            valueBox.SelectedIndex = -1;
            valueBox.Visible = false;
            clearButton.Visible = false;
            jumpButton.Visible = false;
            enableButton.Visible = true;
            SelectedDigimonChanged?.Invoke(this, e);
        }

        private void enableButton_Click(object sender, EventArgs e)
        {
            valueBox.DataSource = options;
            valueBox.SelectedIndex = 0;
            valueBox.Visible = true;
            clearButton.Visible = true;
            jumpButton.Visible = true;
            enableButton.Visible = false;
            SelectedDigimonChanged?.Invoke(this, e);
        }

        private void jumpButton_Click(object sender, EventArgs e)
        {
            JumpToSelectedDigimon?.Invoke(this, e);
        }

        private void valueBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SelectedDigimonChanged?.Invoke(this, e);
        }

        [Browsable(true)]
        public List<Digimon> Options
        {
            get => options;
            set
            {
                options = value;
                valueBox.DataSource = new List<Digimon>(options);
            }
        }

        [Browsable(true)]
        public event EventHandler? SelectedDigimonChanged;

        [Browsable(true)]
        public event EventHandler? JumpToSelectedDigimon;

        [Browsable(true)]
        public Digimon? SelectedDigimon
        {
            get
            {
                if (valueBox.SelectedIndex > -1)
                {
                    return options[valueBox.SelectedIndex];
                }

                return null;
            }
            set
            {
                if (value != null && options.Contains(value))
                {
                    valueBox.DataSource = options;
                    valueBox.SelectedIndex = options.IndexOf(value);
                    valueBox.Visible = true;
                    clearButton.Visible = true;
                    jumpButton.Visible = true;
                    enableButton.Visible = false;
                }
                else
                {
                    valueBox.DataSource = null;
                    valueBox.SelectedIndex = -1;
                    valueBox.Visible = false;
                    clearButton.Visible = false;
                    jumpButton.Visible = false;
                    enableButton.Visible = true;
                }
            }
        }
    }
}
