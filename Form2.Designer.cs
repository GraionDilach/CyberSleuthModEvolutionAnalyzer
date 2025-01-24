namespace Cyber_Sleuth_Mod_Evolution_Analyzer
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            okButton = new Button();
            cancelButton = new Button();
            folderNameLabel = new Label();
            modName = new TextBox();
            modNameLabel = new Label();
            folderName = new ComboBox();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(12, 100);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 0;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(247, 100);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // folderNameLabel
            // 
            folderNameLabel.AutoSize = true;
            folderNameLabel.Location = new Point(12, 9);
            folderNameLabel.Name = "folderNameLabel";
            folderNameLabel.Size = new Size(76, 15);
            folderNameLabel.TabIndex = 3;
            folderNameLabel.Text = "Folder name:";
            // 
            // modName
            // 
            modName.Location = new Point(12, 71);
            modName.Name = "modName";
            modName.Size = new Size(310, 23);
            modName.TabIndex = 4;
            // 
            // modNameLabel
            // 
            modNameLabel.AutoSize = true;
            modNameLabel.Location = new Point(12, 53);
            modNameLabel.Name = "modNameLabel";
            modNameLabel.Size = new Size(68, 15);
            modNameLabel.TabIndex = 5;
            modNameLabel.Text = "Mod name:";
            // 
            // folderName
            // 
            folderName.FormattingEnabled = true;
            folderName.Location = new Point(12, 27);
            folderName.Name = "folderName";
            folderName.Size = new Size(310, 23);
            folderName.TabIndex = 6;
            folderName.TextChanged += folderName_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(334, 134);
            Controls.Add(folderName);
            Controls.Add(modNameLabel);
            Controls.Add(modName);
            Controls.Add(folderNameLabel);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Name = "Form2";
            Text = "CSMEA - Save Generated Mod";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okButton;
        private Button cancelButton;
        private Label folderNameLabel;
        private TextBox modName;
        private Label modNameLabel;
        private ComboBox folderName;
    }
}