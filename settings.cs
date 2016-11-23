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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }
        private void SetValues()
        {
            checkBoxRefresh.Checked = Properties.Settings.Default.AllowAutoUpdate;
            int interval = 0;
            interval = Properties.Settings.Default.TimerAutoUpdate / 60000;
            txtInterval.Text = interval.ToString();
            checkBoxVNC.Checked = Properties.Settings.Default.AllowUltraVNC;
            txtPath.Text = Properties.Settings.Default.PathUltraVNC;
            if (Properties.Settings.Default.AllowPagesiteUTM)
            {
                radioButtonHard.Checked = true;
            }
            else
            {
                radioButtonSimple.Checked = true;
            }
           
        }
        private void checkBoxRefresh_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRefresh.Checked == true)
            {
                txtInterval.Enabled = true;
            }
            else
            {
                txtInterval.Enabled = false;

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVNC.Checked == true)
            {
                txtPath.Enabled = true;
            }
            else
            {
                txtPath.Enabled = false;

            }
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = openFileDialog.FileName;
            }
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            radioButtonSimple.Checked = false;
            radioButtonHard.Checked = false;
            SetValues();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Восстановить настройки по-умолчанию?", "Сброс", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Properties.Settings.Default.Reset();
                SetValues();
                this.Refresh();
            }
        }

        private void txtInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void txtPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сохранить настройки", "Сохранить", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Properties.Settings.Default.AllowAutoUpdate = checkBoxRefresh.Checked;
                Properties.Settings.Default.TimerAutoUpdate = int.Parse(txtInterval.Text) * 60000;
                Properties.Settings.Default.AllowUltraVNC = checkBoxVNC.Checked;
                Properties.Settings.Default.PathUltraVNC = txtPath.Text;
                if (radioButtonHard.Checked)
                {
                    Properties.Settings.Default.AllowPagesiteUTM = true;
                }
                else
                {
                    Properties.Settings.Default.AllowPagesiteUTM = false;
                }
                frmMain main = this.Owner as frmMain;
                main.ultraVNCToolStripMenuItem.Visible= checkBoxVNC.Checked;
                main.ultraVNCToolStripMenuItem.Enabled= checkBoxVNC.Checked;
                Properties.Settings.Default.Save();
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
