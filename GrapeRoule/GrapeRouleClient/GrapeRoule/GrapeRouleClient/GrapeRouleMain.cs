using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrapeRouleClient
{
    public partial class GrapeRouleMain : Form
    {
        public GrapeRouleMain()
        {
            InitializeComponent();
            home_PageUC.BringToFront();
            indicationPanel.Location = homeBtn.Location;
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            home_PageUC.BringToFront();
            indicationPanel.Location = homeBtn.Location;
        }

        private void RouletteBtn_Click(object sender, EventArgs e)
        {
            roulette_PageUC.BringToFront();
            indicationPanel.Location = rouletteBtn.Location;

        }

        private void WalletBtn_Click(object sender, EventArgs e)
        {

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

        private void LogoMouseDown(object sender, MouseEventArgs e)
        {
            finalPoint = new Point(e.X, e.Y);
        }

        private void LogoMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - finalPoint.X;
                this.Top += e.Y - finalPoint.Y;
            }
        }
        Point finalPoint;
    }
}
