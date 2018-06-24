using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using SqlFuncs;

namespace Client
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        public TcpClient client;


        private void Client_Load(object sender, EventArgs e)
        {
            client = new TcpClient();
            client.Connect(IPAddress.Parse("127.0.0.1"), 5000);
            MessageBox.Show("Connected!");
            this.lblUser.Text = Credentials.Username;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            NetworkStream stream = client.GetStream();

            stream.Write(Encoding.ASCII.GetBytes(this.txtBet.Text), 0, this.txtBet.Text.Length);

            byte[] info = new byte[1024];

            stream.Read(info, 0, info.Length);

            this.lblWinLoss.ForeColor = Color.Red;
            this.lblWinLoss.Text = Encoding.ASCII.GetString(info);
        }

        private void btnFunds_Click(object sender, EventArgs e)
        {
            /*ManageDB db = new ManageDB();
            db.setUp();
            string [] args = {"@UN", "@PW"};
            string [] values = {};
            int funds = db.Select("Select * From GrapeClient", );
             * */
        }
    }
}
