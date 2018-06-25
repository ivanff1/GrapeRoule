namespace HomePage
{
    partial class Home_Page
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Page));
            this.homeRouleName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // homeRouleName
            // 
            this.homeRouleName.AutoSize = true;
            this.homeRouleName.BackColor = System.Drawing.Color.Transparent;
            this.homeRouleName.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeRouleName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.homeRouleName.Location = new System.Drawing.Point(419, 145);
            this.homeRouleName.Name = "homeRouleName";
            this.homeRouleName.Size = new System.Drawing.Size(313, 82);
            this.homeRouleName.TabIndex = 0;
            this.homeRouleName.Text = "Grape Rouler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(573, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Play, Bet, Win...";
            // 
            // Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.homeRouleName);
            this.Name = "Home_Page";
            this.Size = new System.Drawing.Size(1190, 440);
            this.Load += new System.EventHandler(this.Home_Page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label homeRouleName;
        private System.Windows.Forms.Label label1;
    }
}
