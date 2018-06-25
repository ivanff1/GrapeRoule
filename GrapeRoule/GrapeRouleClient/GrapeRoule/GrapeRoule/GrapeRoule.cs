using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalletPage
{
    public partial class GrapeRoule : Form
    {
        public GrapeRoule()
        {
            InitializeComponent();
            movableIndicationPanel.Location = HomeMenuBtn.Location;
            home_Page.BringToFront();
        }

        private void HomeMenuBtn_Click(object sender, EventArgs e)
        {
            movableIndicationPanel.Location = HomeMenuBtn.Location;
            home_Page.BringToFront();
        }

        private void RouletteMenuBtn_Click(object sender, EventArgs e)
        {
             movableIndicationPanel.Location = RouletteMenuBtn.Location;
            roulette_Page.BringToFront();
        }

        private void WalletMenuBtn_Click(object sender, EventArgs e)
        {
           movableIndicationPanel.Location =  WalletMenuBtn.Location;
           wallet_Page.BringToFront();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void UpperPanelMouseDown(object sender, MouseEventArgs e)
        {
            finalPoint = new Point(e.X, e.Y);
        }

        private void UpperPanelMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - finalPoint.X;
                this.Top += e.Y - finalPoint.Y;
            }
        }

        private void LogoBoxMouseDown(object sender, MouseEventArgs e)
        {
            finalPoint = new Point(e.X, e.Y);
        }

        private void LogoPanelMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - finalPoint.X;
                this.Top += e.Y - finalPoint.Y;
            }
        }
        Point finalPoint;

        private void roulette_Page_Load(object sender, EventArgs e)
        {

        }
    }
}
