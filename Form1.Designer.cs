namespace Cyber_Sleuth_Mod_Evolution_Analyzer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            folderRoot = new SplitContainer();
            modGenerator = new Button();
            modsLocationBrowser = new Button();
            modsLocationLabel = new Label();
            modsLocation = new TextBox();
            rootLogging = new SplitContainer();
            modData = new SplitContainer();
            modList = new SplitContainer();
            modListLabel = new Label();
            splitContainer1 = new SplitContainer();
            modListBox = new CheckedListBox();
            modLoaderButton = new Button();
            logBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)folderRoot).BeginInit();
            folderRoot.Panel1.SuspendLayout();
            folderRoot.Panel2.SuspendLayout();
            folderRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rootLogging).BeginInit();
            rootLogging.Panel1.SuspendLayout();
            rootLogging.Panel2.SuspendLayout();
            rootLogging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)modData).BeginInit();
            modData.Panel1.SuspendLayout();
            modData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)modList).BeginInit();
            modList.Panel1.SuspendLayout();
            modList.Panel2.SuspendLayout();
            modList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // folderRoot
            // 
            folderRoot.Dock = DockStyle.Fill;
            folderRoot.FixedPanel = FixedPanel.Panel1;
            folderRoot.Location = new Point(0, 0);
            folderRoot.Name = "folderRoot";
            folderRoot.Orientation = Orientation.Horizontal;
            // 
            // folderRoot.Panel1
            // 
            folderRoot.Panel1.Controls.Add(modGenerator);
            folderRoot.Panel1.Controls.Add(modsLocationBrowser);
            folderRoot.Panel1.Controls.Add(modsLocationLabel);
            folderRoot.Panel1.Controls.Add(modsLocation);
            // 
            // folderRoot.Panel2
            // 
            folderRoot.Panel2.Controls.Add(rootLogging);
            folderRoot.Size = new Size(800, 450);
            folderRoot.SplitterDistance = 46;
            folderRoot.TabIndex = 0;
            // 
            // modGenerator
            // 
            modGenerator.Location = new Point(567, 20);
            modGenerator.Name = "modGenerator";
            modGenerator.Size = new Size(117, 23);
            modGenerator.TabIndex = 3;
            modGenerator.Text = "Generate Mod...";
            modGenerator.UseVisualStyleBackColor = true;
            // 
            // modsLocationBrowser
            // 
            modsLocationBrowser.Location = new Point(486, 20);
            modsLocationBrowser.Name = "modsLocationBrowser";
            modsLocationBrowser.Size = new Size(75, 23);
            modsLocationBrowser.TabIndex = 2;
            modsLocationBrowser.Text = "Browse...";
            modsLocationBrowser.UseVisualStyleBackColor = true;
            // 
            // modsLocationLabel
            // 
            modsLocationLabel.AutoSize = true;
            modsLocationLabel.Location = new Point(3, 3);
            modsLocationLabel.Name = "modsLocationLabel";
            modsLocationLabel.Size = new Size(295, 15);
            modsLocationLabel.TabIndex = 1;
            modsLocationLabel.Text = "Location of SimpleDSCSModManager mods subfolder:";
            // 
            // modsLocation
            // 
            modsLocation.Location = new Point(3, 21);
            modsLocation.Name = "modsLocation";
            modsLocation.Size = new Size(477, 23);
            modsLocation.TabIndex = 0;
            // 
            // rootLogging
            // 
            rootLogging.Dock = DockStyle.Fill;
            rootLogging.FixedPanel = FixedPanel.Panel2;
            rootLogging.Location = new Point(0, 0);
            rootLogging.Name = "rootLogging";
            rootLogging.Orientation = Orientation.Horizontal;
            // 
            // rootLogging.Panel1
            // 
            rootLogging.Panel1.Controls.Add(modData);
            // 
            // rootLogging.Panel2
            // 
            rootLogging.Panel2.Controls.Add(logBox);
            rootLogging.Size = new Size(800, 400);
            rootLogging.SplitterDistance = 270;
            rootLogging.TabIndex = 0;
            // 
            // modData
            // 
            modData.Dock = DockStyle.Fill;
            modData.Location = new Point(0, 0);
            modData.Name = "modData";
            // 
            // modData.Panel1
            // 
            modData.Panel1.Controls.Add(modList);
            modData.Size = new Size(800, 270);
            modData.SplitterDistance = 159;
            modData.TabIndex = 0;
            // 
            // modList
            // 
            modList.Dock = DockStyle.Fill;
            modList.FixedPanel = FixedPanel.Panel1;
            modList.Location = new Point(0, 0);
            modList.Name = "modList";
            modList.Orientation = Orientation.Horizontal;
            // 
            // modList.Panel1
            // 
            modList.Panel1.Controls.Add(modListLabel);
            // 
            // modList.Panel2
            // 
            modList.Panel2.Controls.Add(splitContainer1);
            modList.Size = new Size(159, 270);
            modList.SplitterDistance = 25;
            modList.TabIndex = 0;
            // 
            // modListLabel
            // 
            modListLabel.AutoSize = true;
            modListLabel.Dock = DockStyle.Bottom;
            modListLabel.Location = new Point(0, 10);
            modListLabel.Name = "modListLabel";
            modListLabel.Size = new Size(90, 15);
            modListLabel.TabIndex = 0;
            modListLabel.Text = "Detected mods:";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(modListBox);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(modLoaderButton);
            splitContainer1.Size = new Size(159, 241);
            splitContainer1.SplitterDistance = 210;
            splitContainer1.TabIndex = 0;
            // 
            // modListBox
            // 
            modListBox.Dock = DockStyle.Fill;
            modListBox.FormattingEnabled = true;
            modListBox.Location = new Point(0, 0);
            modListBox.Name = "modListBox";
            modListBox.Size = new Size(159, 210);
            modListBox.TabIndex = 0;
            // 
            // modLoaderButton
            // 
            modLoaderButton.Dock = DockStyle.Fill;
            modLoaderButton.Location = new Point(0, 0);
            modLoaderButton.Name = "modLoaderButton";
            modLoaderButton.Size = new Size(159, 27);
            modLoaderButton.TabIndex = 0;
            modLoaderButton.Text = "Reload Mods";
            modLoaderButton.UseVisualStyleBackColor = true;
            // 
            // logBox
            // 
            logBox.BackColor = SystemColors.Window;
            logBox.Dock = DockStyle.Fill;
            logBox.Location = new Point(0, 0);
            logBox.Multiline = true;
            logBox.Name = "logBox";
            logBox.ReadOnly = true;
            logBox.Size = new Size(800, 126);
            logBox.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(folderRoot);
            Name = "Form1";
            Text = "Cyber Sleuth Mod Evolution Analyzer";
            folderRoot.Panel1.ResumeLayout(false);
            folderRoot.Panel1.PerformLayout();
            folderRoot.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)folderRoot).EndInit();
            folderRoot.ResumeLayout(false);
            rootLogging.Panel1.ResumeLayout(false);
            rootLogging.Panel2.ResumeLayout(false);
            rootLogging.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rootLogging).EndInit();
            rootLogging.ResumeLayout(false);
            modData.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)modData).EndInit();
            modData.ResumeLayout(false);
            modList.Panel1.ResumeLayout(false);
            modList.Panel1.PerformLayout();
            modList.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)modList).EndInit();
            modList.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer folderRoot;
        private SplitContainer rootLogging;
        private TextBox logBox;
        private SplitContainer modData;
        private SplitContainer modList;
        private Label modListLabel;
        private Label modsLocationLabel;
        private TextBox modsLocation;
        private Button modGenerator;
        private Button modsLocationBrowser;
        private SplitContainer splitContainer1;
        private CheckedListBox modListBox;
        private Button modLoaderButton;
    }
}
