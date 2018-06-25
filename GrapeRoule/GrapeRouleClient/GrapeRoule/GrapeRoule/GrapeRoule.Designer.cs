namespace WalletPage
{
    partial class GrapeRoule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrapeRoule));
            this.upperPanel = new System.Windows.Forms.Panel();
            this.movableIndicationPanel = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.WalletMenuBtn = new System.Windows.Forms.Button();
            this.RouletteMenuBtn = new System.Windows.Forms.Button();
            this.HomeMenuBtn = new System.Windows.Forms.Button();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.roulette_Page = new RoulettPage.Roulette_Page();
            this.home_Page = new HomePage.Home_Page();
            this.wallet_Page = new WalletPage.Wallet_Page();
            this.upperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // upperPanel
            // 
            this.upperPanel.AutoSize = true;
            this.upperPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.upperPanel.Controls.Add(this.movableIndicationPanel);
            this.upperPanel.Controls.Add(this.ExitBtn);
            this.upperPanel.Controls.Add(this.WalletMenuBtn);
            this.upperPanel.Controls.Add(this.RouletteMenuBtn);
            this.upperPanel.Controls.Add(this.HomeMenuBtn);
            this.upperPanel.Controls.Add(this.logoBox);
            this.upperPanel.Location = new System.Drawing.Point(0, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(1190, 115);
            this.upperPanel.TabIndex = 0;
            this.upperPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpperPanelMouseDown);
            this.upperPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpperPanelMouseMove);
            // 
            // movableIndicationPanel
            // 
            this.movableIndicationPanel.BackColor = System.Drawing.Color.Azure;
            this.movableIndicationPanel.Location = new System.Drawing.Point(137, 0);
            this.movableIndicationPanel.Name = "movableIndicationPanel";
            this.movableIndicationPanel.Size = new System.Drawing.Size(151, 16);
            this.movableIndicationPanel.TabIndex = 1;
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ExitBtn.Location = new System.Drawing.Point(1027, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(151, 109);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "EXIT";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // WalletMenuBtn
            // 
            this.WalletMenuBtn.FlatAppearance.BorderSize = 0;
            this.WalletMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WalletMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WalletMenuBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.WalletMenuBtn.Location = new System.Drawing.Point(451, 0);
            this.WalletMenuBtn.Name = "WalletMenuBtn";
            this.WalletMenuBtn.Size = new System.Drawing.Size(151, 109);
            this.WalletMenuBtn.TabIndex = 4;
            this.WalletMenuBtn.Text = "WALLET";
            this.WalletMenuBtn.UseVisualStyleBackColor = true;
            this.WalletMenuBtn.Click += new System.EventHandler(this.WalletMenuBtn_Click);
            // 
            // RouletteMenuBtn
            // 
            this.RouletteMenuBtn.FlatAppearance.BorderSize = 0;
            this.RouletteMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RouletteMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RouletteMenuBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.RouletteMenuBtn.Location = new System.Drawing.Point(294, 0);
            this.RouletteMenuBtn.Name = "RouletteMenuBtn";
            this.RouletteMenuBtn.Size = new System.Drawing.Size(151, 109);
            this.RouletteMenuBtn.TabIndex = 3;
            this.RouletteMenuBtn.Text = "ROULETTE";
            this.RouletteMenuBtn.UseVisualStyleBackColor = true;
            this.RouletteMenuBtn.Click += new System.EventHandler(this.RouletteMenuBtn_Click);
            // 
            // HomeMenuBtn
            // 
            this.HomeMenuBtn.FlatAppearance.BorderSize = 0;
            this.HomeMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HomeMenuBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.HomeMenuBtn.Location = new System.Drawing.Point(137, 0);
            this.HomeMenuBtn.Name = "HomeMenuBtn";
            this.HomeMenuBtn.Size = new System.Drawing.Size(151, 109);
            this.HomeMenuBtn.TabIndex = 2;
            this.HomeMenuBtn.Text = "HOME";
            this.HomeMenuBtn.UseVisualStyleBackColor = true;
            this.HomeMenuBtn.Click += new System.EventHandler(this.HomeMenuBtn_Click);
            // 
            // logoBox
            // 
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(0, 0);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(131, 112);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox.TabIndex = 1;
            this.logoBox.TabStop = false;
            this.logoBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogoBoxMouseDown);
            this.logoBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LogoPanelMouseMove);
            // 
            // roulette_Page
            // 
            this.roulette_Page.Location = new System.Drawing.Point(0, 111);
            this.roulette_Page.Name = "roulette_Page";
            this.roulette_Page.Size = new System.Drawing.Size(1190, 440);
            this.roulette_Page.TabIndex = 3;
            this.roulette_Page.Load += new System.EventHandler(this.roulette_Page_Load);
            // 
            // home_Page
            // 
            this.home_Page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home_Page.BackgroundImage")));
            this.home_Page.Location = new System.Drawing.Point(0, 111);
            this.home_Page.Name = "home_Page";
            this.home_Page.Size = new System.Drawing.Size(1190, 440);
            this.home_Page.TabIndex = 2;
            // 
            // wallet_Page
            // 
            this.wallet_Page.Location = new System.Drawing.Point(0, 111);
            this.wallet_Page.Name = "wallet_Page";
            this.wallet_Page.Size = new System.Drawing.Size(1190, 440);
            this.wallet_Page.TabIndex = 1;
            // 
            // GrapeRoule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1190, 552);
            this.Controls.Add(this.roulette_Page);
            this.Controls.Add(this.home_Page);
            this.Controls.Add(this.wallet_Page);
            this.Controls.Add(this.upperPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GrapeRoule";
            this.Text = "WalletPage";
            this.upperPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Button HomeMenuBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button WalletMenuBtn;
        private System.Windows.Forms.Button RouletteMenuBtn;
        private System.Windows.Forms.Panel movableIndicationPanel;
        private Wallet_Page wallet_Page;
        private HomePage.Home_Page home_Page;
        private RoulettPage.Roulette_Page roulette_Page;
    }
}

