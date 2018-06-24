using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Data;
using System.Data.SqlClient;
using SqlFuncs;

namespace DBServer
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 4900);
            
            ManageDB db = new ManageDB();
            db.setUp();

        }
    }
}
