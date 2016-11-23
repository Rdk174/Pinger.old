using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pinger
{
    public partial class frmUTM : Form
    {
        public frmUTM()
        {
            InitializeComponent();
        }

        private void frmUTM_Load(object sender, EventArgs e)
        {
            frmMain main = Owner as frmMain;
            this.Text = "УТМ " + main.gridAddresses.Rows[main.gridAddresses.CurrentRow.Index].Cells[4].Value.ToString()+": " + Properties.Settings.Default.UTMPort;
            string IP = main.gridAddresses.Rows[main.gridAddresses.CurrentRow.Index].Cells[4].Value.ToString();
            webBrowser.Navigate(new Uri("http://" + IP + ":" + Properties.Settings.Default.UTMPort + "/"));
        }
    }
}
