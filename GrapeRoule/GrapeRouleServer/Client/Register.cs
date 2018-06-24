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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ManageDB db = new ManageDB();
            db.setUp();
            string [] args = {"@UN", "@PW"};
            string [] values = {this.txtUsername.Text, this.txtPassword.Text};
            db.Insert("Insert Into GrapeClient (Username, Password) Values (@UN, @PW)", args, values);
            MessageBox.Show("Successfully logged in!");
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
