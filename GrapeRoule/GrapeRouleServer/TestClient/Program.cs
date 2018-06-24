using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient client = new TcpClient();
            client.Connect(IPAddress.Parse("127.0.0.1"), 5000);
            Console.WriteLine("Connected successfully!");

            NetworkStream stream = client.GetStream();
            string info = Console.ReadLine();
            stream.Write(Encoding.ASCII.GetBytes(info), 0, info.Length);

            byte[] income = new byte[1024];
            stream.Read(income, 0, income.Length);
            Console.WriteLine(Encoding.ASCII.GetString(income));
            Console.ReadLine();
        }
    }
}
