using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrapeRouleClient;
using System.Threading;

namespace GrapeRouleClient
{
    public partial class Register_PageUC : UserControl
    {
        public Register_PageUC()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            Thread openMain = new Thread(OpenMainForm);
            openMain.Start();
            Application.Exit();
            
        }
        private void OpenMainForm()
        {
            Application.Run(new GrapeRouleMain());
        }

    }
}
