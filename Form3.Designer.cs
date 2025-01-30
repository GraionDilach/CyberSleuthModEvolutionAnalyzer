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
            analyzerLog = new TextBox();
            settingsSplitter = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)logContainer).BeginInit();
            logContainer.Panel1.SuspendLayout();
            logContainer.Panel2.SuspendLayout();
            logContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)settingsSplitter).BeginInit();
            settingsSplitter.Panel2.SuspendLayout();
            settingsSplitter.SuspendLayout();
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
            logContainer.Panel2.Controls.Add(analyzerLog);
            logContainer.Size = new Size(800, 450);
            logContainer.SplitterDistance = 465;
            logContainer.TabIndex = 0;
            // 
            // analyzerLog
            // 
            analyzerLog.BackColor = SystemColors.Window;
            analyzerLog.Dock = DockStyle.Fill;
            analyzerLog.Location = new Point(0, 0);
            analyzerLog.Multiline = true;
            analyzerLog.Name = "analyzerLog";
            analyzerLog.ReadOnly = true;
            analyzerLog.Size = new Size(331, 450);
            analyzerLog.TabIndex = 0;
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
            settingsSplitter.Panel2.Controls.Add(tableLayoutPanel1);
            settingsSplitter.Size = new Size(465, 450);
            settingsSplitter.SplitterDistance = 219;
            settingsSplitter.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(465, 227);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logContainer);
            Name = "Form3";
            Text = "Cyber Sleiuth Mod Evolution Analyzer Settings/Analyzers";
            logContainer.Panel1.ResumeLayout(false);
            logContainer.Panel2.ResumeLayout(false);
            logContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logContainer).EndInit();
            logContainer.ResumeLayout(false);
            settingsSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)settingsSplitter).EndInit();
            settingsSplitter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer logContainer;
        private SplitContainer settingsSplitter;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox analyzerLog;
    }
}