namespace GrapeRouleClient
{
    partial class Roulette_PageUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roulette_PageUC));
            this.roomsListBox = new System.Windows.Forms.CheckedListBox();
            this.numberColorGroup = new System.Windows.Forms.GroupBox();
            this.blackColorChoiceBtn = new System.Windows.Forms.RadioButton();
            this.redColorChoiceBtn = new System.Windows.Forms.RadioButton();
            this.betBtn = new System.Windows.Forms.Button();
            this.clearAllBtn = new System.Windows.Forms.Button();
            this.betValueBox = new System.Windows.Forms.TextBox();
            this.numberTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.evenNumberTypeBtn = new System.Windows.Forms.RadioButton();
            this.oddNumberTypeBtn = new System.Windows.Forms.RadioButton();
            this.betNumberBox = new System.Windows.Forms.NumericUpDown();
            this.wheelPictureBox = new System.Windows.Forms.PictureBox();
            this.usersOnlineListBox = new System.Windows.Forms.ListBox();
            this.onlineUsersLabel = new System.Windows.Forms.Label();
            this.balanceIndicationLabel = new System.Windows.Forms.Label();
            this.roomClosingTimeLeft = new System.Windows.Forms.Label();
            this.numberColorGroup.SuspendLayout();
            this.numberTypeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betNumberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wheelPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // roomsListBox
            // 
            this.roomsListBox.CheckOnClick = true;
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.Items.AddRange(new object[] {
            "Room 1",
            "Room 2",
            "Room 3",
            "Room 4",
            "Room 5",
            "Room 6",
            "Room 7",
            "Room 8",
            "Room 9",
            "Room 10",
            "Room 11",
            "Room 12",
            "Room 13",
            "Room 14",
            "Room 15"});
            this.roomsListBox.Location = new System.Drawing.Point(12, 19);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(132, 379);
            this.roomsListBox.TabIndex = 0;
            // 
            // numberColorGroup
            // 
            this.numberColorGroup.Controls.Add(this.blackColorChoiceBtn);
            this.numberColorGroup.Controls.Add(this.redColorChoiceBtn);
            this.numberColorGroup.Location = new System.Drawing.Point(687, 363);
            this.numberColorGroup.Name = "numberColorGroup";
            this.numberColorGroup.Size = new System.Drawing.Size(117, 35);
            this.numberColorGroup.TabIndex = 1;
            this.numberColorGroup.TabStop = false;
            this.numberColorGroup.Text = "Color:";
            // 
            // blackColorChoiceBtn
            // 
            this.blackColorChoiceBtn.AutoSize = true;
            this.blackColorChoiceBtn.BackColor = System.Drawing.Color.Black;
            this.blackColorChoiceBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.blackColorChoiceBtn.Location = new System.Drawing.Point(57, 12);
            this.blackColorChoiceBtn.Name = "blackColorChoiceBtn";
            this.blackColorChoiceBtn.Size = new System.Drawing.Size(52, 17);
            this.blackColorChoiceBtn.TabIndex = 1;
            this.blackColorChoiceBtn.TabStop = true;
            this.blackColorChoiceBtn.Text = "Black";
            this.blackColorChoiceBtn.UseVisualStyleBackColor = false;
            this.blackColorChoiceBtn.CheckedChanged += new System.EventHandler(this.BlackColorChoiceBtn_CheckedChanged);
            // 
            // redColorChoiceBtn
            // 
            this.redColorChoiceBtn.AutoSize = true;
            this.redColorChoiceBtn.BackColor = System.Drawing.Color.DarkRed;
            this.redColorChoiceBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.redColorChoiceBtn.Location = new System.Drawing.Point(6, 12);
            this.redColorChoiceBtn.Name = "redColorChoiceBtn";
            this.redColorChoiceBtn.Size = new System.Drawing.Size(45, 17);
            this.redColorChoiceBtn.TabIndex = 0;
            this.redColorChoiceBtn.TabStop = true;
            this.redColorChoiceBtn.Text = "Red";
            this.redColorChoiceBtn.UseVisualStyleBackColor = false;
            this.redColorChoiceBtn.CheckedChanged += new System.EventHandler(this.RedColorChoiceBtn_CheckedChanged);
            // 
            // betBtn
            // 
            this.betBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.betBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betBtn.Location = new System.Drawing.Point(916, 369);
            this.betBtn.Name = "betBtn";
            this.betBtn.Size = new System.Drawing.Size(118, 29);
            this.betBtn.TabIndex = 2;
            this.betBtn.Text = "Bet";
            this.betBtn.UseVisualStyleBackColor = true;
            this.betBtn.Click += new System.EventHandler(this.BetBtn_Click);
            // 
            // clearAllBtn
            // 
            this.clearAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAllBtn.Location = new System.Drawing.Point(1040, 369);
            this.clearAllBtn.Name = "clearAllBtn";
            this.clearAllBtn.Size = new System.Drawing.Size(97, 29);
            this.clearAllBtn.TabIndex = 3;
            this.clearAllBtn.Text = "Clear";
            this.clearAllBtn.UseVisualStyleBackColor = true;
            this.clearAllBtn.Click += new System.EventHandler(this.ClearAllBtn_Click);
            // 
            // betValueBox
            // 
            this.betValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betValueBox.Location = new System.Drawing.Point(810, 369);
            this.betValueBox.Name = "betValueBox";
            this.betValueBox.Size = new System.Drawing.Size(100, 29);
            this.betValueBox.TabIndex = 0;
            // 
            // numberTypeGroupBox
            // 
            this.numberTypeGroupBox.Controls.Add(this.evenNumberTypeBtn);
            this.numberTypeGroupBox.Controls.Add(this.oddNumberTypeBtn);
            this.numberTypeGroupBox.Location = new System.Drawing.Point(570, 363);
            this.numberTypeGroupBox.Name = "numberTypeGroupBox";
            this.numberTypeGroupBox.Size = new System.Drawing.Size(117, 35);
            this.numberTypeGroupBox.TabIndex = 2;
            this.numberTypeGroupBox.TabStop = false;
            this.numberTypeGroupBox.Text = "Number Type:";
            // 
            // evenNumberTypeBtn
            // 
            this.evenNumberTypeBtn.AutoSize = true;
            this.evenNumberTypeBtn.BackColor = System.Drawing.Color.Transparent;
            this.evenNumberTypeBtn.Location = new System.Drawing.Point(57, 12);
            this.evenNumberTypeBtn.Name = "evenNumberTypeBtn";
            this.evenNumberTypeBtn.Size = new System.Drawing.Size(50, 17);
            this.evenNumberTypeBtn.TabIndex = 1;
            this.evenNumberTypeBtn.TabStop = true;
            this.evenNumberTypeBtn.Text = "Even";
            this.evenNumberTypeBtn.UseVisualStyleBackColor = false;
            this.evenNumberTypeBtn.CheckedChanged += new System.EventHandler(this.EvenNumberTypeBtn_CheckedChanged);
            // 
            // oddNumberTypeBtn
            // 
            this.oddNumberTypeBtn.AutoSize = true;
            this.oddNumberTypeBtn.BackColor = System.Drawing.Color.Transparent;
            this.oddNumberTypeBtn.Location = new System.Drawing.Point(6, 12);
            this.oddNumberTypeBtn.Name = "oddNumberTypeBtn";
            this.oddNumberTypeBtn.Size = new System.Drawing.Size(45, 17);
            this.oddNumberTypeBtn.TabIndex = 0;
            this.oddNumberTypeBtn.TabStop = true;
            this.oddNumberTypeBtn.Text = "Odd";
            this.oddNumberTypeBtn.UseVisualStyleBackColor = false;
            this.oddNumberTypeBtn.CheckedChanged += new System.EventHandler(this.OddNumberTypeBtn_CheckedChanged);
            // 
            // betNumberBox
            // 
            this.betNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betNumberBox.Location = new System.Drawing.Point(508, 369);
            this.betNumberBox.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.betNumberBox.Name = "betNumberBox";
            this.betNumberBox.Size = new System.Drawing.Size(56, 29);
            this.betNumberBox.TabIndex = 4;
            this.betNumberBox.ValueChanged += new System.EventHandler(this.BetNumberBox_ValueChanged);
            // 
            // wheelPictureBox
            // 
            this.wheelPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("wheelPictureBox.Image")));
            this.wheelPictureBox.Location = new System.Drawing.Point(398, 19);
            this.wheelPictureBox.Name = "wheelPictureBox";
            this.wheelPictureBox.Size = new System.Drawing.Size(398, 322);
            this.wheelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wheelPictureBox.TabIndex = 5;
            this.wheelPictureBox.TabStop = false;
            // 
            // usersOnlineListBox
            // 
            this.usersOnlineListBox.FormattingEnabled = true;
            this.usersOnlineListBox.Location = new System.Drawing.Point(961, 38);
            this.usersOnlineListBox.Name = "usersOnlineListBox";
            this.usersOnlineListBox.Size = new System.Drawing.Size(176, 303);
            this.usersOnlineListBox.TabIndex = 6;
            // 
            // onlineUsersLabel
            // 
            this.onlineUsersLabel.AutoSize = true;
            this.onlineUsersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.onlineUsersLabel.Location = new System.Drawing.Point(957, 15);
            this.onlineUsersLabel.Name = "onlineUsersLabel";
            this.onlineUsersLabel.Size = new System.Drawing.Size(108, 20);
            this.onlineUsersLabel.TabIndex = 7;
            this.onlineUsersLabel.Text = "Users Online: ";
            // 
            // balanceIndicationLabel
            // 
            this.balanceIndicationLabel.AutoSize = true;
            this.balanceIndicationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceIndicationLabel.Location = new System.Drawing.Point(958, 344);
            this.balanceIndicationLabel.Name = "balanceIndicationLabel";
            this.balanceIndicationLabel.Size = new System.Drawing.Size(0, 20);
            this.balanceIndicationLabel.TabIndex = 8;
            // 
            // roomClosingTimeLeft
            // 
            this.roomClosingTimeLeft.AutoSize = true;
            this.roomClosingTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomClosingTimeLeft.Location = new System.Drawing.Point(165, 369);
            this.roomClosingTimeLeft.Name = "roomClosingTimeLeft";
            this.roomClosingTimeLeft.Size = new System.Drawing.Size(0, 20);
            this.roomClosingTimeLeft.TabIndex = 9;
            // 
            // Roulette_PageUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roomClosingTimeLeft);
            this.Controls.Add(this.balanceIndicationLabel);
            this.Controls.Add(this.onlineUsersLabel);
            this.Controls.Add(this.usersOnlineListBox);
            this.Controls.Add(this.wheelPictureBox);
            this.Controls.Add(this.betNumberBox);
            this.Controls.Add(this.numberTypeGroupBox);
            this.Controls.Add(this.betValueBox);
            this.Controls.Add(this.clearAllBtn);
            this.Controls.Add(this.betBtn);
            this.Controls.Add(this.numberColorGroup);
            this.Controls.Add(this.roomsListBox);
            this.Name = "Roulette_PageUC";
            this.Size = new System.Drawing.Size(1140, 411);
            this.numberColorGroup.ResumeLayout(false);
            this.numberColorGroup.PerformLayout();
            this.numberTypeGroupBox.ResumeLayout(false);
            this.numberTypeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betNumberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wheelPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox roomsListBox;
        private System.Windows.Forms.GroupBox numberColorGroup;
        private System.Windows.Forms.RadioButton blackColorChoiceBtn;
        private System.Windows.Forms.RadioButton redColorChoiceBtn;
        private System.Windows.Forms.Button betBtn;
        private System.Windows.Forms.Button clearAllBtn;
        private System.Windows.Forms.TextBox betValueBox;
        private System.Windows.Forms.GroupBox numberTypeGroupBox;
        private System.Windows.Forms.RadioButton evenNumberTypeBtn;
        private System.Windows.Forms.RadioButton oddNumberTypeBtn;
        private System.Windows.Forms.NumericUpDown betNumberBox;
        private System.Windows.Forms.PictureBox wheelPictureBox;
        private System.Windows.Forms.ListBox usersOnlineListBox;
        private System.Windows.Forms.Label onlineUsersLabel;
        private System.Windows.Forms.Label balanceIndicationLabel;
        private System.Windows.Forms.Label roomClosingTimeLeft;
    }
}
