using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace SqlFuncs
{
    public class ManageDB
    {
        private SqlConnection sqlCnn;
        private SqlDataAdapter da;
        private DataTable dt;


        public void setUp() {
            var file = File.OpenText("Properties.cn");
            string sqlCnnString = @"Data Source = " + file.ReadLine() + "; Initial catalog = GrapeRoule; Persist security info=True; User Id=sa; Password = " + file.ReadLine() + "; Connection timeout = 6000;";
            sqlCnn = new SqlConnection(sqlCnnString);

            sqlCnn.Open();
            sqlCnn.Close();
        }

        public void Select(string query, params string [] args) {
            SqlCommand sqlCmd = new SqlCommand(query, sqlCnn);
            
            for (int i = 0; i < args.Length; i++) {
                sqlCmd.Parameters.Add(args[i]);
            }

            da = new SqlDataAdapter(sqlCmd);

            dt = new DataTable();

            da.Fill(dt);
        }

        public override void Select(){
            
        }

        public void Insert() { 
            
        }

        public void Update() { 
            
        }

        public void Delete() { 
            
        }
    }
}
