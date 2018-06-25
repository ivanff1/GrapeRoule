namespace GrapeRouleMain
{
    partial class Register_Start_Page
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
            this.passwordTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.userNameTxtBox = new System.Windows.Forms.TextBox();
            this.signUpLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.termsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBox.Location = new System.Drawing.Point(103, 108);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.Size = new System.Drawing.Size(171, 26);
            this.passwordTxtBox.TabIndex = 0;
            this.passwordTxtBox.ValidatingType = typeof(int);
            // 
            // userNameTxtBox
            // 
            this.userNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTxtBox.Location = new System.Drawing.Point(103, 67);
            this.userNameTxtBox.Name = "userNameTxtBox";
            this.userNameTxtBox.Size = new System.Drawing.Size(171, 26);
            this.userNameTxtBox.TabIndex = 1;
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLabel.Location = new System.Drawing.Point(3, 10);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Padding = new System.Windows.Forms.Padding(111, 0, 104, 0);
            this.signUpLabel.Size = new System.Drawing.Size(367, 24);
            this.signUpLabel.TabIndex = 2;
            this.signUpLabel.Text = "Sign Up for Free";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(10, 70);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(87, 20);
            this.userNameLabel.TabIndex = 3;
            this.userNameLabel.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password:";
            // 
            // signUpBtn
            // 
            this.signUpBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.signUpBtn.FlatAppearance.BorderSize = 0;
            this.signUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBtn.Location = new System.Drawing.Point(3, 284);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(367, 63);
            this.signUpBtn.TabIndex = 7;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.UseVisualStyleBackColor = false;
            this.signUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // termsLabel
            // 
            this.termsLabel.AutoSize = true;
            this.termsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termsLabel.Location = new System.Drawing.Point(3, 249);
            this.termsLabel.Name = "termsLabel";
            this.termsLabel.Size = new System.Drawing.Size(312, 32);
            this.termsLabel.TabIndex = 8;
            this.termsLabel.Text = "***By clicking sign up you are agreeing to the terms \r\nof use and privacy policy " +
    "sign up.";
            // 
            // Register_Start_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.termsLabel);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.signUpLabel);
            this.Controls.Add(this.userNameTxtBox);
            this.Controls.Add(this.passwordTxtBox);
            this.Name = "Register_Start_Page";
            this.Size = new System.Drawing.Size(373, 364);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox passwordTxtBox;
        private System.Windows.Forms.TextBox userNameTxtBox;
        private System.Windows.Forms.Label signUpLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.Label termsLabel;
    }
}
