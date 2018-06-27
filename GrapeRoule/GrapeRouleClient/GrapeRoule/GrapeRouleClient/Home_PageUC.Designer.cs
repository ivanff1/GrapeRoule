namespace GrapeRouleClient
{
    partial class Home_PageUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_PageUC));
            this.homeMenuMainLabel = new System.Windows.Forms.Label();
            this.homeMenuSecondaryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // homeMenuMainLabel
            // 
            this.homeMenuMainLabel.AutoSize = true;
            this.homeMenuMainLabel.BackColor = System.Drawing.Color.Transparent;
            this.homeMenuMainLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeMenuMainLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.homeMenuMainLabel.Location = new System.Drawing.Point(388, 121);
            this.homeMenuMainLabel.Name = "homeMenuMainLabel";
            this.homeMenuMainLabel.Size = new System.Drawing.Size(335, 62);
            this.homeMenuMainLabel.TabIndex = 0;
            this.homeMenuMainLabel.Text = "GrapeRoule";
            // 
            // homeMenuSecondaryLabel
            // 
            this.homeMenuSecondaryLabel.AutoSize = true;
            this.homeMenuSecondaryLabel.BackColor = System.Drawing.Color.Transparent;
            this.homeMenuSecondaryLabel.Font = new System.Drawing.Font("Arial Unicode MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeMenuSecondaryLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.homeMenuSecondaryLabel.Location = new System.Drawing.Point(566, 173);
            this.homeMenuSecondaryLabel.Name = "homeMenuSecondaryLabel";
            this.homeMenuSecondaryLabel.Size = new System.Drawing.Size(247, 43);
            this.homeMenuSecondaryLabel.TabIndex = 1;
            this.homeMenuSecondaryLabel.Text = "Play, Bet, Win...";
            // 
            // Home_PageUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.homeMenuSecondaryLabel);
            this.Controls.Add(this.homeMenuMainLabel);
            this.Name = "Home_PageUC";
            this.Size = new System.Drawing.Size(1140, 411);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label homeMenuMainLabel;
        private System.Windows.Forms.Label homeMenuSecondaryLabel;
    }
}
