namespace Cyber_Sleuth_Mod_Evolution_Analyzer
{
    partial class Form3
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
            logContainer = new SplitContainer();
            settingsSplitter = new SplitContainer();
            analyzerLayoutPanel = new TableLayoutPanel();
            massEvoDeleterButton = new Button();
            dumpModSourcingButton = new Button();
            validateJogressButton = new Button();
            dumpModSourcingLabel = new Label();
            validateJogressLabel = new Label();
            pipeEvolutionsButton = new Button();
            pipeEvolutionsLabel = new Label();
            validateEvoLabel = new Label();
            validateEvoButton = new Button();
            massEvoDeleterContainer = new SplitContainer();
            massEvoDeleterLabel = new Label();
            massEvoDeleterComboBox = new ComboBox();
            analyzerLogBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)logContainer).BeginInit();
            logContainer.Panel1.SuspendLayout();
            logContainer.Panel2.SuspendLayout();
            logContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)settingsSplitter).BeginInit();
            settingsSplitter.Panel2.SuspendLayout();
            settingsSplitter.SuspendLayout();
            analyzerLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)massEvoDeleterContainer).BeginInit();
            massEvoDeleterContainer.Panel1.SuspendLayout();
            massEvoDeleterContainer.Panel2.SuspendLayout();
            massEvoDeleterContainer.SuspendLayout();
            SuspendLayout();
            // 
            // logContainer
            // 
            logContainer.Dock = DockStyle.Fill;
            logContainer.Location = new Point(0, 0);
            logContainer.Name = "logContainer";
            // 
            // logContainer.Panel1
            // 
            logContainer.Panel1.Controls.Add(settingsSplitter);
            // 
            // logContainer.Panel2
            // 
            logContainer.Panel2.Controls.Add(analyzerLogBox);
            logContainer.Size = new Size(864, 533);
            logContainer.SplitterDistance = 502;
            logContainer.TabIndex = 0;
            // 
            // settingsSplitter
            // 
            settingsSplitter.Dock = DockStyle.Fill;
            settingsSplitter.Location = new Point(0, 0);
            settingsSplitter.Name = "settingsSplitter";
            settingsSplitter.Orientation = Orientation.Horizontal;
            // 
            // settingsSplitter.Panel2
            // 
            settingsSplitter.Panel2.Controls.Add(analyzerLayoutPanel);
            settingsSplitter.Size = new Size(502, 533);
            settingsSplitter.SplitterDistance = 258;
            settingsSplitter.TabIndex = 0;
            // 
            // analyzerLayoutPanel
            // 
            analyzerLayoutPanel.ColumnCount = 4;
            analyzerLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            analyzerLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            analyzerLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            analyzerLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            analyzerLayoutPanel.Controls.Add(massEvoDeleterButton, 1, 2);
            analyzerLayoutPanel.Controls.Add(dumpModSourcingButton, 3, 1);
            analyzerLayoutPanel.Controls.Add(validateJogressButton, 1, 1);
            analyzerLayoutPanel.Controls.Add(dumpModSourcingLabel, 2, 1);
            analyzerLayoutPanel.Controls.Add(validateJogressLabel, 0, 1);
            analyzerLayoutPanel.Controls.Add(pipeEvolutionsButton, 3, 0);
            analyzerLayoutPanel.Controls.Add(pipeEvolutionsLabel, 2, 0);
            analyzerLayoutPanel.Controls.Add(validateEvoLabel, 0, 0);
            analyzerLayoutPanel.Controls.Add(validateEvoButton, 1, 0);
            analyzerLayoutPanel.Controls.Add(massEvoDeleterContainer, 0, 2);
            analyzerLayoutPanel.Dock = DockStyle.Fill;
            analyzerLayoutPanel.Location = new Point(0, 0);
            analyzerLayoutPanel.Name = "analyzerLayoutPanel";
            analyzerLayoutPanel.RowCount = 4;
            analyzerLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            analyzerLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            analyzerLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            analyzerLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            analyzerLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            analyzerLayoutPanel.Size = new Size(502, 271);
            analyzerLayoutPanel.TabIndex = 0;
            // 
            // massEvoDeleterButton
            // 
            massEvoDeleterButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            massEvoDeleterButton.Location = new Point(203, 137);
            massEvoDeleterButton.Name = "massEvoDeleterButton";
            massEvoDeleterButton.Size = new Size(44, 61);
            massEvoDeleterButton.TabIndex = 9;
            massEvoDeleterButton.Text = "Run!";
            massEvoDeleterButton.UseVisualStyleBackColor = true;
            massEvoDeleterButton.Click += massEvoDeleterButton_Click;
            // 
            // dumpModSourcingButton
            // 
            dumpModSourcingButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dumpModSourcingButton.Location = new Point(453, 70);
            dumpModSourcingButton.Name = "dumpModSourcingButton";
            dumpModSourcingButton.Size = new Size(46, 61);
            dumpModSourcingButton.TabIndex = 7;
            dumpModSourcingButton.Text = "Run!";
            dumpModSourcingButton.UseVisualStyleBackColor = true;
            dumpModSourcingButton.Click += dumpModSourcingButton_Click;
            // 
            // validateJogressButton
            // 
            validateJogressButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            validateJogressButton.Location = new Point(203, 70);
            validateJogressButton.Name = "validateJogressButton";
            validateJogressButton.Size = new Size(44, 61);
            validateJogressButton.TabIndex = 6;
            validateJogressButton.Text = "Run!";
            validateJogressButton.UseVisualStyleBackColor = true;
            validateJogressButton.Click += validateJogressButton_Click;
            // 
            // dumpModSourcingLabel
            // 
            dumpModSourcingLabel.Dock = DockStyle.Fill;
            dumpModSourcingLabel.Location = new Point(253, 67);
            dumpModSourcingLabel.Name = "dumpModSourcingLabel";
            dumpModSourcingLabel.Size = new Size(194, 67);
            dumpModSourcingLabel.TabIndex = 5;
            dumpModSourcingLabel.Text = "Dump origin data of the loaded Digimon";
            dumpModSourcingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // validateJogressLabel
            // 
            validateJogressLabel.Dock = DockStyle.Fill;
            validateJogressLabel.Location = new Point(3, 67);
            validateJogressLabel.Name = "validateJogressLabel";
            validateJogressLabel.Size = new Size(194, 67);
            validateJogressLabel.TabIndex = 4;
            validateJogressLabel.Text = "Check if DNA (Jogress) Evolutions refers all source mons and them only";
            validateJogressLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pipeEvolutionsButton
            // 
            pipeEvolutionsButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pipeEvolutionsButton.Location = new Point(453, 3);
            pipeEvolutionsButton.Name = "pipeEvolutionsButton";
            pipeEvolutionsButton.Size = new Size(46, 61);
            pipeEvolutionsButton.TabIndex = 3;
            pipeEvolutionsButton.Text = "Run!";
            pipeEvolutionsButton.UseVisualStyleBackColor = true;
            pipeEvolutionsButton.Click += pipeEvolutionsButton_Click;
            // 
            // pipeEvolutionsLabel
            // 
            pipeEvolutionsLabel.Dock = DockStyle.Fill;
            pipeEvolutionsLabel.Location = new Point(253, 0);
            pipeEvolutionsLabel.Name = "pipeEvolutionsLabel";
            pipeEvolutionsLabel.Size = new Size(194, 67);
            pipeEvolutionsLabel.TabIndex = 2;
            pipeEvolutionsLabel.Text = "Collect Pipe Digimons (only have access to a single digimon in both evolution directions)";
            pipeEvolutionsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // validateEvoLabel
            // 
            validateEvoLabel.Dock = DockStyle.Fill;
            validateEvoLabel.Location = new Point(3, 0);
            validateEvoLabel.Name = "validateEvoLabel";
            validateEvoLabel.Size = new Size(194, 67);
            validateEvoLabel.TabIndex = 0;
            validateEvoLabel.Text = "Collect Digimons with more than 6 evolution options";
            validateEvoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // validateEvoButton
            // 
            validateEvoButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            validateEvoButton.Location = new Point(203, 3);
            validateEvoButton.Name = "validateEvoButton";
            validateEvoButton.Size = new Size(44, 61);
            validateEvoButton.TabIndex = 1;
            validateEvoButton.Text = "Run!";
            validateEvoButton.UseVisualStyleBackColor = true;
            validateEvoButton.Click += validateEvoButton_Click;
            // 
            // massEvoDeleterContainer
            // 
            massEvoDeleterContainer.Dock = DockStyle.Fill;
            massEvoDeleterContainer.Location = new Point(3, 137);
            massEvoDeleterContainer.Name = "massEvoDeleterContainer";
            massEvoDeleterContainer.Orientation = Orientation.Horizontal;
            // 
            // massEvoDeleterContainer.Panel1
            // 
            massEvoDeleterContainer.Panel1.Controls.Add(massEvoDeleterLabel);
            // 
            // massEvoDeleterContainer.Panel2
            // 
            massEvoDeleterContainer.Panel2.Controls.Add(massEvoDeleterComboBox);
            massEvoDeleterContainer.Size = new Size(194, 61);
            massEvoDeleterContainer.SplitterDistance = 30;
            massEvoDeleterContainer.TabIndex = 8;
            // 
            // massEvoDeleterLabel
            // 
            massEvoDeleterLabel.Dock = DockStyle.Fill;
            massEvoDeleterLabel.Location = new Point(0, 0);
            massEvoDeleterLabel.Name = "massEvoDeleterLabel";
            massEvoDeleterLabel.Size = new Size(194, 30);
            massEvoDeleterLabel.TabIndex = 5;
            massEvoDeleterLabel.Text = "Mass-delete this kind of evolution requirement on all Digimons";
            massEvoDeleterLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // massEvoDeleterComboBox
            // 
            massEvoDeleterComboBox.Dock = DockStyle.Fill;
            massEvoDeleterComboBox.FormattingEnabled = true;
            massEvoDeleterComboBox.Location = new Point(0, 0);
            massEvoDeleterComboBox.Name = "massEvoDeleterComboBox";
            massEvoDeleterComboBox.Size = new Size(194, 23);
            massEvoDeleterComboBox.TabIndex = 0;
            // 
            // analyzerLogBox
            // 
            analyzerLogBox.BackColor = SystemColors.Window;
            analyzerLogBox.Dock = DockStyle.Fill;
            analyzerLogBox.Location = new Point(0, 0);
            analyzerLogBox.Multiline = true;
            analyzerLogBox.Name = "analyzerLogBox";
            analyzerLogBox.ReadOnly = true;
            analyzerLogBox.ScrollBars = ScrollBars.Vertical;
            analyzerLogBox.Size = new Size(358, 533);
            analyzerLogBox.TabIndex = 0;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 533);
            Controls.Add(logContainer);
            MinimizeBox = false;
            Name = "Form3";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Cyber Sleuth Mod Evolution Analyzer - Settings & Analyzers";
            logContainer.Panel1.ResumeLayout(false);
            logContainer.Panel2.ResumeLayout(false);
            logContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logContainer).EndInit();
            logContainer.ResumeLayout(false);
            settingsSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)settingsSplitter).EndInit();
            settingsSplitter.ResumeLayout(false);
            analyzerLayoutPanel.ResumeLayout(false);
            massEvoDeleterContainer.Panel1.ResumeLayout(false);
            massEvoDeleterContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)massEvoDeleterContainer).EndInit();
            massEvoDeleterContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer logContainer;
        private SplitContainer settingsSplitter;
        private TableLayoutPanel analyzerLayoutPanel;
        private TextBox analyzerLogBox;
        private Label validateEvoLabel;
        private Button validateEvoButton;
        private Button pipeEvolutionsButton;
        private Label pipeEvolutionsLabel;
        private Label validateJogressLabel;
        private Button dumpModSourcingButton;
        private Button validateJogressButton;
        private Label dumpModSourcingLabel;
        private SplitContainer massEvoDeleterContainer;
        private Label massEvoDeleterLabel;
        private ComboBox massEvoDeleterComboBox;
        private Button massEvoDeleterButton;
    }
}