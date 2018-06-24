using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SqlFuncs;

namespace Client
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ManageDB db = new ManageDB();
            db.setUp();

            string [] args = {"@UN", "@PW"};
            string [] values = {this.txtUsername.Text, this.txtPassword.Text};
            DataTable dt = db.Select("Select * From GrapeClient Where Username = @UN And Password = @PW", args, values);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Incorrect credentials!");
            }
            else {
                MessageBox.Show("Sucessfully logged in...");
                Credentials.Username = dt.Columns["Username"].ToString();
                Credentials.Password = dt.Columns["Password"].ToString();
                new Client().Show();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new Register().Show();
        }
    }
}
