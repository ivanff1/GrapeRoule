using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlFuncs;

namespace GrapeRoule
{
    public partial class Register_Page : UserControl
    {
        public Register_Page()
        {
            InitializeComponent();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            ManageDB db = new ManageDB();
            db.setUp();
            string[] args = { "@UN", "@PW" };
            string[] values = { this.userNameTxtBox.Text, this.passwordTxtBox.Text };
            db.Insert("Insert Into GrapeClient (Username, Password) Values (@UN, @PW)", args, values);
        }
    }
}
