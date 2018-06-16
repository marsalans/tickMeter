namespace tickMeterRecode
{
    partial class tickMeterForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tickMeterForm));
            this.panelBackground = new System.Windows.Forms.Panel();
            this.labelCountry = new System.Windows.Forms.Label();
            this.dropdownCover = new ns1.BunifuDropdown();
            this.pingLabel = new System.Windows.Forms.Label();
            this.updlLabel = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.tickrateLabel = new System.Windows.Forms.Label();
            this.labelUPDL = new ns1.BunifuCustomLabel();
            this.labelPing = new ns1.BunifuCustomLabel();
            this.labelIP = new ns1.BunifuCustomLabel();
            this.labelTickrate = new ns1.BunifuCustomLabel();
            this.labelLanguage = new ns1.BunifuCustomLabel();
            this.dropdownLanguage = new ns1.BunifuDropdown();
            this.labelNetworkCard = new ns1.BunifuCustomLabel();
            this.dropdownNetworkCard = new ns1.BunifuDropdown();
            this.checkboxRTSS = new ns1.BunifuCheckbox();
            this.labelTraffic = new ns1.BunifuCustomLabel();
            this.checkboxTraffic = new ns1.BunifuCheckbox();
            this.labelPingRegion = new ns1.BunifuCustomLabel();
            this.checkboxPingRegion = new ns1.BunifuCheckbox();
            this.labelServerIP = new ns1.BunifuCustomLabel();
            this.checkboxServerIP = new ns1.BunifuCheckbox();
            this.labelLogging = new ns1.BunifuCustomLabel();
            this.checkboxLogging = new ns1.BunifuCheckbox();
            this.labelRTSS = new ns1.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelStatus = new ns1.BunifuCustomLabel();
            this.bunifuSeparator1 = new ns1.BunifuSeparator();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.pictureboxExit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitle = new ns1.BunifuCustomLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.labelUpdate = new ns1.BunifuCustomLabel();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.panelBackground.Controls.Add(this.labelCountry);
            this.panelBackground.Controls.Add(this.dropdownCover);
            this.panelBackground.Controls.Add(this.pingLabel);
            this.panelBackground.Controls.Add(this.updlLabel);
            this.panelBackground.Controls.Add(this.ipLabel);
            this.panelBackground.Controls.Add(this.tickrateLabel);
            this.panelBackground.Controls.Add(this.labelUPDL);
            this.panelBackground.Controls.Add(this.labelPing);
            this.panelBackground.Controls.Add(this.labelIP);
            this.panelBackground.Controls.Add(this.labelTickrate);
            this.panelBackground.Controls.Add(this.labelLanguage);
            this.panelBackground.Controls.Add(this.dropdownLanguage);
            this.panelBackground.Controls.Add(this.labelNetworkCard);
            this.panelBackground.Controls.Add(this.dropdownNetworkCard);
            this.panelBackground.Controls.Add(this.checkboxRTSS);
            this.panelBackground.Controls.Add(this.labelTraffic);
            this.panelBackground.Controls.Add(this.checkboxTraffic);
            this.panelBackground.Controls.Add(this.labelPingRegion);
            this.panelBackground.Controls.Add(this.checkboxPingRegion);
            this.panelBackground.Controls.Add(this.labelServerIP);
            this.panelBackground.Controls.Add(this.checkboxServerIP);
            this.panelBackground.Controls.Add(this.labelLogging);
            this.panelBackground.Controls.Add(this.checkboxLogging);
            this.panelBackground.Controls.Add(this.labelRTSS);
            this.panelBackground.Controls.Add(this.pictureBox2);
            this.panelBackground.Controls.Add(this.panel1);
            this.panelBackground.Controls.Add(this.bunifuSeparator1);
            this.panelBackground.Controls.Add(this.panelTitle);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(747, 356);
            this.panelBackground.TabIndex = 0;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(214, 253);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(13, 13);
            this.labelCountry.TabIndex = 36;
            this.labelCountry.Text = "0";
            this.labelCountry.Visible = false;
            // 
            // dropdownCover
            // 
            this.dropdownCover.BackColor = System.Drawing.Color.Transparent;
            this.dropdownCover.BorderRadius = 3;
            this.dropdownCover.Enabled = false;
            this.dropdownCover.ForeColor = System.Drawing.Color.White;
            this.dropdownCover.Items = new string[0];
            this.dropdownCover.Location = new System.Drawing.Point(492, 240);
            this.dropdownCover.Name = "dropdownCover";
            this.dropdownCover.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(157)))), ((int)(((byte)(29)))));
            this.dropdownCover.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(125)))), ((int)(((byte)(29)))));
            this.dropdownCover.selectedIndex = -1;
            this.dropdownCover.Size = new System.Drawing.Size(243, 26);
            this.dropdownCover.TabIndex = 35;
            this.dropdownCover.Visible = false;
            // 
            // pingLabel
            // 
            this.pingLabel.AutoSize = true;
            this.pingLabel.Location = new System.Drawing.Point(244, 175);
            this.pingLabel.Name = "pingLabel";
            this.pingLabel.Size = new System.Drawing.Size(29, 13);
            this.pingLabel.TabIndex = 34;
            this.pingLabel.Text = "0 ms";
            this.pingLabel.Visible = false;
            // 
            // updlLabel
            // 
            this.updlLabel.AutoSize = true;
            this.updlLabel.Location = new System.Drawing.Point(244, 203);
            this.updlLabel.Name = "updlLabel";
            this.updlLabel.Size = new System.Drawing.Size(79, 13);
            this.updlLabel.TabIndex = 33;
            this.updlLabel.Text = "0,00 / 0,00 MB";
            this.updlLabel.Visible = false;
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(187, 175);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(40, 13);
            this.ipLabel.TabIndex = 32;
            this.ipLabel.Text = "0.0.0.0";
            this.ipLabel.Visible = false;
            // 
            // tickrateLabel
            // 
            this.tickrateLabel.AutoSize = true;
            this.tickrateLabel.Location = new System.Drawing.Point(187, 203);
            this.tickrateLabel.Name = "tickrateLabel";
            this.tickrateLabel.Size = new System.Drawing.Size(13, 13);
            this.tickrateLabel.TabIndex = 31;
            this.tickrateLabel.Text = "0";
            this.tickrateLabel.Visible = false;
            // 
            // labelUPDL
            // 
            this.labelUPDL.AutoSize = true;
            this.labelUPDL.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.labelUPDL.ForeColor = System.Drawing.Color.White;
            this.labelUPDL.Location = new System.Drawing.Point(12, 287);
            this.labelUPDL.Name = "labelUPDL";
            this.labelUPDL.Size = new System.Drawing.Size(288, 21);
            this.labelUPDL.TabIndex = 30;
            this.labelUPDL.Text = "Feltöltés/Letöltés: 0,00 / 0,00 MB";
            // 
            // labelPing
            // 
            this.labelPing.AutoSize = true;
            this.labelPing.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.labelPing.ForeColor = System.Drawing.Color.White;
            this.labelPing.Location = new System.Drawing.Point(12, 257);
            this.labelPing.Name = "labelPing";
            this.labelPing.Size = new System.Drawing.Size(96, 21);
            this.labelPing.TabIndex = 29;
            this.labelPing.Text = "Ping: 0 ms";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.labelIP.ForeColor = System.Drawing.Color.White;
            this.labelIP.Location = new System.Drawing.Point(12, 227);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(128, 21);
            this.labelIP.TabIndex = 28;
            this.labelIP.Text = "IP cím: 0.0.0.0";
            // 
            // labelTickrate
            // 
            this.labelTickrate.AutoSize = true;
            this.labelTickrate.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.labelTickrate.ForeColor = System.Drawing.Color.White;
            this.labelTickrate.Location = new System.Drawing.Point(12, 197);
            this.labelTickrate.Name = "labelTickrate";
            this.labelTickrate.Size = new System.Drawing.Size(98, 21);
            this.labelTickrate.TabIndex = 27;
            this.labelTickrate.Text = "Tickrate: 0";
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelLanguage.ForeColor = System.Drawing.Color.White;
            this.labelLanguage.Location = new System.Drawing.Point(361, 272);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(57, 21);
            this.labelLanguage.TabIndex = 26;
            this.labelLanguage.Text = "Nyelv:";
            // 
            // dropdownLanguage
            // 
            this.dropdownLanguage.BackColor = System.Drawing.Color.Transparent;
            this.dropdownLanguage.BorderRadius = 3;
            this.dropdownLanguage.ForeColor = System.Drawing.Color.White;
            this.dropdownLanguage.Items = new string[] {
        "Magyar",
        "English"};
            this.dropdownLanguage.Location = new System.Drawing.Point(492, 272);
            this.dropdownLanguage.Name = "dropdownLanguage";
            this.dropdownLanguage.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(157)))), ((int)(((byte)(29)))));
            this.dropdownLanguage.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(125)))), ((int)(((byte)(29)))));
            this.dropdownLanguage.selectedIndex = 0;
            this.dropdownLanguage.Size = new System.Drawing.Size(243, 26);
            this.dropdownLanguage.TabIndex = 25;
            this.dropdownLanguage.onItemSelected += new System.EventHandler(this.dropdownLanguage_onItemSelected);
            // 
            // labelNetworkCard
            // 
            this.labelNetworkCard.AutoSize = true;
            this.labelNetworkCard.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelNetworkCard.ForeColor = System.Drawing.Color.White;
            this.labelNetworkCard.Location = new System.Drawing.Point(361, 240);
            this.labelNetworkCard.Name = "labelNetworkCard";
            this.labelNetworkCard.Size = new System.Drawing.Size(131, 21);
            this.labelNetworkCard.TabIndex = 24;
            this.labelNetworkCard.Text = "Hálózati kártya:";
            // 
            // dropdownNetworkCard
            // 
            this.dropdownNetworkCard.BackColor = System.Drawing.Color.Transparent;
            this.dropdownNetworkCard.BorderRadius = 3;
            this.dropdownNetworkCard.ForeColor = System.Drawing.Color.White;
            this.dropdownNetworkCard.Items = new string[0];
            this.dropdownNetworkCard.Location = new System.Drawing.Point(492, 240);
            this.dropdownNetworkCard.Name = "dropdownNetworkCard";
            this.dropdownNetworkCard.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(157)))), ((int)(((byte)(29)))));
            this.dropdownNetworkCard.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(125)))), ((int)(((byte)(29)))));
            this.dropdownNetworkCard.selectedIndex = -1;
            this.dropdownNetworkCard.Size = new System.Drawing.Size(243, 26);
            this.dropdownNetworkCard.TabIndex = 23;
            this.dropdownNetworkCard.onItemSelected += new System.EventHandler(this.dropdownNetworkCard_onItemSelected);
            // 
            // checkboxRTSS
            // 
            this.checkboxRTSS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(157)))), ((int)(((byte)(29)))));
            this.checkboxRTSS.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.checkboxRTSS.Checked = true;
            this.checkboxRTSS.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(157)))), ((int)(((byte)(29)))));
            this.checkboxRTSS.ForeColor = System.Drawing.Color.White;
            this.checkboxRTSS.Location = new System.Drawing.Point(365, 77);
            this.checkboxRTSS.Name = "checkboxRTSS";
            this.checkboxRTSS.Size = new System.Drawing.Size(20, 20);
            this.checkboxRTSS.TabIndex = 22;
            this.checkboxRTSS.OnChange += new System.EventHandler(this.checkboxRTSS_OnChange);
            // 
            // labelTraffic
            // 
            this.labelTraffic.AutoSize = true;
            this.labelTraffic.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelTraffic.ForeColor = System.Drawing.Color.White;
            this.labelTraffic.Location = new System.Drawing.Point(391, 197);
            this.labelTraffic.Name = "labelTraffic";
            this.labelTraffic.Size = new System.Drawing.Size(259, 21);
            this.labelTraffic.TabIndex = 17;
            this.labelTraffic.Text = "Hálózati forgalom megjelenítése";
            // 
            // checkboxTraffic
            // 
            this.checkboxTraffic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.checkboxTraffic.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.checkboxTraffic.Checked = false;
            this.checkboxTraffic.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(157)))), ((int)(((byte)(29)))));
            this.checkboxTraffic.ForeColor = System.Drawing.Color.White;
            this.checkboxTraffic.Location = new System.Drawing.Point(365, 198);
            this.checkboxTraffic.Name = "checkboxTraffic";
            this.checkboxTraffic.Size = new System.Drawing.Size(20, 20);
            this.checkboxTraffic.TabIndex = 16;
            // 
            // labelPingRegion
            // 
            this.labelPingRegion.AutoSize = true;
            this.labelPingRegion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelPingRegion.ForeColor = System.Drawing.Color.White;
            this.labelPingRegion.Location = new System.Drawing.Point(391, 167);
            this.labelPingRegion.Name = "labelPingRegion";
            this.labelPingRegion.Size = new System.Drawing.Size(279, 21);
            this.labelPingRegion.TabIndex = 15;
            this.labelPingRegion.Text = "Szerver ping és régió megjelenítése";
            // 
            // checkboxPingRegion
            // 
            this.checkboxPingRegion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(157)))), ((int)(((byte)(29)))));
            this.checkboxPingRegion.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.checkboxPingRegion.Checked = true;
            this.checkboxPingRegion.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(157)))), ((int)(((byte)(29)))));
            this.checkboxPingRegion.ForeColor = System.Drawing.Color.White;
            this.checkboxPingRegion.Location = new System.Drawing.Point(365, 168);
            this.checkboxPingRegion.Name = "checkboxPingRegion";
            this.checkboxPingRegion.Size = new System.Drawing.Size(20, 20);
            this.checkboxPingRegion.TabIndex = 14;
            // 
            // labelServerIP
            // 
            this.labelServerIP.AutoSize = true;
            this.labelServerIP.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelServerIP.ForeColor = System.Drawing.Color.White;
            this.labelServerIP.Location = new System.Drawing.Point(391, 137);
            this.labelServerIP.Name = "labelServerIP";
            this.labelServerIP.Size = new System.Drawing.Size(265, 21);
            this.labelServerIP.TabIndex = 13;
            this.labelServerIP.Text = "Szerver IP címének megjelenítése";
            // 
            // checkboxServerIP
            // 
            this.checkboxServerIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(157)))), ((int)(((byte)(29)))));
            this.checkboxServerIP.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.checkboxServerIP.Checked = true;
            this.checkboxServerIP.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(157)))), ((int)(((byte)(29)))));
            this.checkboxServerIP.ForeColor = System.Drawing.Color.White;
            this.checkboxServerIP.Location = new System.Drawing.Point(365, 138);
            this.checkboxServerIP.Name = "checkboxServerIP";
            this.checkboxServerIP.Size = new System.Drawing.Size(20, 20);
            this.checkboxServerIP.TabIndex = 12;
            // 
            // labelLogging
            // 
            this.labelLogging.AutoSize = true;
            this.labelLogging.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelLogging.ForeColor = System.Drawing.Color.White;
            this.labelLogging.Location = new System.Drawing.Point(391, 107);
            this.labelLogging.Name = "labelLogging";
            this.labelLogging.Size = new System.Drawing.Size(212, 21);
            this.labelLogging.TabIndex = 11;
            this.labelLogging.Text = "Logolás Excel fájlba (.CSV)";
            // 
            // checkboxLogging
            // 
            this.checkboxLogging.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.checkboxLogging.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.checkboxLogging.Checked = false;
            this.checkboxLogging.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(157)))), ((int)(((byte)(29)))));
            this.checkboxLogging.ForeColor = System.Drawing.Color.White;
            this.checkboxLogging.Location = new System.Drawing.Point(365, 108);
            this.checkboxLogging.Name = "checkboxLogging";
            this.checkboxLogging.Size = new System.Drawing.Size(20, 20);
            this.checkboxLogging.TabIndex = 10;
            // 
            // labelRTSS
            // 
            this.labelRTSS.AutoSize = true;
            this.labelRTSS.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelRTSS.ForeColor = System.Drawing.Color.White;
            this.labelRTSS.Location = new System.Drawing.Point(391, 77);
            this.labelRTSS.Name = "labelRTSS";
            this.labelRTSS.Size = new System.Drawing.Size(227, 21);
            this.labelRTSS.TabIndex = 9;
            this.labelRTSS.Text = "RivaTuner kimenet (overlay)";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(320, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Location = new System.Drawing.Point(0, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 25);
            this.panel1.TabIndex = 6;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(5, 4);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(313, 17);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Státusz: várakozás a hálózati kártya kiválasztására...";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(342, 50);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(15, 275);
            this.bunifuSeparator1.TabIndex = 5;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.panelTitle.Controls.Add(this.labelUpdate);
            this.panelTitle.Controls.Add(this.pictureboxExit);
            this.panelTitle.Controls.Add(this.pictureBox1);
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(747, 44);
            this.panelTitle.TabIndex = 0;
            this.panelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseMove);
            // 
            // pictureboxExit
            // 
            this.pictureboxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxExit.Image")));
            this.pictureboxExit.Location = new System.Drawing.Point(712, 4);
            this.pictureboxExit.Name = "pictureboxExit";
            this.pictureboxExit.Size = new System.Drawing.Size(30, 35);
            this.pictureboxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureboxExit.TabIndex = 2;
            this.pictureboxExit.TabStop = false;
            this.pictureboxExit.WaitOnLoad = true;
            this.pictureboxExit.Click += new System.EventHandler(this.pictureboxExit_Click);
            this.pictureboxExit.MouseEnter += new System.EventHandler(this.pictureboxExit_MouseEnter);
            this.pictureboxExit.MouseLeave += new System.EventHandler(this.pictureboxExit_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(64, 11);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(135, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "tickMeter - v1.2.3";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 5000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // labelUpdate
            // 
            this.labelUpdate.AutoSize = true;
            this.labelUpdate.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.labelUpdate.ForeColor = System.Drawing.Color.White;
            this.labelUpdate.Location = new System.Drawing.Point(195, 11);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(230, 20);
            this.labelUpdate.TabIndex = 3;
            this.labelUpdate.Text = "| Frissítés elérhető, kattints ide!";
            this.labelUpdate.Visible = false;
            this.labelUpdate.Click += new System.EventHandler(this.labelUpdate_Click);
            // 
            // tickMeterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 356);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tickMeterForm";
            this.Text = "PUBG tick- and ping meter";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.tickMeterForm_FormClosed);
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.PictureBox pictureboxExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuCustomLabel labelTitle;
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuCustomLabel labelStatus;
        private ns1.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ns1.BunifuCustomLabel labelRTSS;
        private ns1.BunifuCustomLabel labelTraffic;
        private ns1.BunifuCheckbox checkboxTraffic;
        private ns1.BunifuCustomLabel labelPingRegion;
        private ns1.BunifuCheckbox checkboxPingRegion;
        private ns1.BunifuCustomLabel labelServerIP;
        private ns1.BunifuCheckbox checkboxServerIP;
        private ns1.BunifuCustomLabel labelLogging;
        private ns1.BunifuCheckbox checkboxLogging;
        private ns1.BunifuCheckbox checkboxRTSS;
        private ns1.BunifuDropdown dropdownNetworkCard;
        private ns1.BunifuCustomLabel labelLanguage;
        private ns1.BunifuDropdown dropdownLanguage;
        private ns1.BunifuCustomLabel labelNetworkCard;
        private ns1.BunifuCustomLabel labelUPDL;
        private ns1.BunifuCustomLabel labelPing;
        private ns1.BunifuCustomLabel labelIP;
        private ns1.BunifuCustomLabel labelTickrate;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label pingLabel;
        private System.Windows.Forms.Label updlLabel;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Label tickrateLabel;
        private ns1.BunifuDropdown dropdownCover;
        private System.Windows.Forms.Label labelCountry;
        private ns1.BunifuCustomLabel labelUpdate;
    }
}

