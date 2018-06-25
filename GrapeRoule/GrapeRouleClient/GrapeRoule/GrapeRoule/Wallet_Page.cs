using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalletPage
{
    public partial class Wallet_Page : UserControl
    {
        public static int walletBalance = 0;
        public static int walletBoostCounter = 0;
        public static int timeLeft = 1800;
        Timer countdownTimer = new Timer();

        public Wallet_Page()
        {           
            InitializeComponent();
            walletBalanceIndicationLabel.Text = $"Your Wallet Balance Is: {walletBalance}";
        }
        
        private void BalanceIncreaseBtn_Click(object sender, EventArgs e)
        {

            if (walletBoostCounter > 10)
            {
                MessageBox.Show("You should wait 30 mintues to add new funds");
                walletBoostTimer.Start();
            }
            else
            {
                walletBalance += Convert.ToInt32(balanceIncreaseValue.Value);
                walletBalanceIndicationLabel.Text = $"Your Wallet Balance Is: {walletBalance}";
                balanceIncreaseValue.Value = 0;
                walletBoostCounter++;
            }
        }
        private void WalletPage_Load(object sender, EventArgs e)
        {
            
        }

        private void walletBoostTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            if (timeLeft == 0)
            {
               walletBoostTimer.Stop();
               walletBoostCounter = 0;
               timeLeft = 1800;
            }
            timeLabel.Text = $"Time Left: {(timeLeft/60).ToString()} minutes";
        }
    }
}

