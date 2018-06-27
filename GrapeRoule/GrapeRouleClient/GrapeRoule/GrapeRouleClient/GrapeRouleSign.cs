using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrapeRouleClient
{
    public partial class GrapeRouleSign : Form
    {
        public GrapeRouleSign()
        {
            InitializeComponent();
        }


        private void RegisterLabelLink_Click(object sender, EventArgs e)
        {
            register_PageUC.BringToFront();
        }

        private void LoginLabelLink_Click(object sender, EventArgs e)
        {
            login_PageUC1.BringToFront();
        }
    }
}
