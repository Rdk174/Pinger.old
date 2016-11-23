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
using log4net;
using System.Text.RegularExpressions;

namespace Pinger
{
    public partial class frmReg : Form
    {
        public frmReg()
        {
            InitializeComponent();
        }
        private static readonly log4net.ILog log =
        LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static System.Data.DataTable SelectQuery(string query)
        {
            OracleConnection connect = new OracleConnection(Properties.Settings.Default.Connection);
            System.Data.DataTable result = new System.Data.DataTable();
            try
            {
                connect.Open();
                OracleCommand command = new OracleCommand(query, connect);
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при подключении к базе данных", "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(ex);
            }
            finally
            {
                if (connect.State != ConnectionState.Closed)
                    connect.Close();
            }
            return result;
        }
        public static void UpdateQuery(string query)
        {
            OracleConnection connect = new OracleConnection(Properties.Settings.Default.Connection);
            OracleCommand command = new OracleCommand();
            OracleTransaction tr;
            connect.Open();
            tr = connect.BeginTransaction();
            bool succes = true;
            try
            {
                command = new OracleCommand(query, connect);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при регистрации планшета", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(ex);
                tr.Rollback();
                succes = false;
            }
            finally
            {
                if (succes)
                {
                    tr.Commit();
                    MessageBox.Show("Планшет успешно зарегистрирован", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (connect.State != ConnectionState.Closed)
                {
                    connect.Close();
                }
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            var st = cmbName.Text;
            string template = "[0-9]+[0-9]+[0-9]+[0-9]";
            var re = new Regex(template);
            MatchCollection mc = re.Matches(st);
            string name = mc[0].ToString();
            string query = @"update external.egais_es_pos_list set"
                     + " ts = 'Телефон техподдержки: " + txtTS.Text + "',"
                     + " client_id = '" + txtAP.Text + "',"
                     + " date_begin = trunc(sysdate - 1),"
                     + " date_end = trunc(sysdate + 10000),"
                     + " description = '" + cmbName.Text.ToLower() + "',"
                     + " suppliers_inns = '7453002440, 7453191902, 7449050761',"
                     + " fsrar_id = '" + txtFsrarID.Text + "'"
                     + " where reg_id = '" + listRegid.SelectedItem.ToString()+"'"
                     + " and description like '%" + name + "%'";
            textBox1.Text = query.Normalize();

        }

        private void frmReg_Load(object sender, EventArgs e)
        {
            string query = "SELECT description FROM EXTERNAL.EGAIS_ES_POS_LIST WHERE client_id IS NULL";
            var data = SelectQuery(query);
            for (var i = 0; i < data.Rows.Count; i++)
            {
                cmbName.Items.Add(data.Rows[i][0].ToString());
            }
        }

        private void cmbName_DisplayMemberChanged(object sender, EventArgs e)
        {
         
        }

        private void cmbName_TextChanged(object sender, EventArgs e)
        {
            listRegid.Items.Clear();
            string query = @"SELECT reg_id FROM EXTERNAL.EGAIS_ES_POS_LIST
                            WHERE client_id IS NULL
                            and Description = '"+cmbName.Text+"'";
            var data = SelectQuery(query);
            for(var i = 0; i < data.Rows.Count; i++)
            {
                listRegid.Items.Add(data.Rows[i][0].ToString());
            }
            listRegid.SelectedIndex = 0;
        }

        private void txtFsrarID_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnAP_Click(object sender, EventArgs e)
        {
            if (txtKpp.Text == "")
            {
                MessageBox.Show("Введите КПП", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if  (txtFsrarID.Text== "")
            {
                MessageBox.Show("Введите номер регистрации ЕГАИС", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string query = @"select a.subj_list_id || '.' || a.subj_id || '.' || a.addr_type_id || '.1', a.* 
                            from subject_address a 
                            where subj_list_id = 'ОР14' 
                                and egais_id='" + txtFsrarID.Text + "'"
                                + "and kpp = '" + txtKpp.Text + "'";
                var data = SelectQuery(query);
                if (data.Rows.Count>0)
                {
                    txtAP.Text = data.Rows[0][0].ToString();
                }
                else
                {
                    txtAP.Text = "АП не найден";
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtAP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listRegid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            var st = cmbName.Text;
            string template = "[0-9]+[0-9]+[0-9]+[0-9]";
            var re = new Regex(template);
            MatchCollection mc = re.Matches(st);
            string name = mc[0].ToString();
            string query = @"update external.egais_es_pos_list set"
                     + " ts = 'Телефон техподдержки: " + txtTS.Text + "',"
                     + " client_id = '" + txtAP.Text + "',"
                     + " date_begin = trunc(sysdate - 1),"
                     + " date_end = trunc(sysdate + 10000),"
                     + " description = '" + cmbName.Text.ToLower() + "',"
                     + " suppliers_inns = '7453002440, 7453191902, 7449050761',"
                     + " fsrar_id = '" + txtFsrarID.Text + "'"
                     + " where reg_id = '" + listRegid.SelectedItem.ToString() + "'"
                     + " and description like '%" + name + "%'";
            UpdateQuery(query); 
        }
    }
}
