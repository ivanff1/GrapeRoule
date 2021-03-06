﻿using System;
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
        public Dictionary<int, string> wheel;
 
        public Server()
        {
            InitializeComponent();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wheel = new Dictionary<int, string>{
                {0, "green"},
                {1, "red"},
                {2, "black"},
                {3, "red"},
                {4, "black"},
                {5, "red"},
                {6, "black"},
                {7, "red"},
                {8, "black"},
                {9, "red"},
                {10, "black"},
                {11, "black"},
                {12, "red"},
                {13, "black"},
                {14, "red"},
                {15, "black"},
                {16, "red"},
                {17, "black"},
                {18, "red"},
                {19, "red"},
                {20, "black"},
                {21, "red"},
                {22, "black"},
                {23, "red"},
                {24, "black"},
                {25, "red"},
                {26, "black"},
                {27, "red"},
                {28, "black"},
                {29, "black"},
                {30, "red"},
                {31, "black"},
                {32, "red"},
                {33, "black"},
                {34, "red"},
                {35, "black"},
                {36, "red"}
            };

            listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 5000);
            clients = new Dictionary<int, TcpClient>();
            genNumber = generateNumber();

            //MessageBox.Show(genNumber.ToString(), wheel[genNumber]);
            
            int clientsCounter = 0;

            listener.Start();

            while (clientsCounter < 3)
            {
                clients.Add(clientsCounter, listener.AcceptTcpClient());
                clientsCounter++;
            }

            MessageBox.Show("Accepted!");
            
            bool [] responseValues = new bool[8];

            foreach (var client in clients.Values)
            {
                if (client.Connected)
                {
                    Thread t = new Thread(() => checkNumber(client, out responseValues[clientsCounter]));
                    t.Start();
                }

                else
                {
                    MessageBox.Show("Something is wrong..");
                }
            }
        }

        public int generateNumber() {
            Random r = new Random();
            return r.Next(0, 36);
        }

        public bool isEven(int number) {
            if (number % 2 == 0) {
                return true;
            }

            return false;
        }

        public void checkNumber(TcpClient client, out bool retVal) {
            NetworkStream stream = client.GetStream();

            byte[] clientInfo = new byte[1024];

            stream.Read(clientInfo, 0, clientInfo.Length);

            retVal = GetMessage(Encoding.ASCII.GetString(clientInfo));

            MessageBox.Show(Encoding.ASCII.GetString(clientInfo), genNumber.ToString());

            if (retVal)
            {
                stream.Write(Encoding.ASCII.GetBytes("You win!"), 0, "You win!".Length);
            }
            else {
                stream.Write(Encoding.ASCII.GetBytes("You lose!"), 0, "You lose!".Length);
            }

            stream.Close();
        }


        public bool GetMessage(string clientBet) {
            int betNum;

            if (clientBet == "red" || clientBet == "black")
            {
                if (wheel[genNumber] == clientBet)
                {
                    return true;
                }
                return false;
            }

            else if (clientBet == "even" || clientBet == "odd")
            {
                if (isEven(genNumber))
                {
                    return true;
                }

                return false;
            }

            Int32.TryParse(clientBet, out betNum);

            if (betNum == genNumber) {
                return true;
            }

            return false;
        }

        public void BroadcastMessage(string message) {
            byte[] info = Encoding.ASCII.GetBytes(message);

            foreach(TcpClient client in clients.Values){
                NetworkStream stream = client.GetStream();

                stream.Write(info, 0, info.Length);
                stream.Close();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
            BroadcastMessage("Game state changed!");
        }
    }
}
