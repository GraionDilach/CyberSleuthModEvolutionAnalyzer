namespace Cyber_Sleuth_Mod_Evolution_Analyzer
{
    partial class DigimonEvolutionOption
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
            valueBox = new ComboBox();
            clearButton = new Button();
            enableButton = new Button();
            jumpButton = new Button();
            SuspendLayout();
            // 
            // valueBox
            // 
            valueBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            valueBox.FormattingEnabled = true;
            valueBox.Location = new Point(0, 0);
            valueBox.Name = "valueBox";
            valueBox.Size = new Size(104, 23);
            valueBox.TabIndex = 0;
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.Right;
            clearButton.Location = new Point(135, 0);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(23, 23);
            clearButton.TabIndex = 1;
            clearButton.Text = "X";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // enableButton
            // 
            enableButton.AutoSize = true;
            enableButton.Dock = DockStyle.Fill;
            enableButton.Location = new Point(0, 0);
            enableButton.Name = "enableButton";
            enableButton.Size = new Size(162, 26);
            enableButton.TabIndex = 2;
            enableButton.Text = "Add...";
            enableButton.UseVisualStyleBackColor = true;
            enableButton.Click += enableButton_Click;
            // 
            // jumpButton
            // 
            jumpButton.Anchor = AnchorStyles.Right;
            jumpButton.Location = new Point(110, 0);
            jumpButton.Name = "jumpButton";
            jumpButton.Size = new Size(19, 23);
            jumpButton.TabIndex = 1;
            jumpButton.Text = ">";
            jumpButton.UseVisualStyleBackColor = true;
            jumpButton.Click += jumpButton_Click;
            // 
            // DigimonEvolutionOption
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(valueBox);
            Controls.Add(clearButton);
            Controls.Add(jumpButton);
            Controls.Add(enableButton);
            Name = "DigimonEvolutionOption";
            Size = new Size(162, 26);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox valueBox;
        private Button clearButton;
        private Button enableButton;
        private Button jumpButton;
    }
}
