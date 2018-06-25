using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrapeRoule
{
    public partial class SignForm : Form
    {
        public SignForm()
        {
            InitializeComponent();
        }

        private void register_Page1_Load(object sender, EventArgs e)
        {

        }

        private void regLabel_Click(object sender, EventArgs e)
        {
            register_Page.BringToFront();
        }
    }
}
