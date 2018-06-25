namespace WalletPage
{
    partial class Wallet_Page
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
            this.components = new System.ComponentModel.Container();
            this.walletBalanceIndicationLabel = new System.Windows.Forms.Label();
            this.balanceIncreaseValue = new System.Windows.Forms.NumericUpDown();
            this.balanceIncreaseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.walletBoostTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.balanceIncreaseValue)).BeginInit();
            this.SuspendLayout();
            // 
            // walletBalanceIndicationLabel
            // 
            this.walletBalanceIndicationLabel.AutoSize = true;
            this.walletBalanceIndicationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.walletBalanceIndicationLabel.Location = new System.Drawing.Point(3, 27);
            this.walletBalanceIndicationLabel.Name = "walletBalanceIndicationLabel";
            this.walletBalanceIndicationLabel.Size = new System.Drawing.Size(0, 25);
            this.walletBalanceIndicationLabel.TabIndex = 0;
            // 
            // balanceIncreaseValue
            // 
            this.balanceIncreaseValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balanceIncreaseValue.Location = new System.Drawing.Point(736, 398);
            this.balanceIncreaseValue.Name = "balanceIncreaseValue";
            this.balanceIncreaseValue.Size = new System.Drawing.Size(240, 29);
            this.balanceIncreaseValue.TabIndex = 1;
            // 
            // balanceIncreaseBtn
            // 
            this.balanceIncreaseBtn.Location = new System.Drawing.Point(982, 398);
            this.balanceIncreaseBtn.Name = "balanceIncreaseBtn";
            this.balanceIncreaseBtn.Size = new System.Drawing.Size(194, 29);
            this.balanceIncreaseBtn.TabIndex = 2;
            this.balanceIncreaseBtn.Text = "Add to Balance";
            this.balanceIncreaseBtn.UseVisualStyleBackColor = true;
            this.balanceIncreaseBtn.Click += new System.EventHandler(this.BalanceIncreaseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(251, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "You can add funds to your wallet from here: ";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameLabel.Location = new System.Drawing.Point(977, 17);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(135, 25);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "User: xxxxx";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.Location = new System.Drawing.Point(977, 61);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 25);
            this.timeLabel.TabIndex = 5;
            // 
            // walletBoostTimer
            // 
            this.walletBoostTimer.Interval = 1000;
            this.walletBoostTimer.Tick += new System.EventHandler(this.walletBoostTimer_Tick);
            // 
            // Wallet_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.balanceIncreaseBtn);
            this.Controls.Add(this.balanceIncreaseValue);
            this.Controls.Add(this.walletBalanceIndicationLabel);
            this.Name = "Wallet_Page";
            this.Size = new System.Drawing.Size(1190, 440);
            this.Load += new System.EventHandler(this.WalletPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.balanceIncreaseValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label walletBalanceIndicationLabel;
        private System.Windows.Forms.NumericUpDown balanceIncreaseValue;
        private System.Windows.Forms.Button balanceIncreaseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer walletBoostTimer;
    }
}
