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
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }
        public string description= "";
        private void frmSales_Load(object sender, EventArgs e)
        {
            string zapros = "SELECT description FROM EXTERNAL.EGAIS_ES_POS_LIST WHERE client_id IS NOT NULL and description like '%mavt%'";
            var data =frmMain.Query(zapros);
            for (var i = 0; i < data.Rows.Count; i++)
            {
                cmdCompName.Items.Add(data.Rows[i][0].ToString());
            }
            int index;
            if (description == "")
            {
                index = 0;
            }
            else
            {
                cmdCompName.SelectedText = description;
                index = cmdCompName.SelectedIndex;
            }
            cmdCompName.SelectedIndex = index;
            datEnd.MinDate = datBegin.Value;
            datBegin.MaxDate = datEnd.Value;
            LoadSales(cmdCompName.Text.ToString().ToLower(),datBegin.Text.ToString(), datEnd.Text.ToString());
        }
        private void LoadSales(string comp, string dateBegin, string dateEnd)
        {
            string zapros = @"select sh.oper_time,oper_type,o.name,sp.price, sh.amount,cheque_url 
                            from external.egais_es_sales_headers sh, external.egais_es_sales_pos sp, object o, external.egais_es_pos_list pl  
                            where sh.client_id=sp.client_id and sp.nom_id=o.id and pl.client_id=sh.client_id and sp.oper_id = sh.oper_id and description = '" + comp + @"' and o.list_id = 'НОМ' 
                            and sh.oper_time between to_date('" + dateBegin + "','dd.mm.yyyy') and to_date('" + dateEnd + "23:59:59','dd.mm.yyyy hh24:mi:ss') order by sh.oper_time";
            var data = frmMain.Query(zapros);
            gridSales.Rows.Clear();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                string type;
                if (data.Rows[i][1].ToString() == "1")
                {
                    type = "продажа";
                }
                else
                {
                    type = "возврат";
                }
                gridSales.Rows.Add(data.Rows[i][0].ToString(),type, data.Rows[i][2].ToString(), data.Rows[i][3].ToString(), data.Rows[i][4].ToString());
                Recolor();
            }
        }
        private void cmdCompName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSales(cmdCompName.Text.ToString().ToLower(), datBegin.Text.ToString(), datEnd.Text.ToString());
        }

        private void datEnd_ValueChanged(object sender, EventArgs e)
        {
            datBegin.MaxDate = datEnd.Value;
            LoadSales(cmdCompName.Text.ToString().ToLower(), datBegin.Text.ToString(), datEnd.Text.ToString());
        }

        private void datBegin_ValueChanged(object sender, EventArgs e)
        {
            datEnd.MinDate = datBegin.Value;
            LoadSales(cmdCompName.Text.ToString().ToLower(), datBegin.Text.ToString(), datEnd.Text.ToString());
        }
        private void Recolor()
        {
            foreach (DataGridViewRow item in gridSales.Rows)
            {
                if (item.Index %2 !=0)
                    gridSales.Rows[item.Index].DefaultCellStyle.BackColor = Color.LightGray;
            }
        }
    }
}
