using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoulettPage
{
    public partial class Roulette_Page : UserControl
    {
        public Roulette_Page()
        {
            InitializeComponent();
            walletBalanceIndicationLabel.Text = $"Your wallet balance is: {231}$";
        }
        private void betBtn_Click_1(object sender, EventArgs e)
        {
            betValueBox.Enabled = false;
            oddNumberChoiceBtn.Enabled = false;            
            evenNumberChoiceBtn.Enabled = false;          
            blackColorChoiceBtn.Enabled = false;
            redColorChoiceBtn.Enabled = false;
            betNumberChoiceValue.Enabled = false;
            blackColorChoiceBtn.BackColor = Color.Gray;
          

        }

        private void BlackColorChoiceBtn_CheckedChanged(object sender, EventArgs e)
        {
            oddNumberChoiceBtn.Enabled = false;
            oddNumberChoiceBtn.Checked = false;
            evenNumberChoiceBtn.Enabled = false;
            evenNumberChoiceBtn.Checked = false;
            blackColorChoiceBtn.Enabled = false;
            redColorChoiceBtn.Enabled = false;
            betNumberChoiceValue.Enabled = false;
            blackColorChoiceBtn.BackColor = Color.Gray;
        }

        private void RedColorChoiceBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            oddNumberChoiceBtn.Enabled = false;
            oddNumberChoiceBtn.Checked = false;
            evenNumberChoiceBtn.Enabled = false;
            evenNumberChoiceBtn.Checked = false;
            blackColorChoiceBtn.Enabled = false;
            redColorChoiceBtn.Enabled = false;
            betNumberChoiceValue.Enabled = false;
            blackColorChoiceBtn.Checked = false;
            blackColorChoiceBtn.BackColor = Color.Gray;
        }

        private void ClearBtn_Click_1(object sender, EventArgs e)
        {
            redColorChoiceBtn.Checked = false;
            oddNumberChoiceBtn.Checked = false;
            blackColorChoiceBtn.Checked = false;
            evenNumberChoiceBtn.Checked = false;
            oddNumberChoiceBtn.Enabled = true;
            evenNumberChoiceBtn.Enabled = true;
            blackColorChoiceBtn.Enabled = true;
            redColorChoiceBtn.Enabled = true;
            betNumberChoiceValue.Enabled = true;
            betNumberChoiceValue.Value = 0;
            blackColorChoiceBtn.BackColor = Color.Black;
        }

        private void BetNumberChoiceValue_ValueChanged(object sender, EventArgs e)
        {
            oddNumberChoiceBtn.Enabled = false;
            evenNumberChoiceBtn.Enabled = false;
            blackColorChoiceBtn.Enabled = false;
            redColorChoiceBtn.Enabled = false;
            blackColorChoiceBtn.BackColor = Color.Gray;
        }

        private void OddNumberChoiceBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            oddNumberChoiceBtn.Enabled = false;
            evenNumberChoiceBtn.Enabled = false;
            blackColorChoiceBtn.Enabled = false;
            redColorChoiceBtn.Enabled = false;
            redColorChoiceBtn.Checked = false;
            betNumberChoiceValue.Enabled = false;
            blackColorChoiceBtn.Checked = false;
            blackColorChoiceBtn.BackColor = Color.Gray;
        }

        private void EvenNumberChoiceBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            oddNumberChoiceBtn.Enabled = false;
            evenNumberChoiceBtn.Enabled = false;
            blackColorChoiceBtn.Enabled = false;
            redColorChoiceBtn.Enabled = false;
            redColorChoiceBtn.Checked = false;
            betNumberChoiceValue.Enabled = false;
            blackColorChoiceBtn.Checked = false;
            blackColorChoiceBtn.BackColor = Color.Gray;
        }

     
    }
}
