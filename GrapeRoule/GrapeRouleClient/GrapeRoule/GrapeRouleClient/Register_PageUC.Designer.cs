namespace GrapeRouleClient
{
    partial class Register_PageUC
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
            this.usernameTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.agreementLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.BackColor = System.Drawing.Color.LightGray;
            this.usernameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.usernameTxtBox.Location = new System.Drawing.Point(119, 89);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(223, 22);
            this.usernameTxtBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(10, 87);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(107, 24);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username: ";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(10, 136);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(102, 24);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password: ";
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.BackColor = System.Drawing.Color.LightGray;
            this.passwordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.passwordTxtBox.Location = new System.Drawing.Point(119, 138);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.Size = new System.Drawing.Size(223, 22);
            this.passwordTxtBox.TabIndex = 3;
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(197)))), ((int)(((byte)(67)))));
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.registerBtn.Location = new System.Drawing.Point(14, 303);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(374, 81);
            this.registerBtn.TabIndex = 5;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // agreementLabel
            // 
            this.agreementLabel.AutoSize = true;
            this.agreementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agreementLabel.Location = new System.Drawing.Point(11, 270);
            this.agreementLabel.Name = "agreementLabel";
            this.agreementLabel.Size = new System.Drawing.Size(358, 30);
            this.agreementLabel.TabIndex = 6;
            this.agreementLabel.Text = "***By clicking Register, you agree to our Terms and that you have\r\n read our Data" +
    " Use Policy, including our Cookie Use.";
            // 
            // Register_PageUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.agreementLabel);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTxtBox);
            this.Name = "Register_PageUC";
            this.Size = new System.Drawing.Size(405, 399);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox usernameTxtBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.MaskedTextBox passwordTxtBox;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label agreementLabel;
    }
}
