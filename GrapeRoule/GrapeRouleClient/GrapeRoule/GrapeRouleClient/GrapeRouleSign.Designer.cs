namespace GrapeRouleClient
{
    partial class GrapeRouleSign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrapeRouleSign));
            this.signUpperPanel = new System.Windows.Forms.Panel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.signMainLabel = new System.Windows.Forms.Label();
            this.loginLabelLink = new System.Windows.Forms.Label();
            this.registerLabelLink = new System.Windows.Forms.Label();
            this.register_PageUC = new GrapeRouleClient.Register_PageUC();
            this.login_PageUC1 = new GrapeRouleClient.Login_PageUC();
            this.signUpperPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // signUpperPanel
            // 
            this.signUpperPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(197)))), ((int)(((byte)(67)))));
            this.signUpperPanel.Controls.Add(this.registerLabelLink);
            this.signUpperPanel.Controls.Add(this.loginLabelLink);
            this.signUpperPanel.Controls.Add(this.welcomeLabel);
            this.signUpperPanel.Controls.Add(this.signMainLabel);
            this.signUpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.signUpperPanel.Location = new System.Drawing.Point(0, 0);
            this.signUpperPanel.Name = "signUpperPanel";
            this.signUpperPanel.Size = new System.Drawing.Size(405, 100);
            this.signUpperPanel.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.welcomeLabel.Location = new System.Drawing.Point(187, 50);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(103, 28);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome...";
            // 
            // signMainLabel
            // 
            this.signMainLabel.AutoSize = true;
            this.signMainLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signMainLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.signMainLabel.Location = new System.Drawing.Point(108, 9);
            this.signMainLabel.Name = "signMainLabel";
            this.signMainLabel.Size = new System.Drawing.Size(180, 38);
            this.signMainLabel.TabIndex = 0;
            this.signMainLabel.Text = "GrapeRoule";
            // 
            // loginLabelLink
            // 
            this.loginLabelLink.AutoSize = true;
            this.loginLabelLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginLabelLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabelLink.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginLabelLink.Location = new System.Drawing.Point(358, 81);
            this.loginLabelLink.Name = "loginLabelLink";
            this.loginLabelLink.Size = new System.Drawing.Size(44, 18);
            this.loginLabelLink.TabIndex = 2;
            this.loginLabelLink.Text = "Login";
            this.loginLabelLink.Click += new System.EventHandler(this.LoginLabelLink_Click);
            // 
            // registerLabelLink
            // 
            this.registerLabelLink.AutoSize = true;
            this.registerLabelLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerLabelLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLabelLink.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.registerLabelLink.Location = new System.Drawing.Point(280, 81);
            this.registerLabelLink.Name = "registerLabelLink";
            this.registerLabelLink.Size = new System.Drawing.Size(63, 18);
            this.registerLabelLink.TabIndex = 7;
            this.registerLabelLink.Text = "Register";
            this.registerLabelLink.Click += new System.EventHandler(this.RegisterLabelLink_Click);
            // 
            // register_PageUC
            // 
            this.register_PageUC.Location = new System.Drawing.Point(0, 102);
            this.register_PageUC.Name = "register_PageUC";
            this.register_PageUC.Size = new System.Drawing.Size(405, 399);
            this.register_PageUC.TabIndex = 2;
            // 
            // login_PageUC1
            // 
            this.login_PageUC1.Location = new System.Drawing.Point(0, 102);
            this.login_PageUC1.Name = "login_PageUC1";
            this.login_PageUC1.Size = new System.Drawing.Size(405, 399);
            this.login_PageUC1.TabIndex = 1;
            // 
            // GrapeRouleSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(405, 499);
            this.Controls.Add(this.register_PageUC);
            this.Controls.Add(this.login_PageUC1);
            this.Controls.Add(this.signUpperPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GrapeRouleSign";
            this.Text = "GrapeRoule";
            this.signUpperPanel.ResumeLayout(false);
            this.signUpperPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel signUpperPanel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label signMainLabel;
        private Login_PageUC login_PageUC1;
        private Register_PageUC register_PageUC;
        private System.Windows.Forms.Label loginLabelLink;
        private System.Windows.Forms.Label registerLabelLink;
    }
}