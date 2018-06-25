namespace RoulettPage
{
    partial class Roulette_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roulette_Page));
            this.walletBalanceIndicationLabel = new System.Windows.Forms.Label();
            this.roomTimeLeftLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.betValueBox = new System.Windows.Forms.TextBox();
            this.RouleteRoomList = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.betBtn = new System.Windows.Forms.Button();
            this.redColorChoiceBtn = new System.Windows.Forms.RadioButton();
            this.colorChoiceGroup = new System.Windows.Forms.GroupBox();
            this.blackColorChoiceBtn = new System.Windows.Forms.RadioButton();
            this.numberChoiceGroup = new System.Windows.Forms.GroupBox();
            this.evenNumberChoiceBtn = new System.Windows.Forms.RadioButton();
            this.oddNumberChoiceBtn = new System.Windows.Forms.RadioButton();
            this.clearBtn = new System.Windows.Forms.Button();
            this.betNumberChoiceLabel = new System.Windows.Forms.Label();
            this.betNumberChoiceValue = new System.Windows.Forms.NumericUpDown();
            this.wheelR = new System.Windows.Forms.PictureBox();
            this.colorChoiceGroup.SuspendLayout();
            this.numberChoiceGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betNumberChoiceValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wheelR)).BeginInit();
            this.SuspendLayout();
            // 
            // walletBalanceIndicationLabel
            // 
            this.walletBalanceIndicationLabel.AutoSize = true;
            this.walletBalanceIndicationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.walletBalanceIndicationLabel.Location = new System.Drawing.Point(939, 22);
            this.walletBalanceIndicationLabel.Name = "walletBalanceIndicationLabel";
            this.walletBalanceIndicationLabel.Size = new System.Drawing.Size(0, 24);
            this.walletBalanceIndicationLabel.TabIndex = 6;
            // 
            // roomTimeLeftLabel
            // 
            this.roomTimeLeftLabel.AutoSize = true;
            this.roomTimeLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTimeLeftLabel.Location = new System.Drawing.Point(158, 406);
            this.roomTimeLeftLabel.Name = "roomTimeLeftLabel";
            this.roomTimeLeftLabel.Size = new System.Drawing.Size(220, 24);
            this.roomTimeLeftLabel.TabIndex = 22;
            this.roomTimeLeftLabel.Text = "Time Left Before Closing:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(939, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 20;
            // 
            // betValueBox
            // 
            this.betValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.betValueBox.Location = new System.Drawing.Point(750, 406);
            this.betValueBox.Name = "betValueBox";
            this.betValueBox.Size = new System.Drawing.Size(234, 29);
            this.betValueBox.TabIndex = 19;
            // 
            // RouleteRoomList
            // 
            this.RouleteRoomList.FormattingEnabled = true;
            this.RouleteRoomList.Location = new System.Drawing.Point(7, 24);
            this.RouleteRoomList.Name = "RouleteRoomList";
            this.RouleteRoomList.Size = new System.Drawing.Size(145, 409);
            this.RouleteRoomList.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Choose a room to play in: ";
            // 
            // betBtn
            // 
            this.betBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.betBtn.Location = new System.Drawing.Point(990, 406);
            this.betBtn.Name = "betBtn";
            this.betBtn.Size = new System.Drawing.Size(116, 29);
            this.betBtn.TabIndex = 16;
            this.betBtn.Text = "Make a Bet";
            this.betBtn.UseVisualStyleBackColor = true;
            this.betBtn.Click += new System.EventHandler(this.betBtn_Click_1);
            // 
            // redColorChoiceBtn
            // 
            this.redColorChoiceBtn.AutoSize = true;
            this.redColorChoiceBtn.BackColor = System.Drawing.Color.DarkRed;
            this.redColorChoiceBtn.Location = new System.Drawing.Point(6, 12);
            this.redColorChoiceBtn.Name = "redColorChoiceBtn";
            this.redColorChoiceBtn.Size = new System.Drawing.Size(45, 17);
            this.redColorChoiceBtn.TabIndex = 9;
            this.redColorChoiceBtn.TabStop = true;
            this.redColorChoiceBtn.Text = "Red";
            this.redColorChoiceBtn.UseVisualStyleBackColor = false;
            this.redColorChoiceBtn.CheckedChanged += new System.EventHandler(this.RedColorChoiceBtn_CheckedChanged_1);
            // 
            // colorChoiceGroup
            // 
            this.colorChoiceGroup.Controls.Add(this.blackColorChoiceBtn);
            this.colorChoiceGroup.Controls.Add(this.redColorChoiceBtn);
            this.colorChoiceGroup.Location = new System.Drawing.Point(626, 400);
            this.colorChoiceGroup.Name = "colorChoiceGroup";
            this.colorChoiceGroup.Size = new System.Drawing.Size(118, 35);
            this.colorChoiceGroup.TabIndex = 15;
            this.colorChoiceGroup.TabStop = false;
            this.colorChoiceGroup.Text = "Color:";
            // 
            // blackColorChoiceBtn
            // 
            this.blackColorChoiceBtn.AutoSize = true;
            this.blackColorChoiceBtn.BackColor = System.Drawing.Color.Black;
            this.blackColorChoiceBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.blackColorChoiceBtn.Location = new System.Drawing.Point(57, 12);
            this.blackColorChoiceBtn.Name = "blackColorChoiceBtn";
            this.blackColorChoiceBtn.Size = new System.Drawing.Size(52, 17);
            this.blackColorChoiceBtn.TabIndex = 10;
            this.blackColorChoiceBtn.TabStop = true;
            this.blackColorChoiceBtn.Text = "Black";
            this.blackColorChoiceBtn.UseVisualStyleBackColor = false;
            this.blackColorChoiceBtn.CheckedChanged += new System.EventHandler(this.BlackColorChoiceBtn_CheckedChanged);
            // 
            // numberChoiceGroup
            // 
            this.numberChoiceGroup.Controls.Add(this.evenNumberChoiceBtn);
            this.numberChoiceGroup.Controls.Add(this.oddNumberChoiceBtn);
            this.numberChoiceGroup.Location = new System.Drawing.Point(502, 400);
            this.numberChoiceGroup.Name = "numberChoiceGroup";
            this.numberChoiceGroup.Size = new System.Drawing.Size(118, 35);
            this.numberChoiceGroup.TabIndex = 23;
            this.numberChoiceGroup.TabStop = false;
            this.numberChoiceGroup.Text = "Number Kind:";
            // 
            // evenNumberChoiceBtn
            // 
            this.evenNumberChoiceBtn.AutoSize = true;
            this.evenNumberChoiceBtn.BackColor = System.Drawing.Color.Transparent;
            this.evenNumberChoiceBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.evenNumberChoiceBtn.Location = new System.Drawing.Point(57, 12);
            this.evenNumberChoiceBtn.Name = "evenNumberChoiceBtn";
            this.evenNumberChoiceBtn.Size = new System.Drawing.Size(50, 17);
            this.evenNumberChoiceBtn.TabIndex = 10;
            this.evenNumberChoiceBtn.TabStop = true;
            this.evenNumberChoiceBtn.Text = "Even";
            this.evenNumberChoiceBtn.UseVisualStyleBackColor = false;
            this.evenNumberChoiceBtn.CheckedChanged += new System.EventHandler(this.EvenNumberChoiceBtn_CheckedChanged_1);
            // 
            // oddNumberChoiceBtn
            // 
            this.oddNumberChoiceBtn.AutoSize = true;
            this.oddNumberChoiceBtn.BackColor = System.Drawing.Color.Transparent;
            this.oddNumberChoiceBtn.Location = new System.Drawing.Point(6, 12);
            this.oddNumberChoiceBtn.Name = "oddNumberChoiceBtn";
            this.oddNumberChoiceBtn.Size = new System.Drawing.Size(45, 17);
            this.oddNumberChoiceBtn.TabIndex = 9;
            this.oddNumberChoiceBtn.TabStop = true;
            this.oddNumberChoiceBtn.Text = "Odd";
            this.oddNumberChoiceBtn.UseVisualStyleBackColor = false;
            this.oddNumberChoiceBtn.CheckedChanged += new System.EventHandler(this.OddNumberChoiceBtn_CheckedChanged_1);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(1112, 406);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 29);
            this.clearBtn.TabIndex = 26;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click_1);
            // 
            // betNumberChoiceLabel
            // 
            this.betNumberChoiceLabel.AutoSize = true;
            this.betNumberChoiceLabel.Location = new System.Drawing.Point(430, 390);
            this.betNumberChoiceLabel.Name = "betNumberChoiceLabel";
            this.betNumberChoiceLabel.Size = new System.Drawing.Size(66, 13);
            this.betNumberChoiceLabel.TabIndex = 25;
            this.betNumberChoiceLabel.Text = "Bet Number:";
            // 
            // betNumberChoiceValue
            // 
            this.betNumberChoiceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betNumberChoiceValue.Location = new System.Drawing.Point(451, 406);
            this.betNumberChoiceValue.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.betNumberChoiceValue.Name = "betNumberChoiceValue";
            this.betNumberChoiceValue.Size = new System.Drawing.Size(45, 29);
            this.betNumberChoiceValue.TabIndex = 24;
            this.betNumberChoiceValue.ValueChanged += new System.EventHandler(this.BetNumberChoiceValue_ValueChanged);
            // 
            // wheelR
            // 
            this.wheelR.Image = ((System.Drawing.Image)(resources.GetObject("wheelR.Image")));
            this.wheelR.Location = new System.Drawing.Point(337, 22);
            this.wheelR.Name = "wheelR";
            this.wheelR.Size = new System.Drawing.Size(447, 348);
            this.wheelR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wheelR.TabIndex = 27;
            this.wheelR.TabStop = false;

            // 
            // Roulette_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.wheelR);
            this.Controls.Add(this.roomTimeLeftLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.betValueBox);
            this.Controls.Add(this.RouleteRoomList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.betBtn);
            this.Controls.Add(this.colorChoiceGroup);
            this.Controls.Add(this.numberChoiceGroup);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.betNumberChoiceLabel);
            this.Controls.Add(this.betNumberChoiceValue);
            this.Controls.Add(this.walletBalanceIndicationLabel);
            this.Name = "Roulette_Page";
            this.Size = new System.Drawing.Size(1190, 440);
            this.colorChoiceGroup.ResumeLayout(false);
            this.colorChoiceGroup.PerformLayout();
            this.numberChoiceGroup.ResumeLayout(false);
            this.numberChoiceGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betNumberChoiceValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wheelR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label walletBalanceIndicationLabel;
        private System.Windows.Forms.Label roomTimeLeftLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox betValueBox;
        private System.Windows.Forms.CheckedListBox RouleteRoomList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button betBtn;
        private System.Windows.Forms.RadioButton redColorChoiceBtn;
        private System.Windows.Forms.GroupBox colorChoiceGroup;
        private System.Windows.Forms.RadioButton blackColorChoiceBtn;
        private System.Windows.Forms.GroupBox numberChoiceGroup;
        private System.Windows.Forms.RadioButton evenNumberChoiceBtn;
        private System.Windows.Forms.RadioButton oddNumberChoiceBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label betNumberChoiceLabel;
        private System.Windows.Forms.NumericUpDown betNumberChoiceValue;
        private System.Windows.Forms.PictureBox wheelR;
    }
}
