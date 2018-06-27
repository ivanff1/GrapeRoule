using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace GrapeRouleClient
{
    public partial class Roulette_PageUC : UserControl
    {
        public static int currentBalnce = 213;
        public static int timeLeft = 4;
        public Roulette_PageUC()
        {
            InitializeComponent();
            balanceIndicationLabel.Text = $"Your balance is: {currentBalnce}$";
            roomClosingTimeLeft.Text = $"Time left before roulette start: {timeLeft} min";
        }

        private void OddNumberTypeBtn_CheckedChanged(object sender, EventArgs e)
        {
            oddNumberTypeBtn.Enabled = false;
            evenNumberTypeBtn.Enabled = false;
            redColorChoiceBtn.Enabled = false;
            blackColorChoiceBtn.Enabled = false;
            blackColorChoiceBtn.BackColor = Color.Gray;
            betNumberBox.Enabled = false;
        }

        private void EvenNumberTypeBtn_CheckedChanged(object sender, EventArgs e)
        {
            oddNumberTypeBtn.Enabled = false;
            evenNumberTypeBtn.Enabled = false;
            redColorChoiceBtn.Enabled = false;
            blackColorChoiceBtn.Enabled = false;
            blackColorChoiceBtn.BackColor = Color.Gray;
            betNumberBox.Enabled = false;
        }

        private void RedColorChoiceBtn_CheckedChanged(object sender, EventArgs e)
        {
            oddNumberTypeBtn.Enabled = false;
            evenNumberTypeBtn.Enabled = false;
            redColorChoiceBtn.Enabled = false;
            blackColorChoiceBtn.Enabled = false;
            blackColorChoiceBtn.BackColor = Color.Gray;
            betNumberBox.Enabled = false;
        }

        private void BlackColorChoiceBtn_CheckedChanged(object sender, EventArgs e)
        {
            oddNumberTypeBtn.Enabled = false;
            evenNumberTypeBtn.Enabled = false;
            redColorChoiceBtn.Enabled = false;
            blackColorChoiceBtn.Enabled = false;
            blackColorChoiceBtn.BackColor = Color.Gray;
            betNumberBox.Enabled = false;
        }

        private void BetNumberBox_ValueChanged(object sender, EventArgs e)
        {
            oddNumberTypeBtn.Enabled = false;
            evenNumberTypeBtn.Enabled = false;
            redColorChoiceBtn.Enabled = false;
            blackColorChoiceBtn.Enabled = false;
            blackColorChoiceBtn.BackColor = Color.Gray;
        }

        private void ClearAllBtn_Click(object sender, EventArgs e)
        {
            BetValueNulling();
            ClearCheck();
            EnableAllChoices();
        }
        private void BetValueNulling()
        {            
            betNumberBox.Value = 0;
        }
        private void EnableAllChoices()
        {
            betNumberBox.Enabled = true;
            oddNumberTypeBtn.Enabled = true;
            evenNumberTypeBtn.Enabled = true;
            blackColorChoiceBtn.Enabled = true;
            redColorChoiceBtn.Enabled = true;
            blackColorChoiceBtn.BackColor = Color.Black;
        }
        private void ClearCheck()
        {
            oddNumberTypeBtn.Checked = false;
            redColorChoiceBtn.Checked = false;
            blackColorChoiceBtn.Checked = false;
            evenNumberTypeBtn.Checked = false;

        }

        private void BetBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
