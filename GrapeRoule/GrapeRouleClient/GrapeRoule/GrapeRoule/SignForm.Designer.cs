namespace GrapeRoule
{
    partial class SignForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignForm));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.upperSignFormPanel = new System.Windows.Forms.Panel();
            this.regLabel = new System.Windows.Forms.Label();
            this.login_Page1 = new GrapeRoule.Login_Page();
            this.register_Page = new GrapeRoule.Register_Page();
            this.upperSignFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(151, 48);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(117, 28);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome...";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(88, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(180, 39);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "GrapeRoule";
            // 
            // upperSignFormPanel
            // 
            this.upperSignFormPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.upperSignFormPanel.Controls.Add(this.regLabel);
            this.upperSignFormPanel.Controls.Add(this.welcomeLabel);
            this.upperSignFormPanel.Controls.Add(this.nameLabel);
            this.upperSignFormPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperSignFormPanel.Location = new System.Drawing.Point(0, 0);
            this.upperSignFormPanel.Name = "upperSignFormPanel";
            this.upperSignFormPanel.Size = new System.Drawing.Size(373, 86);
            this.upperSignFormPanel.TabIndex = 1;
            // 
            // regLabel
            // 
            this.regLabel.AutoSize = true;
            this.regLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLabel.Location = new System.Drawing.Point(311, 68);
            this.regLabel.Name = "regLabel";
            this.regLabel.Size = new System.Drawing.Size(59, 16);
            this.regLabel.TabIndex = 22;
            this.regLabel.Text = "Register";
            this.regLabel.Click += new System.EventHandler(this.regLabel_Click);
            // 
            // login_Page1
            // 
            this.login_Page1.Location = new System.Drawing.Point(0, 85);
            this.login_Page1.Name = "login_Page1";
            this.login_Page1.Size = new System.Drawing.Size(373, 364);
            this.login_Page1.TabIndex = 3;
            // 
            // register_Page
            // 
            this.register_Page.ForeColor = System.Drawing.SystemColors.ControlText;
            this.register_Page.Location = new System.Drawing.Point(0, 86);
            this.register_Page.Name = "register_Page";
            this.register_Page.Size = new System.Drawing.Size(373, 364);
            this.register_Page.TabIndex = 2;
            this.register_Page.Load += new System.EventHandler(this.register_Page1_Load);
            // 
            // SignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(373, 450);
            this.Controls.Add(this.login_Page1);
            this.Controls.Add(this.register_Page);
            this.Controls.Add(this.upperSignFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignForm";
            this.Text = "SignForm";
            this.upperSignFormPanel.ResumeLayout(false);
            this.upperSignFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel upperSignFormPanel;
        private Register_Page register_Page;
        private Login_Page login_Page1;
        private System.Windows.Forms.Label regLabel;
    }
}