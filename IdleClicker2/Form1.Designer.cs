namespace IdleClicker2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGetGold = new System.Windows.Forms.Button();
            this.lblGoldAmt = new System.Windows.Forms.Label();
            this.lblGoldPerClick = new System.Windows.Forms.Label();
            this.btnUpgradeClick = new System.Windows.Forms.Button();
            this.lblCostToUpgrade = new System.Windows.Forms.Label();
            this.timerAutoRefresh = new System.Windows.Forms.Timer(this.components);
            this.btnAutoClicker = new System.Windows.Forms.Button();
            this.lblAutoCost = new System.Windows.Forms.Label();
            this.btnMulti1 = new System.Windows.Forms.Button();
            this.lblMulti1 = new System.Windows.Forms.Label();
            this.timerUpgradeCheck = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picDrill = new System.Windows.Forms.PictureBox();
            this.lblDrillGoldSec = new System.Windows.Forms.Label();
            this.lblDrillCost = new System.Windows.Forms.Label();
            this.lblDrillQTY = new System.Windows.Forms.Label();
            this.btnBuyDrill = new System.Windows.Forms.Button();
            this.lbl49goldsec = new System.Windows.Forms.Label();
            this.pic49er = new System.Windows.Forms.PictureBox();
            this.lbl49erCost = new System.Windows.Forms.Label();
            this.lbl49erAmt = new System.Windows.Forms.Label();
            this.btnBuy49er = new System.Windows.Forms.Button();
            this.timerExtraGold = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGeneratorTotal = new System.Windows.Forms.Label();
            this.lblTotalGoldSec = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDrill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic49er)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetGold
            // 
            this.btnGetGold.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGetGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetGold.Image = ((System.Drawing.Image)(resources.GetObject("btnGetGold.Image")));
            this.btnGetGold.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnGetGold.Location = new System.Drawing.Point(195, 59);
            this.btnGetGold.Name = "btnGetGold";
            this.btnGetGold.Size = new System.Drawing.Size(84, 57);
            this.btnGetGold.TabIndex = 0;
            this.btnGetGold.Text = "Mine Gold!";
            this.btnGetGold.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetGold.UseVisualStyleBackColor = true;
            this.btnGetGold.Click += new System.EventHandler(this.btnGetGold_Click);
            // 
            // lblGoldAmt
            // 
            this.lblGoldAmt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGoldAmt.AutoSize = true;
            this.lblGoldAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoldAmt.Location = new System.Drawing.Point(202, 32);
            this.lblGoldAmt.Name = "lblGoldAmt";
            this.lblGoldAmt.Size = new System.Drawing.Size(105, 24);
            this.lblGoldAmt.TabIndex = 1;
            this.lblGoldAmt.Text = "Gold: 0.00";
            // 
            // lblGoldPerClick
            // 
            this.lblGoldPerClick.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGoldPerClick.AutoSize = true;
            this.lblGoldPerClick.Location = new System.Drawing.Point(297, 81);
            this.lblGoldPerClick.Name = "lblGoldPerClick";
            this.lblGoldPerClick.Size = new System.Drawing.Size(84, 13);
            this.lblGoldPerClick.TabIndex = 2;
            this.lblGoldPerClick.Text = "Gold per click: 1";
            // 
            // btnUpgradeClick
            // 
            this.btnUpgradeClick.Location = new System.Drawing.Point(12, 34);
            this.btnUpgradeClick.Name = "btnUpgradeClick";
            this.btnUpgradeClick.Size = new System.Drawing.Size(69, 43);
            this.btnUpgradeClick.TabIndex = 3;
            this.btnUpgradeClick.Text = "Upgrade Click";
            this.btnUpgradeClick.UseVisualStyleBackColor = true;
            this.btnUpgradeClick.Click += new System.EventHandler(this.btnUpgradeClick_Click);
            // 
            // lblCostToUpgrade
            // 
            this.lblCostToUpgrade.AutoSize = true;
            this.lblCostToUpgrade.Location = new System.Drawing.Point(11, 80);
            this.lblCostToUpgrade.Name = "lblCostToUpgrade";
            this.lblCostToUpgrade.Size = new System.Drawing.Size(108, 13);
            this.lblCostToUpgrade.TabIndex = 4;
            this.lblCostToUpgrade.Text = "Cost to Upgrade: 200";
            // 
            // timerAutoRefresh
            // 
            this.timerAutoRefresh.Enabled = true;
            this.timerAutoRefresh.Interval = 1000;
            this.timerAutoRefresh.Tick += new System.EventHandler(this.timerAutoRefresh_Tick);
            // 
            // btnAutoClicker
            // 
            this.btnAutoClicker.Location = new System.Drawing.Point(12, 122);
            this.btnAutoClicker.Name = "btnAutoClicker";
            this.btnAutoClicker.Size = new System.Drawing.Size(69, 45);
            this.btnAutoClicker.TabIndex = 5;
            this.btnAutoClicker.Text = "Buy Auto Clicker";
            this.btnAutoClicker.UseVisualStyleBackColor = true;
            this.btnAutoClicker.Click += new System.EventHandler(this.btnAutoClicker_Click);
            // 
            // lblAutoCost
            // 
            this.lblAutoCost.AutoSize = true;
            this.lblAutoCost.Location = new System.Drawing.Point(14, 174);
            this.lblAutoCost.Name = "lblAutoCost";
            this.lblAutoCost.Size = new System.Drawing.Size(118, 13);
            this.lblAutoCost.TabIndex = 6;
            this.lblAutoCost.Text = "Cost of Auto Clicker: 30";
            // 
            // btnMulti1
            // 
            this.btnMulti1.Location = new System.Drawing.Point(12, 205);
            this.btnMulti1.Name = "btnMulti1";
            this.btnMulti1.Size = new System.Drawing.Size(69, 43);
            this.btnMulti1.TabIndex = 7;
            this.btnMulti1.Text = "Buy Multiplyer 1";
            this.btnMulti1.UseVisualStyleBackColor = true;
            this.btnMulti1.Click += new System.EventHandler(this.btnMulti1_Click);
            // 
            // lblMulti1
            // 
            this.lblMulti1.AutoSize = true;
            this.lblMulti1.Location = new System.Drawing.Point(17, 255);
            this.lblMulti1.Name = "lblMulti1";
            this.lblMulti1.Size = new System.Drawing.Size(78, 13);
            this.lblMulti1.TabIndex = 8;
            this.lblMulti1.Text = "Cost to buy: 50";
            // 
            // timerUpgradeCheck
            // 
            this.timerUpgradeCheck.Enabled = true;
            this.timerUpgradeCheck.Interval = 50;
            this.timerUpgradeCheck.Tick += new System.EventHandler(this.timerUpgradeCheck_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.picDrill);
            this.groupBox1.Controls.Add(this.lblDrillGoldSec);
            this.groupBox1.Controls.Add(this.lblDrillCost);
            this.groupBox1.Controls.Add(this.lblDrillQTY);
            this.groupBox1.Controls.Add(this.btnBuyDrill);
            this.groupBox1.Controls.Add(this.lbl49goldsec);
            this.groupBox1.Controls.Add(this.pic49er);
            this.groupBox1.Controls.Add(this.lbl49erCost);
            this.groupBox1.Controls.Add(this.lbl49erAmt);
            this.groupBox1.Controls.Add(this.btnBuy49er);
            this.groupBox1.Location = new System.Drawing.Point(409, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 475);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto Generators";
            // 
            // picDrill
            // 
            this.picDrill.Image = ((System.Drawing.Image)(resources.GetObject("picDrill.Image")));
            this.picDrill.Location = new System.Drawing.Point(8, 183);
            this.picDrill.Name = "picDrill";
            this.picDrill.Size = new System.Drawing.Size(53, 63);
            this.picDrill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDrill.TabIndex = 9;
            this.picDrill.TabStop = false;
            // 
            // lblDrillGoldSec
            // 
            this.lblDrillGoldSec.AutoSize = true;
            this.lblDrillGoldSec.Location = new System.Drawing.Point(67, 207);
            this.lblDrillGoldSec.Name = "lblDrillGoldSec";
            this.lblDrillGoldSec.Size = new System.Drawing.Size(129, 13);
            this.lblDrillGoldSec.TabIndex = 8;
            this.lblDrillGoldSec.Text = "Drills collect: 25 gold/sec.";
            // 
            // lblDrillCost
            // 
            this.lblDrillCost.AutoSize = true;
            this.lblDrillCost.Location = new System.Drawing.Point(8, 167);
            this.lblDrillCost.Name = "lblDrillCost";
            this.lblDrillCost.Size = new System.Drawing.Size(84, 13);
            this.lblDrillCost.TabIndex = 7;
            this.lblDrillCost.Text = "Cost of Drill: 250";
            // 
            // lblDrillQTY
            // 
            this.lblDrillQTY.AutoSize = true;
            this.lblDrillQTY.Location = new System.Drawing.Point(87, 142);
            this.lblDrillQTY.Name = "lblDrillQTY";
            this.lblDrillQTY.Size = new System.Drawing.Size(65, 13);
            this.lblDrillQTY.TabIndex = 6;
            this.lblDrillQTY.Text = "You have: 0";
            // 
            // btnBuyDrill
            // 
            this.btnBuyDrill.Location = new System.Drawing.Point(7, 137);
            this.btnBuyDrill.Name = "btnBuyDrill";
            this.btnBuyDrill.Size = new System.Drawing.Size(75, 23);
            this.btnBuyDrill.TabIndex = 5;
            this.btnBuyDrill.Text = "Buy Drill";
            this.btnBuyDrill.UseVisualStyleBackColor = true;
            this.btnBuyDrill.Click += new System.EventHandler(this.btnBuyDrill_Click);
            // 
            // lbl49goldsec
            // 
            this.lbl49goldsec.AutoSize = true;
            this.lbl49goldsec.Location = new System.Drawing.Point(68, 85);
            this.lbl49goldsec.Name = "lbl49goldsec";
            this.lbl49goldsec.Size = new System.Drawing.Size(135, 13);
            this.lbl49goldsec.TabIndex = 4;
            this.lbl49goldsec.Text = "49\'ers collect: 10 gold/sec.";
            // 
            // pic49er
            // 
            this.pic49er.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic49er.Image = ((System.Drawing.Image)(resources.GetObject("pic49er.Image")));
            this.pic49er.Location = new System.Drawing.Point(8, 65);
            this.pic49er.Name = "pic49er";
            this.pic49er.Size = new System.Drawing.Size(53, 63);
            this.pic49er.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic49er.TabIndex = 3;
            this.pic49er.TabStop = false;
            // 
            // lbl49erCost
            // 
            this.lbl49erCost.AutoSize = true;
            this.lbl49erCost.Location = new System.Drawing.Point(5, 48);
            this.lbl49erCost.Name = "lbl49erCost";
            this.lbl49erCost.Size = new System.Drawing.Size(90, 13);
            this.lbl49erCost.TabIndex = 2;
            this.lbl49erCost.Text = "Cost of 49\'er: 100";
            // 
            // lbl49erAmt
            // 
            this.lbl49erAmt.AutoSize = true;
            this.lbl49erAmt.Location = new System.Drawing.Point(87, 27);
            this.lbl49erAmt.Name = "lbl49erAmt";
            this.lbl49erAmt.Size = new System.Drawing.Size(65, 13);
            this.lbl49erAmt.TabIndex = 1;
            this.lbl49erAmt.Text = "You have: 0";
            // 
            // btnBuy49er
            // 
            this.btnBuy49er.Location = new System.Drawing.Point(6, 22);
            this.btnBuy49er.Name = "btnBuy49er";
            this.btnBuy49er.Size = new System.Drawing.Size(75, 23);
            this.btnBuy49er.TabIndex = 0;
            this.btnBuy49er.Text = "Buy 49\'er";
            this.btnBuy49er.UseVisualStyleBackColor = true;
            this.btnBuy49er.Click += new System.EventHandler(this.btnBuy49er_Click);
            // 
            // timerExtraGold
            // 
            this.timerExtraGold.Interval = 1000;
            this.timerExtraGold.Tick += new System.EventHandler(this.timerExtraGold_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(709, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblGeneratorTotal
            // 
            this.lblGeneratorTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGeneratorTotal.AutoSize = true;
            this.lblGeneratorTotal.Location = new System.Drawing.Point(161, 138);
            this.lblGeneratorTotal.Name = "lblGeneratorTotal";
            this.lblGeneratorTotal.Size = new System.Drawing.Size(178, 13);
            this.lblGeneratorTotal.TabIndex = 11;
            this.lblGeneratorTotal.Text = "Generators are creating: 0 gold/sec.";
            // 
            // lblTotalGoldSec
            // 
            this.lblTotalGoldSec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotalGoldSec.AutoSize = true;
            this.lblTotalGoldSec.Location = new System.Drawing.Point(161, 154);
            this.lblTotalGoldSec.Name = "lblTotalGoldSec";
            this.lblTotalGoldSec.Size = new System.Drawing.Size(191, 13);
            this.lblTotalGoldSec.TabIndex = 12;
            this.lblTotalGoldSec.Text = "Total gold being produced: 0 gold/sec.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 537);
            this.Controls.Add(this.lblTotalGoldSec);
            this.Controls.Add(this.lblGeneratorTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMulti1);
            this.Controls.Add(this.btnMulti1);
            this.Controls.Add(this.lblAutoCost);
            this.Controls.Add(this.btnAutoClicker);
            this.Controls.Add(this.lblCostToUpgrade);
            this.Controls.Add(this.btnUpgradeClick);
            this.Controls.Add(this.lblGoldPerClick);
            this.Controls.Add(this.lblGoldAmt);
            this.Controls.Add(this.btnGetGold);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(725, 575);
            this.Name = "Form1";
            this.Text = "Idle Clicker v0.0.07";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDrill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic49er)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetGold;
        private System.Windows.Forms.Label lblGoldAmt;
        private System.Windows.Forms.Label lblGoldPerClick;
        private System.Windows.Forms.Button btnUpgradeClick;
        private System.Windows.Forms.Label lblCostToUpgrade;
        private System.Windows.Forms.Timer timerAutoRefresh;
        private System.Windows.Forms.Button btnAutoClicker;
        private System.Windows.Forms.Label lblAutoCost;
        private System.Windows.Forms.Button btnMulti1;
        private System.Windows.Forms.Label lblMulti1;
        private System.Windows.Forms.Timer timerUpgradeCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl49erCost;
        private System.Windows.Forms.Label lbl49erAmt;
        private System.Windows.Forms.Button btnBuy49er;
        private System.Windows.Forms.Timer timerExtraGold;
        private System.Windows.Forms.PictureBox pic49er;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblDrillCost;
        private System.Windows.Forms.Label lblDrillQTY;
        private System.Windows.Forms.Button btnBuyDrill;
        private System.Windows.Forms.Label lbl49goldsec;
        private System.Windows.Forms.Label lblDrillGoldSec;
        private System.Windows.Forms.Label lblGeneratorTotal;
        private System.Windows.Forms.Label lblTotalGoldSec;
        private System.Windows.Forms.PictureBox picDrill;
    }
}

