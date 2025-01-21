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
            modReloadWrapper = new SplitContainer();
            modListBox = new CheckedListBox();
            modLoaderButton = new Button();
            digimonListWrapper = new SplitContainer();
            digimonList = new TabControl();
            digimonListInTraining1Tab = new TabPage();
            digimonListInTraining2Tab = new TabPage();
            digimonListRookieTab = new TabPage();
            digimonListChampionTab = new TabPage();
            digimonListArmorTab = new TabPage();
            digimonListUltimateTab = new TabPage();
            digimonListMegaTab = new TabPage();
            digimonListUltraTab = new TabPage();
            digimonDataContainer = new SplitContainer();
            digimonName = new Label();
            digimonDataPanel = new TableLayoutPanel();
            logBox = new TextBox();
            modFolderLocator = new FolderBrowserDialog();
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
            modData.Panel2.SuspendLayout();
            modData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)modList).BeginInit();
            modList.Panel1.SuspendLayout();
            modList.Panel2.SuspendLayout();
            modList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)modReloadWrapper).BeginInit();
            modReloadWrapper.Panel1.SuspendLayout();
            modReloadWrapper.Panel2.SuspendLayout();
            modReloadWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)digimonListWrapper).BeginInit();
            digimonListWrapper.Panel1.SuspendLayout();
            digimonListWrapper.Panel2.SuspendLayout();
            digimonListWrapper.SuspendLayout();
            digimonList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)digimonDataContainer).BeginInit();
            digimonDataContainer.Panel1.SuspendLayout();
            digimonDataContainer.Panel2.SuspendLayout();
            digimonDataContainer.SuspendLayout();
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
            folderRoot.Size = new Size(865, 489);
            folderRoot.SplitterDistance = 46;
            folderRoot.TabIndex = 0;
            // 
            // modGenerator
            // 
            modGenerator.Location = new Point(745, 21);
            modGenerator.Name = "modGenerator";
            modGenerator.Size = new Size(117, 23);
            modGenerator.TabIndex = 3;
            modGenerator.Text = "Generate Mod...";
            modGenerator.UseVisualStyleBackColor = true;
            // 
            // modsLocationBrowser
            // 
            modsLocationBrowser.Location = new Point(664, 21);
            modsLocationBrowser.Name = "modsLocationBrowser";
            modsLocationBrowser.Size = new Size(75, 23);
            modsLocationBrowser.TabIndex = 2;
            modsLocationBrowser.Text = "Browse...";
            modsLocationBrowser.UseVisualStyleBackColor = true;
            modsLocationBrowser.Click += modsLocationBrowser_Click;
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
            modsLocation.Size = new Size(655, 23);
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
            rootLogging.Size = new Size(865, 439);
            rootLogging.SplitterDistance = 309;
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
            // 
            // modData.Panel2
            // 
            modData.Panel2.Controls.Add(digimonListWrapper);
            modData.Size = new Size(865, 309);
            modData.SplitterDistance = 136;
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
            modList.Panel2.Controls.Add(modReloadWrapper);
            modList.Size = new Size(136, 309);
            modList.SplitterDistance = 25;
            modList.TabIndex = 0;
            modList.Visible = false;
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
            // modReloadWrapper
            // 
            modReloadWrapper.Dock = DockStyle.Fill;
            modReloadWrapper.FixedPanel = FixedPanel.Panel2;
            modReloadWrapper.Location = new Point(0, 0);
            modReloadWrapper.Name = "modReloadWrapper";
            modReloadWrapper.Orientation = Orientation.Horizontal;
            // 
            // modReloadWrapper.Panel1
            // 
            modReloadWrapper.Panel1.Controls.Add(modListBox);
            // 
            // modReloadWrapper.Panel2
            // 
            modReloadWrapper.Panel2.Controls.Add(modLoaderButton);
            modReloadWrapper.Size = new Size(136, 280);
            modReloadWrapper.SplitterDistance = 251;
            modReloadWrapper.TabIndex = 0;
            // 
            // modListBox
            // 
            modListBox.AllowDrop = true;
            modListBox.CheckOnClick = true;
            modListBox.Dock = DockStyle.Fill;
            modListBox.FormattingEnabled = true;
            modListBox.Location = new Point(0, 0);
            modListBox.Name = "modListBox";
            modListBox.ScrollAlwaysVisible = true;
            modListBox.Size = new Size(136, 251);
            modListBox.TabIndex = 0;
            modListBox.DragDrop += modListBox_DragDrop;
            modListBox.DragOver += modListBox_DragOver;
            modListBox.MouseDown += modListBox_MouseDown;
            // 
            // modLoaderButton
            // 
            modLoaderButton.Dock = DockStyle.Fill;
            modLoaderButton.Location = new Point(0, 0);
            modLoaderButton.Name = "modLoaderButton";
            modLoaderButton.Size = new Size(136, 25);
            modLoaderButton.TabIndex = 0;
            modLoaderButton.Text = "Load Mod Data";
            modLoaderButton.UseVisualStyleBackColor = true;
            modLoaderButton.Click += modLoaderButton_Click;
            // 
            // digimonListWrapper
            // 
            digimonListWrapper.Dock = DockStyle.Fill;
            digimonListWrapper.FixedPanel = FixedPanel.Panel1;
            digimonListWrapper.Location = new Point(0, 0);
            digimonListWrapper.Name = "digimonListWrapper";
            // 
            // digimonListWrapper.Panel1
            // 
            digimonListWrapper.Panel1.Controls.Add(digimonList);
            // 
            // digimonListWrapper.Panel2
            // 
            digimonListWrapper.Panel2.Controls.Add(digimonDataContainer);
            digimonListWrapper.Size = new Size(725, 309);
            digimonListWrapper.SplitterDistance = 301;
            digimonListWrapper.TabIndex = 0;
            digimonListWrapper.Visible = false;
            // 
            // digimonList
            // 
            digimonList.Controls.Add(digimonListInTraining1Tab);
            digimonList.Controls.Add(digimonListInTraining2Tab);
            digimonList.Controls.Add(digimonListRookieTab);
            digimonList.Controls.Add(digimonListChampionTab);
            digimonList.Controls.Add(digimonListArmorTab);
            digimonList.Controls.Add(digimonListUltimateTab);
            digimonList.Controls.Add(digimonListMegaTab);
            digimonList.Controls.Add(digimonListUltraTab);
            digimonList.Dock = DockStyle.Fill;
            digimonList.Location = new Point(0, 0);
            digimonList.Name = "digimonList";
            digimonList.Padding = new Point(0, 3);
            digimonList.SelectedIndex = 0;
            digimonList.Size = new Size(301, 309);
            digimonList.TabIndex = 0;
            // 
            // digimonListInTraining1Tab
            // 
            digimonListInTraining1Tab.AutoScroll = true;
            digimonListInTraining1Tab.Location = new Point(4, 24);
            digimonListInTraining1Tab.Name = "digimonListInTraining1Tab";
            digimonListInTraining1Tab.Padding = new Padding(3);
            digimonListInTraining1Tab.Size = new Size(293, 281);
            digimonListInTraining1Tab.TabIndex = 0;
            digimonListInTraining1Tab.Text = "IT1";
            digimonListInTraining1Tab.UseVisualStyleBackColor = true;
            // 
            // digimonListInTraining2Tab
            // 
            digimonListInTraining2Tab.AutoScroll = true;
            digimonListInTraining2Tab.Location = new Point(4, 24);
            digimonListInTraining2Tab.Name = "digimonListInTraining2Tab";
            digimonListInTraining2Tab.Padding = new Padding(3);
            digimonListInTraining2Tab.Size = new Size(293, 281);
            digimonListInTraining2Tab.TabIndex = 1;
            digimonListInTraining2Tab.Text = "IT2";
            digimonListInTraining2Tab.UseVisualStyleBackColor = true;
            // 
            // digimonListRookieTab
            // 
            digimonListRookieTab.Location = new Point(4, 24);
            digimonListRookieTab.Name = "digimonListRookieTab";
            digimonListRookieTab.Padding = new Padding(3);
            digimonListRookieTab.Size = new Size(293, 281);
            digimonListRookieTab.TabIndex = 2;
            digimonListRookieTab.Text = "R";
            digimonListRookieTab.UseVisualStyleBackColor = true;
            // 
            // digimonListChampionTab
            // 
            digimonListChampionTab.Location = new Point(4, 24);
            digimonListChampionTab.Name = "digimonListChampionTab";
            digimonListChampionTab.Padding = new Padding(3);
            digimonListChampionTab.Size = new Size(293, 281);
            digimonListChampionTab.TabIndex = 3;
            digimonListChampionTab.Text = "C";
            digimonListChampionTab.UseVisualStyleBackColor = true;
            // 
            // digimonListArmorTab
            // 
            digimonListArmorTab.Location = new Point(4, 24);
            digimonListArmorTab.Name = "digimonListArmorTab";
            digimonListArmorTab.Padding = new Padding(3);
            digimonListArmorTab.Size = new Size(293, 281);
            digimonListArmorTab.TabIndex = 4;
            digimonListArmorTab.Text = "A";
            digimonListArmorTab.UseVisualStyleBackColor = true;
            // 
            // digimonListUltimateTab
            // 
            digimonListUltimateTab.Location = new Point(4, 24);
            digimonListUltimateTab.Name = "digimonListUltimateTab";
            digimonListUltimateTab.Padding = new Padding(3);
            digimonListUltimateTab.Size = new Size(293, 281);
            digimonListUltimateTab.TabIndex = 5;
            digimonListUltimateTab.Text = "U";
            digimonListUltimateTab.UseVisualStyleBackColor = true;
            // 
            // digimonListMegaTab
            // 
            digimonListMegaTab.Location = new Point(4, 24);
            digimonListMegaTab.Name = "digimonListMegaTab";
            digimonListMegaTab.Padding = new Padding(3);
            digimonListMegaTab.Size = new Size(293, 281);
            digimonListMegaTab.TabIndex = 6;
            digimonListMegaTab.Text = "M";
            digimonListMegaTab.UseVisualStyleBackColor = true;
            // 
            // digimonListUltraTab
            // 
            digimonListUltraTab.Location = new Point(4, 24);
            digimonListUltraTab.Name = "digimonListUltraTab";
            digimonListUltraTab.Padding = new Padding(3);
            digimonListUltraTab.Size = new Size(293, 281);
            digimonListUltraTab.TabIndex = 7;
            digimonListUltraTab.Text = "U+";
            digimonListUltraTab.UseVisualStyleBackColor = true;
            // 
            // digimonDataContainer
            // 
            digimonDataContainer.Dock = DockStyle.Fill;
            digimonDataContainer.Location = new Point(0, 0);
            digimonDataContainer.Name = "digimonDataContainer";
            digimonDataContainer.Orientation = Orientation.Horizontal;
            // 
            // digimonDataContainer.Panel1
            // 
            digimonDataContainer.Panel1.Controls.Add(digimonName);
            // 
            // digimonDataContainer.Panel2
            // 
            digimonDataContainer.Panel2.Controls.Add(digimonDataPanel);
            digimonDataContainer.Size = new Size(420, 309);
            digimonDataContainer.SplitterDistance = 29;
            digimonDataContainer.TabIndex = 0;
            // 
            // digimonName
            // 
            digimonName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            digimonName.AutoSize = true;
            digimonName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            digimonName.Location = new Point(158, 5);
            digimonName.Name = "digimonName";
            digimonName.Size = new Size(77, 21);
            digimonName.TabIndex = 0;
            digimonName.Text = "Digimon";
            digimonName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // digimonDataPanel
            // 
            digimonDataPanel.AutoSize = true;
            digimonDataPanel.ColumnCount = 3;
            digimonDataPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            digimonDataPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            digimonDataPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            digimonDataPanel.Dock = DockStyle.Fill;
            digimonDataPanel.Location = new Point(0, 0);
            digimonDataPanel.Name = "digimonDataPanel";
            digimonDataPanel.RowCount = 1;
            digimonDataPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            digimonDataPanel.Size = new Size(420, 276);
            digimonDataPanel.TabIndex = 0;
            // 
            // logBox
            // 
            logBox.BackColor = SystemColors.Window;
            logBox.Dock = DockStyle.Fill;
            logBox.Location = new Point(0, 0);
            logBox.Multiline = true;
            logBox.Name = "logBox";
            logBox.ReadOnly = true;
            logBox.ScrollBars = ScrollBars.Vertical;
            logBox.Size = new Size(865, 126);
            logBox.TabIndex = 1;
            // 
            // modFolderLocator
            // 
            modFolderLocator.AddToRecent = false;
            modFolderLocator.RootFolder = Environment.SpecialFolder.MyComputer;
            modFolderLocator.ShowNewFolderButton = false;
            modFolderLocator.ShowPinnedPlaces = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 489);
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
            modData.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)modData).EndInit();
            modData.ResumeLayout(false);
            modList.Panel1.ResumeLayout(false);
            modList.Panel1.PerformLayout();
            modList.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)modList).EndInit();
            modList.ResumeLayout(false);
            modReloadWrapper.Panel1.ResumeLayout(false);
            modReloadWrapper.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)modReloadWrapper).EndInit();
            modReloadWrapper.ResumeLayout(false);
            digimonListWrapper.Panel1.ResumeLayout(false);
            digimonListWrapper.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)digimonListWrapper).EndInit();
            digimonListWrapper.ResumeLayout(false);
            digimonList.ResumeLayout(false);
            digimonDataContainer.Panel1.ResumeLayout(false);
            digimonDataContainer.Panel1.PerformLayout();
            digimonDataContainer.Panel2.ResumeLayout(false);
            digimonDataContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)digimonDataContainer).EndInit();
            digimonDataContainer.ResumeLayout(false);
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
        private SplitContainer modReloadWrapper;
        private CheckedListBox modListBox;
        private Button modLoaderButton;
        private SplitContainer digimonListWrapper;
        private TabControl digimonList;
        private TabPage digimonListInTraining1Tab;
        private TabPage digimonListInTraining2Tab;
        private TabPage digimonListRookieTab;
        private TabPage digimonListChampionTab;
        private TabPage digimonListArmorTab;
        private TabPage digimonListUltimateTab;
        private TabPage digimonListMegaTab;
        private TabPage digimonListUltraTab;
        private FolderBrowserDialog modFolderLocator;
        private SplitContainer digimonDataContainer;
        private TableLayoutPanel digimonDataPanel;
        private Label digimonName;
    }
}
