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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            selectAllMods = new Button();
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
            digimonDeEvo1 = new DigimonEvolutionOption();
            digimonDeEvo2 = new DigimonEvolutionOption();
            digimonDeEvo3 = new DigimonEvolutionOption();
            digimonDeEvo4 = new DigimonEvolutionOption();
            digimonDeEvo5 = new DigimonEvolutionOption();
            digimonDeEvo6 = new DigimonEvolutionOption();
            digimonDeEvo7 = new DigimonEvolutionOption();
            digimonDeEvo8 = new DigimonEvolutionOption();
            digimonDeEvo9 = new DigimonEvolutionOption();
            digimonDeEvo10 = new DigimonEvolutionOption();
            digimonDeEvo11 = new DigimonEvolutionOption();
            digimonEvo1 = new DigimonEvolutionOption();
            digimonEvo2 = new DigimonEvolutionOption();
            digimonEvo3 = new DigimonEvolutionOption();
            digimonEvo4 = new DigimonEvolutionOption();
            digimonEvo5 = new DigimonEvolutionOption();
            digimonEvo6 = new DigimonEvolutionOption();
            digimonEvo7 = new DigimonEvolutionOption();
            digimonEvo8 = new DigimonEvolutionOption();
            digimonEvo9 = new DigimonEvolutionOption();
            digimonEvo10 = new DigimonEvolutionOption();
            digimonEvo11 = new DigimonEvolutionOption();
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
            folderRoot.Size = new Size(909, 642);
            folderRoot.SplitterDistance = 46;
            folderRoot.TabIndex = 0;
            // 
            // aboutLabel
            // 
            aboutLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            aboutLabel.AutoSize = true;
            aboutLabel.ForeColor = SystemColors.HotTrack;
            aboutLabel.Location = new Point(857, 3);
            aboutLabel.Name = "aboutLabel";
            aboutLabel.Size = new Size(49, 15);
            aboutLabel.TabIndex = 4;
            aboutLabel.Text = "About...";
            aboutLabel.Click += aboutLabel_Click;
            // 
            // modGenerator
            // 
            modGenerator.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            modGenerator.Location = new Point(780, 21);
            modGenerator.Name = "modGenerator";
            modGenerator.Size = new Size(117, 23);
            modGenerator.TabIndex = 3;
            modGenerator.Text = "Generate Mod...";
            modGenerator.UseVisualStyleBackColor = true;
            modGenerator.Visible = false;
            modGenerator.Click += modGenerator_Click;
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
            rootLogging.Size = new Size(909, 592);
            rootLogging.SplitterDistance = 478;
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
            modData.Size = new Size(909, 478);
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
            modList.Size = new Size(142, 478);
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
            modReloadWrapper.Panel2.Controls.Add(selectAllMods);
            modReloadWrapper.Panel2.Controls.Add(modLoaderButton);
            modReloadWrapper.Size = new Size(142, 449);
            modReloadWrapper.SplitterDistance = 390;
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
            modListBox.Size = new Size(142, 390);
            modListBox.TabIndex = 0;
            modListBox.DragDrop += modListBox_DragDrop;
            modListBox.DragOver += modListBox_DragOver;
            modListBox.MouseDown += modListBox_MouseDown;
            // 
            // selectAllMods
            // 
            selectAllMods.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            selectAllMods.Location = new Point(0, -1);
            selectAllMods.Name = "selectAllMods";
            selectAllMods.Size = new Size(142, 25);
            selectAllMods.TabIndex = 0;
            selectAllMods.Text = "(De)Select All Mods";
            selectAllMods.UseVisualStyleBackColor = true;
            selectAllMods.Click += selectAllMods_Click;
            // 
            // modLoaderButton
            // 
            modLoaderButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            modLoaderButton.Location = new Point(0, 30);
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
            digimonListWrapper.Size = new Size(763, 478);
            digimonListWrapper.SplitterDistance = 255;
            digimonListWrapper.TabIndex = 0;
            digimonListWrapper.Visible = false;
            // 
            // digimonList
            // 
            digimonList.Alignment = TabAlignment.Left;
            digimonList.Controls.Add(digimonListInTraining1Tab);
            digimonList.Controls.Add(digimonListInTraining2Tab);
            digimonList.Controls.Add(digimonListRookieTab);
            digimonList.Controls.Add(digimonListChampionTab);
            digimonList.Controls.Add(digimonListArmorTab);
            digimonList.Controls.Add(digimonListUltimateTab);
            digimonList.Controls.Add(digimonListMegaTab);
            digimonList.Controls.Add(digimonListUltraTab);
            digimonList.Dock = DockStyle.Fill;
            digimonList.DrawMode = TabDrawMode.OwnerDrawFixed;
            digimonList.ItemSize = new Size(10, 25);
            digimonList.Location = new Point(0, 0);
            digimonList.Multiline = true;
            digimonList.Name = "digimonList";
            digimonList.Padding = new Point(0, 0);
            digimonList.SelectedIndex = 0;
            digimonList.Size = new Size(255, 478);
            digimonList.TabIndex = 0;
            digimonList.DrawItem += digimonList_DrawItem;
            digimonList.SelectedIndexChanged += digimonList_SelectedTabIndexChanged;
            // 
            // digimonListInTraining1Tab
            // 
            digimonListInTraining1Tab.AutoScroll = true;
            digimonListInTraining1Tab.Controls.Add(digimonInTraining1List);
            digimonListInTraining1Tab.Location = new Point(29, 4);
            digimonListInTraining1Tab.Name = "digimonListInTraining1Tab";
            digimonListInTraining1Tab.Padding = new Padding(3);
            digimonListInTraining1Tab.Size = new Size(222, 470);
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
            digimonInTraining1List.Size = new Size(216, 464);
            digimonInTraining1List.TabIndex = 0;
            digimonInTraining1List.SelectedIndexChanged += digimonList_SelectedIndexChanged;
            // 
            // digimonListInTraining2Tab
            // 
            digimonListInTraining2Tab.AutoScroll = true;
            digimonListInTraining2Tab.Controls.Add(digimonInTraining2List);
            digimonListInTraining2Tab.Location = new Point(29, 4);
            digimonListInTraining2Tab.Name = "digimonListInTraining2Tab";
            digimonListInTraining2Tab.Padding = new Padding(3);
            digimonListInTraining2Tab.Size = new Size(222, 470);
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
            digimonInTraining2List.Size = new Size(216, 464);
            digimonInTraining2List.TabIndex = 0;
            digimonInTraining2List.SelectedIndexChanged += digimonList_SelectedIndexChanged;
            // 
            // digimonListRookieTab
            // 
            digimonListRookieTab.Controls.Add(digimonRookieList);
            digimonListRookieTab.Location = new Point(29, 4);
            digimonListRookieTab.Name = "digimonListRookieTab";
            digimonListRookieTab.Padding = new Padding(3);
            digimonListRookieTab.Size = new Size(222, 470);
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
            digimonRookieList.Size = new Size(216, 464);
            digimonRookieList.TabIndex = 0;
            digimonRookieList.SelectedIndexChanged += digimonList_SelectedIndexChanged;
            // 
            // digimonListChampionTab
            // 
            digimonListChampionTab.Controls.Add(digimonChampionList);
            digimonListChampionTab.Location = new Point(29, 4);
            digimonListChampionTab.Name = "digimonListChampionTab";
            digimonListChampionTab.Padding = new Padding(3);
            digimonListChampionTab.Size = new Size(222, 470);
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
            digimonChampionList.Size = new Size(216, 464);
            digimonChampionList.TabIndex = 0;
            digimonChampionList.SelectedIndexChanged += digimonList_SelectedIndexChanged;
            // 
            // digimonListArmorTab
            // 
            digimonListArmorTab.Controls.Add(digimonArmorList);
            digimonListArmorTab.Location = new Point(29, 4);
            digimonListArmorTab.Name = "digimonListArmorTab";
            digimonListArmorTab.Padding = new Padding(3);
            digimonListArmorTab.Size = new Size(222, 470);
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
            digimonArmorList.Size = new Size(216, 464);
            digimonArmorList.TabIndex = 0;
            digimonArmorList.SelectedIndexChanged += digimonList_SelectedIndexChanged;
            // 
            // digimonListUltimateTab
            // 
            digimonListUltimateTab.Controls.Add(digimonUltimateList);
            digimonListUltimateTab.Location = new Point(29, 4);
            digimonListUltimateTab.Name = "digimonListUltimateTab";
            digimonListUltimateTab.Padding = new Padding(3);
            digimonListUltimateTab.Size = new Size(222, 470);
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
            digimonUltimateList.Size = new Size(216, 464);
            digimonUltimateList.TabIndex = 0;
            digimonUltimateList.SelectedIndexChanged += digimonList_SelectedIndexChanged;
            // 
            // digimonListMegaTab
            // 
            digimonListMegaTab.Controls.Add(digimonMegaList);
            digimonListMegaTab.Location = new Point(29, 4);
            digimonListMegaTab.Name = "digimonListMegaTab";
            digimonListMegaTab.Padding = new Padding(3);
            digimonListMegaTab.Size = new Size(222, 470);
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
            digimonMegaList.Size = new Size(216, 464);
            digimonMegaList.TabIndex = 0;
            digimonMegaList.SelectedIndexChanged += digimonList_SelectedIndexChanged;
            // 
            // digimonListUltraTab
            // 
            digimonListUltraTab.Controls.Add(digimonUltraList);
            digimonListUltraTab.Location = new Point(29, 4);
            digimonListUltraTab.Name = "digimonListUltraTab";
            digimonListUltraTab.Padding = new Padding(3);
            digimonListUltraTab.Size = new Size(222, 470);
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
            digimonUltraList.Size = new Size(216, 464);
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
            digimonDataContainer.Size = new Size(504, 478);
            digimonDataContainer.SplitterDistance = 42;
            digimonDataContainer.TabIndex = 0;
            // 
            // digimonName
            // 
            digimonName.Dock = DockStyle.Fill;
            digimonName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            digimonName.Location = new Point(0, 0);
            digimonName.Name = "digimonName";
            digimonName.Size = new Size(504, 42);
            digimonName.TabIndex = 0;
            digimonName.Text = "Digimon";
            digimonName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // digimonDataPanel
            // 
            digimonDataPanel.AutoSize = true;
            digimonDataPanel.ColumnCount = 3;
            digimonDataPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            digimonDataPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            digimonDataPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            digimonDataPanel.Controls.Add(digimonDataDeEvoLabel, 0, 0);
            digimonDataPanel.Controls.Add(digimonDataEvoLabel, 2, 0);
            digimonDataPanel.Controls.Add(digimonDeEvo1, 0, 1);
            digimonDataPanel.Controls.Add(digimonDeEvo2, 0, 2);
            digimonDataPanel.Controls.Add(digimonDeEvo3, 0, 3);
            digimonDataPanel.Controls.Add(digimonDeEvo4, 0, 4);
            digimonDataPanel.Controls.Add(digimonDeEvo5, 0, 5);
            digimonDataPanel.Controls.Add(digimonDeEvo6, 0, 6);
            digimonDataPanel.Controls.Add(digimonDeEvo7, 0, 7);
            digimonDataPanel.Controls.Add(digimonDeEvo8, 0, 8);
            digimonDataPanel.Controls.Add(digimonDeEvo9, 0, 9);
            digimonDataPanel.Controls.Add(digimonDeEvo10, 0, 10);
            digimonDataPanel.Controls.Add(digimonDeEvo11, 0, 11);
            digimonDataPanel.Controls.Add(digimonEvo1, 2, 1);
            digimonDataPanel.Controls.Add(digimonEvo2, 2, 2);
            digimonDataPanel.Controls.Add(digimonEvo3, 2, 3);
            digimonDataPanel.Controls.Add(digimonEvo4, 2, 4);
            digimonDataPanel.Controls.Add(digimonEvo5, 2, 5);
            digimonDataPanel.Controls.Add(digimonEvo6, 2, 6);
            digimonDataPanel.Controls.Add(digimonEvo7, 2, 7);
            digimonDataPanel.Controls.Add(digimonEvo8, 2, 8);
            digimonDataPanel.Controls.Add(digimonEvo9, 2, 9);
            digimonDataPanel.Controls.Add(digimonEvo10, 2, 10);
            digimonDataPanel.Controls.Add(digimonEvo11, 2, 11);
            digimonDataPanel.Dock = DockStyle.Fill;
            digimonDataPanel.Location = new Point(0, 0);
            digimonDataPanel.Name = "digimonDataPanel";
            digimonDataPanel.RowCount = 13;
            digimonDataPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            digimonDataPanel.RowStyles.Add(new RowStyle());
            digimonDataPanel.RowStyles.Add(new RowStyle());
            digimonDataPanel.RowStyles.Add(new RowStyle());
            digimonDataPanel.RowStyles.Add(new RowStyle());
            digimonDataPanel.RowStyles.Add(new RowStyle());
            digimonDataPanel.RowStyles.Add(new RowStyle());
            digimonDataPanel.RowStyles.Add(new RowStyle());
            digimonDataPanel.RowStyles.Add(new RowStyle());
            digimonDataPanel.RowStyles.Add(new RowStyle());
            digimonDataPanel.RowStyles.Add(new RowStyle());
            digimonDataPanel.RowStyles.Add(new RowStyle());
            digimonDataPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            digimonDataPanel.Size = new Size(504, 432);
            digimonDataPanel.TabIndex = 0;
            // 
            // digimonDataDeEvoLabel
            // 
            digimonDataDeEvoLabel.Dock = DockStyle.Fill;
            digimonDataDeEvoLabel.Location = new Point(3, 0);
            digimonDataDeEvoLabel.Name = "digimonDataDeEvoLabel";
            digimonDataDeEvoLabel.Size = new Size(220, 30);
            digimonDataDeEvoLabel.TabIndex = 0;
            digimonDataDeEvoLabel.Text = "De-Digivolutions";
            digimonDataDeEvoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // digimonDataEvoLabel
            // 
            digimonDataEvoLabel.Dock = DockStyle.Fill;
            digimonDataEvoLabel.Location = new Point(279, 0);
            digimonDataEvoLabel.Name = "digimonDataEvoLabel";
            digimonDataEvoLabel.Size = new Size(222, 30);
            digimonDataEvoLabel.TabIndex = 1;
            digimonDataEvoLabel.Text = "Digivolutions";
            digimonDataEvoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // digimonDeEvo1
            // 
            digimonDeEvo1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            digimonDeEvo1.AutoSize = true;
            digimonDeEvo1.Location = new Point(3, 33);
            digimonDeEvo1.Name = "digimonDeEvo1";
            digimonDeEvo1.SelectedDigimon = null;
            digimonDeEvo1.Size = new Size(220, 28);
            digimonDeEvo1.TabIndex = 2;
            digimonDeEvo1.SelectedDigimonChanged += digimonDeEvo_SelectedDigimonChanged;
            digimonDeEvo1.JumpToSelectedDigimon += jumpToSelectedDigimon;
            // 
            // digimonDeEvo2
            // 
            digimonDeEvo2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            digimonDeEvo2.AutoSize = true;
            digimonDeEvo2.Location = new Point(3, 67);
            digimonDeEvo2.Name = "digimonDeEvo2";
            digimonDeEvo2.SelectedDigimon = null;
            digimonDeEvo2.Size = new Size(220, 28);
            digimonDeEvo2.TabIndex = 2;
            digimonDeEvo2.SelectedDigimonChanged += digimonDeEvo_SelectedDigimonChanged;
            digimonDeEvo2.JumpToSelectedDigimon += jumpToSelectedDigimon;
            // 
            // digimonDeEvo3
            // 
            digimonDeEvo3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            digimonDeEvo3.AutoSize = true;
            digimonDeEvo3.Location = new Point(3, 101);
            digimonDeEvo3.Name = "digimonDeEvo3";
            digimonDeEvo3.SelectedDigimon = null;
            digimonDeEvo3.Size = new Size(220, 28);
            digimonDeEvo3.TabIndex = 2;
            digimonDeEvo3.SelectedDigimonChanged += digimonDeEvo_SelectedDigimonChanged;
            digimonDeEvo3.JumpToSelectedDigimon += jumpToSelectedDigimon;
            // 
            // digimonDeEvo4
            // 
            digimonDeEvo4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            digimonDeEvo4.AutoSize = true;
            digimonDeEvo4.Location = new Point(3, 135);
            digimonDeEvo4.Name = "digimonDeEvo4";
            digimonDeEvo4.SelectedDigimon = null;
            digimonDeEvo4.Size = new Size(220, 28);
            digimonDeEvo4.TabIndex = 2;
            digimonDeEvo4.SelectedDigimonChanged += digimonDeEvo_SelectedDigimonChanged;
            digimonDeEvo4.JumpToSelectedDigimon += jumpToSelectedDigimon;
            // 
            // digimonDeEvo5
            // 
            digimonDeEvo5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            digimonDeEvo5.AutoSize = true;
            digimonDeEvo5.Location = new Point(3, 169);
            digimonDeEvo5.Name = "digimonDeEvo5";
            digimonDeEvo5.SelectedDigimon = null;
            digimonDeEvo5.Size = new Size(220, 28);
            digimonDeEvo5.TabIndex = 2;
            digimonDeEvo5.SelectedDigimonChanged += digimonDeEvo_SelectedDigimonChanged;
            digimonDeEvo5.JumpToSelectedDigimon += jumpToSelectedDigimon;
            // 
            // digimonDeEvo6
            // 
            digimonDeEvo6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            digimonDeEvo6.AutoSize = true;
            digimonDeEvo6.Location = new Point(3, 203);
            digimonDeEvo6.Name = "digimonDeEvo6";
            digimonDeEvo6.SelectedDigimon = null;
            digimonDeEvo6.Size = new Size(220, 28);
            digimonDeEvo6.TabIndex = 2;
            digimonDeEvo6.SelectedDigimonChanged += digimonDeEvo_SelectedDigimonChanged;
            digimonDeEvo6.JumpToSelectedDigimon += jumpToSelectedDigimon;
            // 
            // digimonDeEvo7
            // 
            digimonDeEvo7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            digimonDeEvo7.AutoSize = true;
            digimonDeEvo7.Location = new Point(3, 237);
            digimonDeEvo7.Name = "digimonDeEvo7";
            digimonDeEvo7.SelectedDigimon = null;
            digimonDeEvo7.Size = new Size(220, 28);
            digimonDeEvo7.TabIndex = 2;
            digimonDeEvo7.SelectedDigimonChanged += digimonDeEvo_SelectedDigimonChanged;
            digimonDeEvo7.JumpToSelectedDigimon += jumpToSelectedDigimon;
            // 
            // digimonDeEvo8
            // 
            digimonDeEvo8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            digimonDeEvo8.AutoSize = true;
            digimonDeEvo8.Location = new Point(3, 271);
            digimonDeEvo8.Name = "digimonDeEvo8";
            digimonDeEvo8.SelectedDigimon = null;
            digimonDeEvo8.Size = new Size(220, 28);
            digimonDeEvo8.TabIndex = 2;
            digimonDeEvo8.SelectedDigimonChanged += digimonDeEvo_SelectedDigimonChanged;
            digimonDeEvo8.JumpToSelectedDigimon += jumpToSelectedDigimon;
            // 
            // digimonDeEvo9
            // 
            digimonDeEvo9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            digimonDeEvo9.AutoSize = true;
            digimonDeEvo9.Location = new Point(3, 305);
            digimonDeEvo9.Name = "digimonDeEvo9";
            digimonDeEvo9.SelectedDigimon = null;
            digimonDeEvo9.Size = new Size(220, 28);
            digimonDeEvo9.TabIndex = 2;
            digimonDeEvo9.SelectedDigimonChanged += digimonDeEvo_SelectedDigimonChanged;
            digimonDeEvo9.JumpToSelectedDigimon += jumpToSelectedDigimon;
            // 
            // digimonDeEvo10
            // 
            digimonDeEvo10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            digimonDeEvo10.AutoSize = true;
            digimonDeEvo10.Location = new Point(3, 339);
            digimonDeEvo10.Name = "digimonDeEvo10";
            digimonDeEvo10.SelectedDigimon = null;
            digimonDeEvo10.Size = new Size(220, 28);
            digimonDeEvo10.TabIndex = 2;
            digimonDeEvo10.SelectedDigimonChanged += digimonDeEvo_SelectedDigimonChanged;
            digimonDeEvo10.JumpToSelectedDigimon += jumpToSelectedDigimon;
            // 
            // digimonDeEvo11
            // 
            digimonDeEvo11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            digimonDeEvo11.AutoSize = true;
            digimonDeEvo11.Location = new Point(3, 373);
            digimonDeEvo11.Name = "digimonDeEvo11";
            digimonDeEvo11.SelectedDigimon = null;
            digimonDeEvo11.Size = new Size(220, 28);
            digimonDeEvo11.TabIndex = 2;
            digimonDeEvo11.SelectedDigimonChanged += digimonDeEvo_SelectedDigimonChanged;
            digimonDeEvo11.JumpToSelectedDigimon += jumpToSelectedDigimon;
            // 
            // digimonEvo1
            // 
            digimonEvo1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            digimonEvo1.AutoSize = true;
            digimonEvo1.Location = new Point(279, 33);
            digimonEvo1.Name = "digimonEvo1";
            digimonEvo1.SelectedDigimon = null;
            digimonEvo1.Size = new Size(222, 28);
            digimonEvo1.TabIndex = 2;
            digimonEvo1.SelectedDigimonChanged += digimonEvo_SelectedDigimonChanged;
            digimonEvo1.JumpToSelectedDigimon += jumpToSelectedDigimon;
            // 
            // digimonEvo2
            // 
            digimonEvo2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            digimonEvo2.AutoSize = true;
            digimonEvo2.Location = new Point(279, 67);
            digimonEvo2.Name = "digimonEvo2";
            digimonEvo2.SelectedDigimon = null;
            digimonEvo2.Size = new Size(222, 28);
            digimonEvo2.TabIndex = 2;
            digimonEvo2.SelectedDigimonChanged += digimonEvo_SelectedDigimonChanged;
            digimonEvo2.JumpToSelectedDigimon += jumpToSelectedDigimon;
            // 
            // digimonEvo3
            // 
            digimonEvo3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            digimonEvo3.AutoSize = true;
            digimonEvo3.Location = new Point(279, 101);
            digimonEvo3.Name = "digimonEvo3";
            digimonEvo3.SelectedDigimon = null;
            digimonEvo3.Size = new Size(222, 28);
            digimonEvo3.TabIndex = 2;
            digimonEvo3.SelectedDigimonChanged += digimonEvo_SelectedDigimonChanged;
            digimonEvo3.JumpToSelectedDigimon += jumpToSelectedDigimon;
            // 
            // digimonEvo4
            // 
            digimonEvo4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            digimonEvo4.AutoSize = true;
            digimonEvo4.Location = new Point(279, 135);
            digimonEvo4.Name = "digimonEvo4";
            digimonEvo4.SelectedDigimon = null;
            digimonEvo4.Size = new Size(222, 28);
            digimonEvo4.TabIndex = 2;
            digimonEvo4.SelectedDigimonChanged += digimonEvo_SelectedDigimonChanged;
            digimonEvo4.JumpToSelectedDigimon += jumpToSelectedDigimon;
            // 
            // digimonEvo5
            // 
            digimonEvo5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            digimonEvo5.AutoSize = true;
            digimonEvo5.Location = new Point(279, 169);
            digimonEvo5.Name = "digimonEvo5";
            digimonEvo5.SelectedDigimon = null;
            digimonEvo5.Size = new Size(222, 28);
            digimonEvo5.TabIndex = 2;
            digimonEvo5.SelectedDigimonChanged += digimonEvo_SelectedDigimonChanged;
            digimonEvo5.JumpToSelectedDigimon += jumpToSelectedDigimon;
            // 
            // digimonEvo6
            // 
            digimonEvo6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            digimonEvo6.AutoSize = true;
            digimonEvo6.Location = new Point(279, 203);
            digimonEvo6.Name = "digimonEvo6";
            digimonEvo6.SelectedDigimon = null;
            digimonEvo6.Size = new Size(222, 28);
            digimonEvo6.TabIndex = 2;
            digimonEvo6.SelectedDigimonChanged += digimonEvo_SelectedDigimonChanged;
            digimonEvo6.JumpToSelectedDigimon += jumpToSelectedDigimon;
            // 
            // digimonEvo7
            // 
            digimonEvo7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            digimonEvo7.AutoSize = true;
            digimonEvo7.Location = new Point(279, 237);
            digimonEvo7.Name = "digimonEvo7";
            digimonEvo7.SelectedDigimon = null;
            digimonEvo7.Size = new Size(222, 28);
            digimonEvo7.TabIndex = 2;
            digimonEvo7.SelectedDigimonChanged += digimonEvo_SelectedDigimonChanged;
            digimonEvo7.JumpToSelectedDigimon += jumpToSelectedDigimon;
            // 
            // digimonEvo8
            // 
            digimonEvo8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            digimonEvo8.AutoSize = true;
            digimonEvo8.Location = new Point(279, 271);
            digimonEvo8.Name = "digimonEvo8";
            digimonEvo8.SelectedDigimon = null;
            digimonEvo8.Size = new Size(222, 28);
            digimonEvo8.TabIndex = 2;
            digimonEvo8.SelectedDigimonChanged += digimonEvo_SelectedDigimonChanged;
            digimonEvo8.JumpToSelectedDigimon += jumpToSelectedDigimon;
            // 
            // digimonEvo9
            // 
            digimonEvo9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            digimonEvo9.AutoSize = true;
            digimonEvo9.Location = new Point(279, 305);
            digimonEvo9.Name = "digimonEvo9";
            digimonEvo9.SelectedDigimon = null;
            digimonEvo9.Size = new Size(222, 28);
            digimonEvo9.TabIndex = 2;
            digimonEvo9.SelectedDigimonChanged += digimonEvo_SelectedDigimonChanged;
            digimonEvo9.JumpToSelectedDigimon += jumpToSelectedDigimon;
            // 
            // digimonEvo10
            // 
            digimonEvo10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            digimonEvo10.AutoSize = true;
            digimonEvo10.Location = new Point(279, 339);
            digimonEvo10.Name = "digimonEvo10";
            digimonEvo10.SelectedDigimon = null;
            digimonEvo10.Size = new Size(222, 28);
            digimonEvo10.TabIndex = 2;
            digimonEvo10.SelectedDigimonChanged += digimonEvo_SelectedDigimonChanged;
            digimonEvo10.JumpToSelectedDigimon += jumpToSelectedDigimon;
            // 
            // digimonEvo11
            // 
            digimonEvo11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            digimonEvo11.AutoSize = true;
            digimonEvo11.Location = new Point(279, 373);
            digimonEvo11.Name = "digimonEvo11";
            digimonEvo11.SelectedDigimon = null;
            digimonEvo11.Size = new Size(222, 28);
            digimonEvo11.TabIndex = 2;
            digimonEvo11.SelectedDigimonChanged += digimonEvo_SelectedDigimonChanged;
            digimonEvo11.JumpToSelectedDigimon += jumpToSelectedDigimon;
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
            logBox.Size = new Size(909, 110);
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
            ClientSize = new Size(909, 642);
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
            digimonDataPanel.PerformLayout();
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
        private DigimonEvolutionOption digimonDeEvo1;
        private DigimonEvolutionOption digimonDeEvo2;
        private DigimonEvolutionOption digimonDeEvo3;
        private DigimonEvolutionOption digimonDeEvo4;
        private DigimonEvolutionOption digimonDeEvo5;
        private DigimonEvolutionOption digimonDeEvo6;
        private DigimonEvolutionOption digimonDeEvo7;
        private DigimonEvolutionOption digimonDeEvo8;
        private DigimonEvolutionOption digimonDeEvo9;
        private DigimonEvolutionOption digimonDeEvo10;
        private DigimonEvolutionOption digimonDeEvo11;
        private DigimonEvolutionOption digimonEvo1;
        private DigimonEvolutionOption digimonEvo2;
        private DigimonEvolutionOption digimonEvo3;
        private DigimonEvolutionOption digimonEvo4;
        private DigimonEvolutionOption digimonEvo5;
        private DigimonEvolutionOption digimonEvo6;
        private DigimonEvolutionOption digimonEvo7;
        private DigimonEvolutionOption digimonEvo8;
        private DigimonEvolutionOption digimonEvo9;
        private DigimonEvolutionOption digimonEvo10;
        private DigimonEvolutionOption digimonEvo11;
        private Button selectAllMods;
    }
}
