namespace Cyber_Sleuth_Mod_Evolution_Analyzer
{
    partial class DigimonEvoControlOption
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            valueDropBox = new ComboBox();
            valueTextBox = new TextBox();
            modeBox = new ComboBox();
            SuspendLayout();
            // 
            // valueDropBox
            // 
            valueDropBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            valueDropBox.FormattingEnabled = true;
            valueDropBox.Location = new Point(58, 0);
            valueDropBox.Name = "valueDropBox";
            valueDropBox.Size = new Size(101, 23);
            valueDropBox.TabIndex = 0;
            valueDropBox.SelectionChangeCommitted += valueBox_SelectionChangeCommitted;
            // 
            // valueTextBox
            // 
            valueTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            valueTextBox.Location = new Point(58, 0);
            valueTextBox.Name = "valueTextBox";
            valueTextBox.Size = new Size(101, 23);
            valueTextBox.TabIndex = 0;
            valueTextBox.Leave += valueTextBox_Leave;
            // 
            // modeBox
            // 
            modeBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            modeBox.FormattingEnabled = true;
            modeBox.Items.AddRange(new object[] { "---", "Lv.", "M.HP", "M.SP", "ATK", "DEF", "INT", "SPD", "ABI", "CAM", "Flag", "Item", "DNA", "Mode", "DLC", "Cond." });
            modeBox.Location = new Point(3, 0);
            modeBox.Name = "modeBox";
            modeBox.Size = new Size(49, 23);
            modeBox.TabIndex = 0;
            modeBox.SelectionChangeCommitted += modeBox_SelectionChangeCommitted;
            // 
            // DigimonEvoControlOption
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(modeBox);
            Controls.Add(valueTextBox);
            Controls.Add(valueDropBox);
            Name = "DigimonEvoControlOption";
            Size = new Size(162, 26);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox valueDropBox;
        private TextBox valueTextBox;
        private ComboBox modeBox;
    }
}
