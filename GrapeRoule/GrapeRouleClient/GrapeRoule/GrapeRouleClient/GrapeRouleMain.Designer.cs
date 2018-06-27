namespace GrapeRouleClient
{
    partial class GrapeRouleMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrapeRouleMain));
            this.upperPanel = new System.Windows.Forms.Panel();
            this.indicationPanel = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.walletBtn = new System.Windows.Forms.Button();
            this.rouletteBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.roulette_PageUC = new GrapeRouleClient.Roulette_PageUC();
            this.home_PageUC = new GrapeRouleClient.Home_PageUC();
            this.upperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // upperPanel
            // 
            this.upperPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(197)))), ((int)(((byte)(67)))));
            this.upperPanel.Controls.Add(this.indicationPanel);
            this.upperPanel.Controls.Add(this.exitBtn);
            this.upperPanel.Controls.Add(this.walletBtn);
            this.upperPanel.Controls.Add(this.rouletteBtn);
            this.upperPanel.Controls.Add(this.homeBtn);
            this.upperPanel.Controls.Add(this.logoPictureBox);
            this.upperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanel.Location = new System.Drawing.Point(0, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(1140, 102);
            this.upperPanel.TabIndex = 0;
            this.upperPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpperPanelMouseDown);
            this.upperPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpperPanelMouseMove);
            // 
            // indicationPanel
            // 
            this.indicationPanel.BackColor = System.Drawing.Color.White;
            this.indicationPanel.Location = new System.Drawing.Point(134, 0);
            this.indicationPanel.Name = "indicationPanel";
            this.indicationPanel.Size = new System.Drawing.Size(165, 16);
            this.indicationPanel.TabIndex = 5;
            // 
            // exitBtn
            // 
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitBtn.Location = new System.Drawing.Point(974, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(166, 102);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // walletBtn
            // 
            this.walletBtn.FlatAppearance.BorderSize = 0;
            this.walletBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.walletBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walletBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.walletBtn.Location = new System.Drawing.Point(477, 0);
            this.walletBtn.Name = "walletBtn";
            this.walletBtn.Size = new System.Drawing.Size(166, 102);
            this.walletBtn.TabIndex = 3;
            this.walletBtn.Text = "WALLET";
            this.walletBtn.UseVisualStyleBackColor = true;
            this.walletBtn.Click += new System.EventHandler(this.WalletBtn_Click);
            // 
            // rouletteBtn
            // 
            this.rouletteBtn.FlatAppearance.BorderSize = 0;
            this.rouletteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rouletteBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rouletteBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rouletteBtn.Location = new System.Drawing.Point(305, 0);
            this.rouletteBtn.Name = "rouletteBtn";
            this.rouletteBtn.Size = new System.Drawing.Size(166, 102);
            this.rouletteBtn.TabIndex = 2;
            this.rouletteBtn.Text = "ROULETTE";
            this.rouletteBtn.UseVisualStyleBackColor = true;
            this.rouletteBtn.Click += new System.EventHandler(this.RouletteBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.homeBtn.Location = new System.Drawing.Point(133, 0);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(166, 102);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.Text = "HOME";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(127, 102);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogoMouseDown);
            this.logoPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LogoMouseMove);
            // 
            // roulette_PageUC
            // 
            this.roulette_PageUC.Location = new System.Drawing.Point(0, 102);
            this.roulette_PageUC.Name = "roulette_PageUC";
            this.roulette_PageUC.Size = new System.Drawing.Size(1140, 411);
            this.roulette_PageUC.TabIndex = 2;
            // 
            // home_PageUC
            // 
            this.home_PageUC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home_PageUC.BackgroundImage")));
            this.home_PageUC.Location = new System.Drawing.Point(0, 102);
            this.home_PageUC.Name = "home_PageUC";
            this.home_PageUC.Size = new System.Drawing.Size(1140, 411);
            this.home_PageUC.TabIndex = 1;
            // 
            // GrapeRoule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1140, 513);
            this.Controls.Add(this.roulette_PageUC);
            this.Controls.Add(this.home_PageUC);
            this.Controls.Add(this.upperPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GrapeRoule";
            this.Text = "GrapeRoule";
            this.upperPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button walletBtn;
        private System.Windows.Forms.Button rouletteBtn;
        private Home_PageUC home_PageUC;
        private System.Windows.Forms.Panel indicationPanel;
        private Roulette_PageUC roulette_PageUC;
    }
}

