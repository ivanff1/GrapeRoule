using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using SqlFuncs;

namespace SqlFuncs
{
    public class ManageDB
    {
        public SqlConnection sqlCnn;
        private SqlDataAdapter da;
        private DataTable dt;
        
        public void setUp() {
            var file = File.OpenText("Properties.cn");
            string sqlCnnString = @"Data Source = NIKOLA-PC\SQLNIK; Initial catalog = GrapeRouleDB; Persist security info=True; User Id=sa; Password = " + "fori=0; Connection timeout = 6000;";
            sqlCnn = new SqlConnection(sqlCnnString);

            sqlCnn.Open();
            sqlCnn.Close();
        }

        public DataTable Select(string query, params string [] args) {
            sqlCnn.Open();
            SqlCommand sqlCmd = new SqlCommand(query, sqlCnn);
            
            for (int i = 0; i < args.Length; i++) {
                sqlCmd.Parameters.Add(args[i]);
            }

            da = new SqlDataAdapter(sqlCmd);

            dt = new DataTable();

            da.Fill(dt);

            sqlCmd.ExecuteNonQuery();
            sqlCnn.Close();

            return dt;
        }

        public void Insert(string query, params string [] args) {
            sqlCnn.Open();

            SqlCommand sqlCmd = new SqlCommand(query, sqlCnn);

            foreach (var arg in args) {
                sqlCmd.Parameters.Add(arg);
            }

            da = new SqlDataAdapter(sqlCmd);
            dt = new DataTable();

            da.Update(dt);

            sqlCmd.ExecuteNonQuery();

            sqlCnn.Close();
        }

        public void Update(string query, params string [] args) {
            sqlCnn.Open();
            SqlCommand sqlCmd = new SqlCommand(query, sqlCnn);

            foreach (var arg in args) {
                sqlCmd.Parameters.Add(arg);
            }

            da = new SqlDataAdapter(sqlCmd);

            dt = new DataTable();

            da.Update(dt);
            sqlCnn.Close();
        }

        public void Delete(string query, params string [] args) {
            sqlCnn.Open();
            SqlCommand sqlCmd = new SqlCommand(query, sqlCnn);

            foreach (var arg in args)
            {
                sqlCmd.Parameters.Add(arg);
            }

            da = new SqlDataAdapter(sqlCmd);

            dt = new DataTable();

            da.Update(dt);
            sqlCnn.Close();
        }
    }
}
