using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Data;
using System.Data.SqlClient;
using SqlFuncs;
using System.Threading;

namespace DBServer
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 4900);
            Dictionary<int, TcpClient> clients = new Dictionary<int, TcpClient>();
            ManageDB db = new ManageDB();
            db.setUp();
            listener.Start();
            int clientsCounter = 0;

            while (true){
                clients.Add(clientsCounter, listener.AcceptTcpClient());


            }
        }

        public void handleClient(TcpClient client){
            NetworkStream stream = client.GetStream();

            while (true)
            {
                byte[] info = new byte[1024];

                stream.Read(info, 0, info.Length);

                string query = Encoding.ASCII.GetString(info);

                
            }
        }
    }
}
