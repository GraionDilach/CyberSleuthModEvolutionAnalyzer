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
            dumpModSourcingButton = new Button();
            validateJogressButton = new Button();
            dumpModSourcingLabel = new Label();
            validateJogressLabel = new Label();
            pipeEvolutionsButton = new Button();
            pipeEvolutionsLabel = new Label();
            validateEvoLabel = new Label();
            validateEvoButton = new Button();
            analyzerLogBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)logContainer).BeginInit();
            logContainer.Panel1.SuspendLayout();
            logContainer.Panel2.SuspendLayout();
            logContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)settingsSplitter).BeginInit();
            settingsSplitter.Panel2.SuspendLayout();
            settingsSplitter.SuspendLayout();
            analyzerLayoutPanel.SuspendLayout();
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
            logContainer.Size = new Size(864, 506);
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
            settingsSplitter.Size = new Size(502, 506);
            settingsSplitter.SplitterDistance = 245;
            settingsSplitter.TabIndex = 0;
            // 
            // analyzerLayoutPanel
            // 
            analyzerLayoutPanel.ColumnCount = 4;
            analyzerLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            analyzerLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            analyzerLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            analyzerLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            analyzerLayoutPanel.Controls.Add(dumpModSourcingButton, 3, 1);
            analyzerLayoutPanel.Controls.Add(validateJogressButton, 1, 1);
            analyzerLayoutPanel.Controls.Add(dumpModSourcingLabel, 2, 1);
            analyzerLayoutPanel.Controls.Add(validateJogressLabel, 0, 1);
            analyzerLayoutPanel.Controls.Add(pipeEvolutionsButton, 3, 0);
            analyzerLayoutPanel.Controls.Add(pipeEvolutionsLabel, 2, 0);
            analyzerLayoutPanel.Controls.Add(validateEvoLabel, 0, 0);
            analyzerLayoutPanel.Controls.Add(validateEvoButton, 1, 0);
            analyzerLayoutPanel.Dock = DockStyle.Fill;
            analyzerLayoutPanel.Location = new Point(0, 0);
            analyzerLayoutPanel.Name = "analyzerLayoutPanel";
            analyzerLayoutPanel.RowCount = 5;
            analyzerLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            analyzerLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            analyzerLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            analyzerLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            analyzerLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            analyzerLayoutPanel.Size = new Size(502, 257);
            analyzerLayoutPanel.TabIndex = 0;
            // 
            // dumpModSourcingButton
            // 
            dumpModSourcingButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dumpModSourcingButton.Location = new Point(453, 54);
            dumpModSourcingButton.Name = "dumpModSourcingButton";
            dumpModSourcingButton.Size = new Size(46, 45);
            dumpModSourcingButton.TabIndex = 7;
            dumpModSourcingButton.Text = "Run!";
            dumpModSourcingButton.UseVisualStyleBackColor = true;
            dumpModSourcingButton.Click += dumpModSourcingButton_Click;
            // 
            // validateJogressButton
            // 
            validateJogressButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            validateJogressButton.Location = new Point(203, 54);
            validateJogressButton.Name = "validateJogressButton";
            validateJogressButton.Size = new Size(44, 45);
            validateJogressButton.TabIndex = 6;
            validateJogressButton.Text = "Run!";
            validateJogressButton.UseVisualStyleBackColor = true;
            validateJogressButton.Click += validateJogressButton_Click;
            // 
            // dumpModSourcingLabel
            // 
            dumpModSourcingLabel.Dock = DockStyle.Fill;
            dumpModSourcingLabel.Location = new Point(253, 51);
            dumpModSourcingLabel.Name = "dumpModSourcingLabel";
            dumpModSourcingLabel.Size = new Size(194, 51);
            dumpModSourcingLabel.TabIndex = 5;
            dumpModSourcingLabel.Text = "Dump origin data of the loaded Digimon";
            dumpModSourcingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // validateJogressLabel
            // 
            validateJogressLabel.Dock = DockStyle.Fill;
            validateJogressLabel.Location = new Point(3, 51);
            validateJogressLabel.Name = "validateJogressLabel";
            validateJogressLabel.Size = new Size(194, 51);
            validateJogressLabel.TabIndex = 4;
            validateJogressLabel.Text = "Check if DNA (Jogress) Evolutions refers all source mons and them only";
            validateJogressLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pipeEvolutionsButton
            // 
            pipeEvolutionsButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pipeEvolutionsButton.Location = new Point(453, 3);
            pipeEvolutionsButton.Name = "pipeEvolutionsButton";
            pipeEvolutionsButton.Size = new Size(46, 45);
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
            pipeEvolutionsLabel.Size = new Size(194, 51);
            pipeEvolutionsLabel.TabIndex = 2;
            pipeEvolutionsLabel.Text = "Collect Pipe Digimons (only have access to a single digimon in both evolution directions)";
            pipeEvolutionsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // validateEvoLabel
            // 
            validateEvoLabel.Dock = DockStyle.Fill;
            validateEvoLabel.Location = new Point(3, 0);
            validateEvoLabel.Name = "validateEvoLabel";
            validateEvoLabel.Size = new Size(194, 51);
            validateEvoLabel.TabIndex = 0;
            validateEvoLabel.Text = "Collect Digimons with more than 6 evolution options";
            validateEvoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // validateEvoButton
            // 
            validateEvoButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            validateEvoButton.Location = new Point(203, 3);
            validateEvoButton.Name = "validateEvoButton";
            validateEvoButton.Size = new Size(44, 45);
            validateEvoButton.TabIndex = 1;
            validateEvoButton.Text = "Run!";
            validateEvoButton.UseVisualStyleBackColor = true;
            validateEvoButton.Click += validateEvoButton_Click;
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
            analyzerLogBox.Size = new Size(358, 506);
            analyzerLogBox.TabIndex = 0;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 506);
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
    }
}