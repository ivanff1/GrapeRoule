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
using System.Threading;
using System.IO;
using SqlFuncs;

namespace Server
{
    public partial class Server : Form
    {
        TcpListener listener;
        public int genNumber;
        public Dictionary<int, TcpClient> clients;
 
        public Server()
        {
            InitializeComponent();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listener = new TcpListener(IPAddress.Any, 5000);
            clients = new Dictionary<int, TcpClient>();
            genNumber = generateNumber();

            //SqlFuncs.ManageDB db = new ManageDB();
            //db.setUp();

            MessageBox.Show("Hi");
            int clientsCounter = 0;

            listener.Start();

            while (true) {
                clients.Add(clientsCounter, listener.AcceptTcpClient());
                bool [] responseValues = new bool[8];

                foreach (var client in clients.Values)
                {
                    Thread t = new Thread(() => checkNumber(client, out responseValues[clientsCounter]));
                    t.Start();
                }

                clientsCounter++;
            }

        }

        public int generateNumber() {
            Random r = new Random();
            return r.Next(0, 36);
        }

        public void checkNumber(TcpClient client, out bool retVal) {
            NetworkStream stream = client.GetStream();

            //тук ще се случва декриптирането на стрийма

            byte [] clientInfo = new byte[1024];

            stream.Read(clientInfo, 0, clientInfo.Length);

            int clientNum = Convert.ToInt32(Encoding.ASCII.GetString(clientInfo));

            if (clientNum == genNumber)
            {
                retVal = true;
            }
            else {
                retVal = false;
            }

            stream.Write(Encoding.ASCII.GetBytes("True!"), 0, "True".Length);
            stream.Close();
        }
    }
}
