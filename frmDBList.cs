using Oracle.ManagedDataAccess.Client;
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
    public partial class frmDBList : Form
    {
        public frmDBList()
        {
            InitializeComponent();
        }

        private void frmDBList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.EGAIS_ES_POS_LIST". При необходимости она может быть перемещена или удалена.
            this.eGAIS_ES_POS_LISTTableAdapter.Fill(this.dataSet1.EGAIS_ES_POS_LIST);

        }

        private void frmDBList_MaximumSizeChanged(object sender, EventArgs e)
        {

        }

        private void eGAISESPOSLISTBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
