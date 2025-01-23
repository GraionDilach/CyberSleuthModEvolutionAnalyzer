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
            aboutLabel = new Label();
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
            digimonInTraining1List = new ListBox();
            digimonListInTraining2Tab = new TabPage();
            digimonInTraining2List = new ListBox();
            digimonListRookieTab = new TabPage();
            digimonRookieList = new ListBox();
            digimonListChampionTab = new TabPage();
            digimonChampionList = new ListBox();
            digimonListArmorTab = new TabPage();
            digimonArmorList = new ListBox();
            digimonListUltimateTab = new TabPage();
            digimonUltimateList = new ListBox();
            digimonListMegaTab = new TabPage();
            digimonMegaList = new ListBox();
            digimonListUltraTab = new TabPage();
            digimonUltraList = new ListBox();
            digimonDataContainer = new SplitContainer();
            digimonName = new Label();
            digimonDataPanel = new TableLayoutPanel();
            digimonDataDeEvoLabel = new Label();
            digimonDataEvoLabel = new Label();
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
            digimonListInTraining1Tab.SuspendLayout();
            digimonListInTraining2Tab.SuspendLayout();
            digimonListRookieTab.SuspendLayout();
            digimonListChampionTab.SuspendLayout();
            digimonListArmorTab.SuspendLayout();
            digimonListUltimateTab.SuspendLayout();
            digimonListMegaTab.SuspendLayout();
            digimonListUltraTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)digimonDataContainer).BeginInit();
            digimonDataContainer.Panel1.SuspendLayout();
            digimonDataContainer.Panel2.SuspendLayout();
            digimonDataContainer.SuspendLayout();
            digimonDataPanel.SuspendLayout();
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
            folderRoot.Panel1.Controls.Add(aboutLabel);
            folderRoot.Panel1.Controls.Add(modGenerator);
            folderRoot.Panel1.Controls.Add(modsLocationBrowser);
            folderRoot.Panel1.Controls.Add(modsLocationLabel);
            folderRoot.Panel1.Controls.Add(modsLocation);
            // 
            // folderRoot.Panel2
            // 
            folderRoot.Panel2.Controls.Add(rootLogging);
            folderRoot.Size = new Size(904, 673);
            folderRoot.SplitterDistance = 46;
            folderRoot.TabIndex = 0;
            // 
            // aboutLabel
            // 
            aboutLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            aboutLabel.AutoSize = true;
            aboutLabel.ForeColor = SystemColors.HotTrack;
            aboutLabel.Location = new Point(852, 3);
            aboutLabel.Name = "aboutLabel";
            aboutLabel.Size = new Size(49, 15);
            aboutLabel.TabIndex = 4;
            aboutLabel.Text = "About...";
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
            modsLocationLabel.Location = new Point(0, 3);
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
            rootLogging.Size = new Size(904, 623);
            rootLogging.SplitterDistance = 387;
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
            modData.Size = new Size(904, 387);
            modData.SplitterDistance = 142;
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
            modList.Size = new Size(142, 387);
            modList.SplitterDistance = 25;
            modList.TabIndex = 0;
            modList.Visible = false;
            // 
            // modListLabel
            // 
            modListLabel.Dock = DockStyle.Fill;
            modListLabel.Location = new Point(0, 0);
            modListLabel.Name = "modListLabel";
            modListLabel.Size = new Size(142, 25);
            modListLabel.TabIndex = 0;
            modListLabel.Text = "Detected mods:";
            modListLabel.TextAlign = ContentAlignment.BottomLeft;
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
            modReloadWrapper.Size = new Size(142, 358);
            modReloadWrapper.SplitterDistance = 329;
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
            modListBox.Size = new Size(142, 329);
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
            modLoaderButton.Size = new Size(142, 25);
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
            digimonListWrapper.Size = new Size(758, 387);
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
            digimonList.Size = new Size(301, 387);
            digimonList.TabIndex = 0;
            digimonList.SelectedIndexChanged += digimonList_SelectedTabIndexChanged;
            // 
            // digimonListInTraining1Tab
            // 
            digimonListInTraining1Tab.AutoScroll = true;
            digimonListInTraining1Tab.Controls.Add(digimonInTraining1List);
            digimonListInTraining1Tab.Location = new Point(4, 24);
            digimonListInTraining1Tab.Name = "digimonListInTraining1Tab";
            digimonListInTraining1Tab.Padding = new Padding(3);
            digimonListInTraining1Tab.Size = new Size(293, 359);
            digimonListInTraining1Tab.TabIndex = 0;
            digimonListInTraining1Tab.Text = "IT1";
            digimonListInTraining1Tab.UseVisualStyleBackColor = true;
            // 
            // digimonInTraining1List
            // 
            digimonInTraining1List.Dock = DockStyle.Fill;
            digimonInTraining1List.FormattingEnabled = true;
            digimonInTraining1List.ItemHeight = 15;
            digimonInTraining1List.Location = new Point(3, 3);
            digimonInTraining1List.Name = "digimonInTraining1List";
            digimonInTraining1List.Size = new Size(287, 353);
            digimonInTraining1List.TabIndex = 0;
            digimonInTraining1List.SelectedIndexChanged += digimonList_SelectedIndexChanged;
            // 
            // digimonListInTraining2Tab
            // 
            digimonListInTraining2Tab.AutoScroll = true;
            digimonListInTraining2Tab.Controls.Add(digimonInTraining2List);
            digimonListInTraining2Tab.Location = new Point(4, 24);
            digimonListInTraining2Tab.Name = "digimonListInTraining2Tab";
            digimonListInTraining2Tab.Padding = new Padding(3);
            digimonListInTraining2Tab.Size = new Size(293, 281);
            digimonListInTraining2Tab.TabIndex = 1;
            digimonListInTraining2Tab.Text = "IT2";
            digimonListInTraining2Tab.UseVisualStyleBackColor = true;
            // 
            // digimonInTraining2List
            // 
            digimonInTraining2List.Dock = DockStyle.Fill;
            digimonInTraining2List.FormattingEnabled = true;
            digimonInTraining2List.ItemHeight = 15;
            digimonInTraining2List.Location = new Point(3, 3);
            digimonInTraining2List.Name = "digimonInTraining2List";
            digimonInTraining2List.Size = new Size(287, 275);
            digimonInTraining2List.TabIndex = 0;
            digimonInTraining2List.SelectedIndexChanged += digimonList_SelectedIndexChanged;
            // 
            // digimonListRookieTab
            // 
            digimonListRookieTab.Controls.Add(digimonRookieList);
            digimonListRookieTab.Location = new Point(4, 24);
            digimonListRookieTab.Name = "digimonListRookieTab";
            digimonListRookieTab.Padding = new Padding(3);
            digimonListRookieTab.Size = new Size(293, 281);
            digimonListRookieTab.TabIndex = 2;
            digimonListRookieTab.Text = "R";
            digimonListRookieTab.UseVisualStyleBackColor = true;
            // 
            // digimonRookieList
            // 
            digimonRookieList.Dock = DockStyle.Fill;
            digimonRookieList.FormattingEnabled = true;
            digimonRookieList.ItemHeight = 15;
            digimonRookieList.Location = new Point(3, 3);
            digimonRookieList.Name = "digimonRookieList";
            digimonRookieList.Size = new Size(287, 275);
            digimonRookieList.TabIndex = 0;
            digimonRookieList.SelectedIndexChanged += digimonList_SelectedIndexChanged;
            // 
            // digimonListChampionTab
            // 
            digimonListChampionTab.Controls.Add(digimonChampionList);
            digimonListChampionTab.Location = new Point(4, 24);
            digimonListChampionTab.Name = "digimonListChampionTab";
            digimonListChampionTab.Padding = new Padding(3);
            digimonListChampionTab.Size = new Size(293, 281);
            digimonListChampionTab.TabIndex = 3;
            digimonListChampionTab.Text = "C";
            digimonListChampionTab.UseVisualStyleBackColor = true;
            // 
            // digimonChampionList
            // 
            digimonChampionList.Dock = DockStyle.Fill;
            digimonChampionList.FormattingEnabled = true;
            digimonChampionList.ItemHeight = 15;
            digimonChampionList.Location = new Point(3, 3);
            digimonChampionList.Name = "digimonChampionList";
            digimonChampionList.Size = new Size(287, 275);
            digimonChampionList.TabIndex = 0;
            digimonChampionList.SelectedIndexChanged += digimonList_SelectedIndexChanged;
            // 
            // digimonListArmorTab
            // 
            digimonListArmorTab.Controls.Add(digimonArmorList);
            digimonListArmorTab.Location = new Point(4, 24);
            digimonListArmorTab.Name = "digimonListArmorTab";
            digimonListArmorTab.Padding = new Padding(3);
            digimonListArmorTab.Size = new Size(293, 281);
            digimonListArmorTab.TabIndex = 4;
            digimonListArmorTab.Text = "A";
            digimonListArmorTab.UseVisualStyleBackColor = true;
            // 
            // digimonArmorList
            // 
            digimonArmorList.Dock = DockStyle.Fill;
            digimonArmorList.FormattingEnabled = true;
            digimonArmorList.ItemHeight = 15;
            digimonArmorList.Location = new Point(3, 3);
            digimonArmorList.Name = "digimonArmorList";
            digimonArmorList.Size = new Size(287, 275);
            digimonArmorList.TabIndex = 0;
            digimonArmorList.SelectedIndexChanged += digimonList_SelectedIndexChanged;
            // 
            // digimonListUltimateTab
            // 
            digimonListUltimateTab.Controls.Add(digimonUltimateList);
            digimonListUltimateTab.Location = new Point(4, 24);
            digimonListUltimateTab.Name = "digimonListUltimateTab";
            digimonListUltimateTab.Padding = new Padding(3);
            digimonListUltimateTab.Size = new Size(293, 281);
            digimonListUltimateTab.TabIndex = 5;
            digimonListUltimateTab.Text = "U";
            digimonListUltimateTab.UseVisualStyleBackColor = true;
            // 
            // digimonUltimateList
            // 
            digimonUltimateList.Dock = DockStyle.Fill;
            digimonUltimateList.FormattingEnabled = true;
            digimonUltimateList.ItemHeight = 15;
            digimonUltimateList.Location = new Point(3, 3);
            digimonUltimateList.Name = "digimonUltimateList";
            digimonUltimateList.Size = new Size(287, 275);
            digimonUltimateList.TabIndex = 0;
            digimonUltimateList.SelectedIndexChanged += digimonList_SelectedIndexChanged;
            // 
            // digimonListMegaTab
            // 
            digimonListMegaTab.Controls.Add(digimonMegaList);
            digimonListMegaTab.Location = new Point(4, 24);
            digimonListMegaTab.Name = "digimonListMegaTab";
            digimonListMegaTab.Padding = new Padding(3);
            digimonListMegaTab.Size = new Size(293, 281);
            digimonListMegaTab.TabIndex = 6;
            digimonListMegaTab.Text = "M";
            digimonListMegaTab.UseVisualStyleBackColor = true;
            // 
            // digimonMegaList
            // 
            digimonMegaList.Dock = DockStyle.Fill;
            digimonMegaList.FormattingEnabled = true;
            digimonMegaList.ItemHeight = 15;
            digimonMegaList.Location = new Point(3, 3);
            digimonMegaList.Name = "digimonMegaList";
            digimonMegaList.Size = new Size(287, 275);
            digimonMegaList.TabIndex = 0;
            digimonMegaList.SelectedIndexChanged += digimonList_SelectedIndexChanged;
            // 
            // digimonListUltraTab
            // 
            digimonListUltraTab.Controls.Add(digimonUltraList);
            digimonListUltraTab.Location = new Point(4, 24);
            digimonListUltraTab.Name = "digimonListUltraTab";
            digimonListUltraTab.Padding = new Padding(3);
            digimonListUltraTab.Size = new Size(293, 281);
            digimonListUltraTab.TabIndex = 7;
            digimonListUltraTab.Text = "U+";
            digimonListUltraTab.UseVisualStyleBackColor = true;
            // 
            // digimonUltraList
            // 
            digimonUltraList.Dock = DockStyle.Fill;
            digimonUltraList.FormattingEnabled = true;
            digimonUltraList.ItemHeight = 15;
            digimonUltraList.Location = new Point(3, 3);
            digimonUltraList.Name = "digimonUltraList";
            digimonUltraList.Size = new Size(287, 275);
            digimonUltraList.TabIndex = 0;
            digimonUltraList.SelectedIndexChanged += digimonList_SelectedIndexChanged;
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
            digimonDataContainer.Size = new Size(453, 387);
            digimonDataContainer.SplitterDistance = 36;
            digimonDataContainer.TabIndex = 0;
            // 
            // digimonName
            // 
            digimonName.Dock = DockStyle.Fill;
            digimonName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            digimonName.Location = new Point(0, 0);
            digimonName.Name = "digimonName";
            digimonName.Size = new Size(453, 36);
            digimonName.TabIndex = 0;
            digimonName.Text = "Digimon";
            digimonName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // digimonDataPanel
            // 
            digimonDataPanel.AutoSize = true;
            digimonDataPanel.ColumnCount = 3;
            digimonDataPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            digimonDataPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            digimonDataPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            digimonDataPanel.Controls.Add(digimonDataDeEvoLabel, 0, 0);
            digimonDataPanel.Controls.Add(digimonDataEvoLabel, 2, 0);
            digimonDataPanel.Dock = DockStyle.Fill;
            digimonDataPanel.Location = new Point(0, 0);
            digimonDataPanel.Name = "digimonDataPanel";
            digimonDataPanel.RowCount = 2;
            digimonDataPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            digimonDataPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            digimonDataPanel.Size = new Size(453, 347);
            digimonDataPanel.TabIndex = 0;
            // 
            // digimonDataDeEvoLabel
            // 
            digimonDataDeEvoLabel.Dock = DockStyle.Fill;
            digimonDataDeEvoLabel.Location = new Point(3, 0);
            digimonDataDeEvoLabel.Name = "digimonDataDeEvoLabel";
            digimonDataDeEvoLabel.Size = new Size(144, 20);
            digimonDataDeEvoLabel.TabIndex = 0;
            digimonDataDeEvoLabel.Text = "De-Evolutions";
            digimonDataDeEvoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // digimonDataEvoLabel
            // 
            digimonDataEvoLabel.Dock = DockStyle.Fill;
            digimonDataEvoLabel.Location = new Point(304, 0);
            digimonDataEvoLabel.Name = "digimonDataEvoLabel";
            digimonDataEvoLabel.Size = new Size(146, 20);
            digimonDataEvoLabel.TabIndex = 1;
            digimonDataEvoLabel.Text = "Evolutions";
            digimonDataEvoLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            logBox.Size = new Size(904, 232);
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
            ClientSize = new Size(904, 673);
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
            digimonListInTraining1Tab.ResumeLayout(false);
            digimonListInTraining2Tab.ResumeLayout(false);
            digimonListRookieTab.ResumeLayout(false);
            digimonListChampionTab.ResumeLayout(false);
            digimonListArmorTab.ResumeLayout(false);
            digimonListUltimateTab.ResumeLayout(false);
            digimonListMegaTab.ResumeLayout(false);
            digimonListUltraTab.ResumeLayout(false);
            digimonDataContainer.Panel1.ResumeLayout(false);
            digimonDataContainer.Panel2.ResumeLayout(false);
            digimonDataContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)digimonDataContainer).EndInit();
            digimonDataContainer.ResumeLayout(false);
            digimonDataPanel.ResumeLayout(false);
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
        private ListBox digimonInTraining1List;
        private ListBox digimonInTraining2List;
        private ListBox digimonRookieList;
        private ListBox digimonChampionList;
        private ListBox digimonArmorList;
        private ListBox digimonUltimateList;
        private ListBox digimonMegaList;
        private ListBox digimonUltraList;
        private Label aboutLabel;
        private Label digimonDataDeEvoLabel;
        private Label digimonDataEvoLabel;
    }
}
