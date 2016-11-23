using HtmlAgilityPack;
using log4net;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Excell = Microsoft.Office.Interop.Excel.Application;

namespace Pinger
{
    public partial class frmMain : Form
    {
        private static readonly log4net.ILog log =
        LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        const uint WM_SETTEXT = 0x000C;
        private Excell application;
        private Workbook workBook;
        private Worksheet worksheet;
        public Thread refreshThread;
        public Thread loadThread;
        public frmMain()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WinAPI.WM_SHOWME)
            {
                ShowMe();
            }
            base.WndProc(ref m);
        }
        private void ShowMe()
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                notifyIcon1.Visible = false;
            }
            // get our current "TopMost" value (ours will always be false though)
            bool top = TopMost;
            // make our form jump to the top of everything
            TopMost = true;
            // set it back to whatever it was
            TopMost = top;
        }

        public bool isDocChanged { get; set; }
        public Bitmap SetPicture(string IPAdress, int timer)
        {
            Ping ping = new Ping();
            PingReply pingReply = ping.Send(IPAdress, timer);
            return pingReply.Status == IPStatus.Success
                ? Properties.Resources.green
                : Properties.Resources.red;
        }
        List<Resource> GridToArray()
        {
            var result = new List<Resource>();
            for (var i = 0; i < gridAddresses.Rows.Count; i++)
            {
                result.Add(new Resource()
                {
                    Id = int.Parse(gridAddresses.Rows[i].Cells[0].Value.ToString()),
                    Name = gridAddresses.Rows[i].Cells[1].Value.ToString(),
                    OOO = gridAddresses.Rows[i].Cells[2].Value.ToString(),
                    Address = gridAddresses.Rows[i].Cells[3].Value.ToString(),
                    IP = gridAddresses.Rows[i].Cells[4].Value.ToString(),
                    Port = gridAddresses.Rows[i].Cells[5].Value.ToString(),
                    UTMVer = gridAddresses.Rows[i].Cells[7].Value.ToString(),
                    PKI = gridAddresses.Rows[i].Cells[8].Value.ToString(),
                    Gost = gridAddresses.Rows[i].Cells[9].Value.ToString()
                });
            }
            return result;
        }
        public void SaveDoc(string filePath)
        {
            //Properties.Settings.Default.filePath = saveFileDialog.FileName;
            if (File.Exists(filePath)) File.Delete(filePath);
            var result = GridToArray();
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                using (JsonWriter jw = new JsonTextWriter(sw))
                { 
                    JsonSerializer js = new JsonSerializer();
                    js.Formatting = Formatting.Indented;
                    js.Serialize(jw, result);
                    timerRLabel.Enabled = true;
                    toolStripStatusLabel.Text = "Сохранение прошло успешно";
                }
            }
        }

        public void LoadDoc(object filePath)
        {
            //Properties.Settings.Default.filePath = openFileDialog.FileName;
            //Invoke(new System.Action(() =>
            //{
            //    gridAddresses.Rows.Clear();
            //    timerRefresh.Enabled = true;
            //    toolStripStatusLabel.Text = "Идет загрузка файла, пожалуйста подождите";
            //    toolStripProgressBar.Visible = true;
            //}));
            timerRefresh.Enabled = true;
            toolStripStatusLabel.Text = "Идет загрузка файла, пожалуйста подождите";
            using (StreamReader sr = new StreamReader(filePath.ToString()))
            {
                    using (JsonReader jr = new JsonTextReader(sr))
                    {
                        JsonSerializer js = new JsonSerializer();
                        js.Formatting = Formatting.Indented;
                        var data = js.Deserialize<List<Resource>>(jr);
                        Invoke(new System.Action(() =>
                        {
                            var bs = new BindingSource();
                            bs.DataSource = data;
                            gridAddresses.DataSource = bs;
                            columnIndex.DataPropertyName = "Id";
                            columnName.DataPropertyName = "Name";
                            columnOOO.DataPropertyName = "OOO";
                            columnAdress.DataPropertyName = "Address";
                            columnIPAdres.DataPropertyName = "IP";
                            columnPort.DataPropertyName = "Port";
                            columnUTM.DataPropertyName = "UTMVer";
                            columnPKI.DataPropertyName = "PKI";
                            columnGost.DataPropertyName="Gost";
                            toolStripProgressBar.Maximum = data.Count;
                            toolStripProgressBar.Step = toolStripProgressBar.Maximum / data.Count;
                        }));
                        //foreach (var item in data)
                        //{
                        //var picture = SetPicture(item.IP, 10);
                        //Invoke(new System.Action(() =>
                        //{
                        //    gridAddresses.Rows.Add(item.Id, item.Name, item.OOO, item.Address, item.IP, picture, item.UTMVer, item.PKI, item.Gost);
                        //    Recolor(item.Id - 1);
                        //    toolStripProgressBar.PerformStep();
                        //    statusStrip1.Refresh();
                        //}));
                        //}
                        //Invoke(new System.Action(() =>
                        //{
                        //    timerRLabel.Enabled = true;
                        //    toolStripProgressBar.Visible = false;
                        //    toolStripStatusLabel.Text = "Файл загружен";
                        //    timerBaloon.Enabled = true;
                        //}));
                    }
                Recolor();
                timerBaloon.Enabled = true;
                //timerRLabel.Enabled = true;
                toolStripStatusLabel.Text = "Файл загружен";
                //refreshThread = new Thread(new ThreadStart(RefreshTable));
                //refreshThread.Start();
              }
        }
        public int Search(string str)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            BindingSource bns = new BindingSource();
            foreach (DataGridViewColumn col in gridAddresses.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in gridAddresses.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }
            bns.DataSource = dt;
            //dt.DefaultView.RowFilter = "like '%" + str.Trim() + "%' ";
            int position = 0;
            foreach (DataGridViewColumn col in gridAddresses.Columns)
            {
                if (bns.Find(col.Name, str) > 0)
                {
                    position = bns.Find(col.Name, str);
                }
            }
            return position;
        }
        public void Recolor()
        {
            TimeSpan raznica= DateTime.Now- DateTime.Now;
            foreach (DataGridViewRow item in gridAddresses.Rows)
            {
                if (gridAddresses[11, item.Index].EditedFormattedValue.ToString() != "")
                {
                    DateTime sync = DateTime.Parse(gridAddresses[11, item.Index].EditedFormattedValue.ToString());
                    raznica = DateTime.Now - sync;
                }
                if (item.Index % 2 != 0 && raznica.Days<2 && gridAddresses[11, item.Index].EditedFormattedValue.ToString() != "")
                {
                    gridAddresses.Rows[item.Index].DefaultCellStyle.BackColor = Color.LightGray;
                }
                else if (raznica.Days >=2 || gridAddresses[11, item.Index].EditedFormattedValue.ToString() == "")
                {
                    gridAddresses.Rows[item.Index].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    gridAddresses.Rows[item.Index].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }
        public void Recolor(int index)
        {
            if (index % 2 != 0)
            {
                gridAddresses.Rows[index].DefaultCellStyle.BackColor = Color.LightGray;
            }
            else
            {
                gridAddresses.Rows[index].DefaultCellStyle.BackColor = Color.White;
            }
        }
        public string getRequest(string url)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.AllowAutoRedirect = false;//Запрещаем автоматический редирект
                httpWebRequest.Method = "GET"; //Можно не указывать, по умолчанию используется GET.
                httpWebRequest.Referer = "http://google.com"; // Реферер. Тут можно указать любой URL
                using (var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    using (var stream = httpWebResponse.GetResponseStream())
                    {
                        using (var reader = new StreamReader(stream, Encoding.GetEncoding(httpWebResponse.CharacterSet)))
                        {
                            return reader.ReadToEnd();
                        }
                    }
                }
            }
            catch
            {
                return String.Empty;
            }
        }
        public string[] Parser(string url)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(getRequest(url));
            string[] result = new string[3];
            try
            {
                HtmlNodeCollection c = doc.DocumentNode.SelectNodes("//div[@class='tab-pane fade in active']/pre");
                var st = c[0].InnerText.Normalize();
                string version_template = "[0-9]+.[0-9]+.[0-9]+";
                string date_template = "[0-9]+-[0-9]+-[0-9]+";
                var re = new Regex(@version_template);
                MatchCollection mc = re.Matches(st);
                result[0] = mc[0].ToString();
                if (c.Count > 1)
                {
                    st = c[c.Count - 2].InnerText.Normalize();
                    re = new Regex(@date_template);
                    mc = re.Matches(st);
                    result[1] = mc[mc.Count - 1].ToString();
                    st = c[c.Count - 1].InnerText.Normalize();
                    mc = re.Matches(st);
                    result[2] = mc[mc.Count - 1].ToString();
                }
                else
                {
                    result[1] = "";
                    result[2] = "";
                }
                return result;
            }
            catch(Exception err)
            {
                //MessageBox.Show("Не удалось получить данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(err);
                result[0] = result[1] = result[2] = "";
                return result;
            }
        }
        private void txtSearch_Click(object sender, EventArgs e)
        {


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int i;
            bool valid=true;
            if (gridAddresses.Rows.Count == 0)
            {
                i = 0;
            }
            else
            {
                i = int.Parse(gridAddresses.Rows[gridAddresses.Rows.Count - 1].Cells[0].Value.ToString());
            }
            if (ipAddressControl1.Text == "..." || ipAddressControl1.Text == "0.0.0.0")
            {
                MessageBox.Show("Введите IP адрес","Внимание",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (txtPort.Text == "")
            {
                MessageBox.Show("Введите порт", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (DataGridViewRow item in gridAddresses.Rows)
                {
                    if (ipAddressControl1.Text == gridAddresses.Rows[item.Index].Cells[4].Value.ToString())
                    {
                        MessageBox.Show("Ресурс с таким IP адрессом уже существует", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        valid = false;
                    }
                }
                if(valid)
                {
                    var picture = SetPicture(ipAddressControl1.Text, 10);
                    //gridAddresses.Rows.Add(i + 1,
                    //    txtName.Text,
                    //    txtOOO.Text,
                    //    txtAdress.Text,
                    //    ipAddressControl1.Text,
                    //    picture, " ", " ", " ");
                    BindingSource bs = (BindingSource)gridAddresses.DataSource;
                    bs.Add(new Resource()
                    {
                        Id = i + 1,
                        Name = txtName.Text,
                        OOO = txtOOO.Text,
                        Address = txtAdress.Text,
                        IP = ipAddressControl1.Text,
                        Port = txtPort.Text,
                        UTMVer = "",
                        PKI = "",
                        Gost = ""
                    });
                    bs.EndEdit();
                    gridAddresses[6, i].Value = picture;
                    Thread oneutmThread = new Thread(new ParameterizedThreadStart(OneUTM));
                    string[] parameters = new string[2];
                    parameters[0] = gridAddresses[4, i].Value.ToString();
                    parameters[1] = i.ToString();
                    Recolor(i);
                    isDocChanged = true;
                    txtName.Text = "";
                    txtOOO.Text = "";
                    txtAdress.Text = "";
                    timerRefresh.Enabled = true;
                    ipAddressControl1.Text = "0.0.0.0";
                    Recolor(i);
                }
            }
        }
        public void RefreshTable()
        {
            if (gridAddresses.Rows.Count != 0)
            {
                Invoke(new System.Action(() =>
                {
                    toolStripStatusLabel.Text = "Идет обновление данных, пожалуйста подождите";
                    Refresh();
                    toolStripProgressBar.Visible = true;
                    toolStripProgressBar.Value = 0;
                    toolStripProgressBar.Step = toolStripProgressBar.Maximum / gridAddresses.Rows.Count;
                }));
                foreach (DataGridViewRow item in gridAddresses.Rows)
                {
                    Invoke(new System.Action(() =>
                    {
                        toolStripProgressBar.PerformStep();
                        statusStrip1.Refresh();
                    }));
                    var picture = SetPicture(gridAddresses.Rows[item.Index].Cells[4].Value.ToString(), 3000);
                    Invoke(new System.Action(() =>
                    {
                        gridAddresses.Rows[item.Index].Cells[6].Value = picture;
                    }));
                }
                Invoke(new System.Action(() =>
                {
                    toolStripStatusLabel.Text = "Готово";
                    toolStripProgressBar.Visible = false;
                    toolStripProgressBar.Value = 0;
                }));
            }
        }
        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.AllowAutoUpdate)
            {
                refreshThread = new Thread(new ThreadStart(RefreshTable));
                refreshThread.Start();
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveDoc(saveFileDialog.FileName);
                    isDocChanged = false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Не удалось сохранить файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(error);
            }
        }

        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    loadThread = new Thread(new ParameterizedThreadStart(LoadDoc));
                    loadThread.Start(openFileDialog.FileName);
                    SyncMavt();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Не удалось открыть файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(error);
            }
        }

        private void новыйСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Создать новый список?", "Новый", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (gridAddresses.Rows.Count != 0 && isDocChanged)
                {
                    if (MessageBox.Show("Сохранить список перед закрытием?", "Сохранить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (saveFileDialog.ShowDialog() == DialogResult.OK) SaveDoc(saveFileDialog.FileName);
                        gridAddresses.Rows.Clear();
                    }
                    else
                    {
                        gridAddresses.Rows.Clear();
                    }
                }
                else
                {
                    gridAddresses.Rows.Clear();
                }
            }
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void CloseExcel()
        {
            if (application != null)
            {
                int excelProcessId = -1;
                WinAPI.GetWindowThreadProcessId(application.Hwnd, ref excelProcessId);

                //Marshal.ReleaseComObject(worksheet);
                //workBook.Close();
                //Marshal.ReleaseComObject(workBook);
                //application.Quit();
                //Marshal.ReleaseComObject(application);

                application = null;
                // Прибиваем висящий процесс
                try
                {
                    Process process = Process.GetProcessById(excelProcessId);
                    process.Kill();
                }
                finally { }
            }
        }



        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (gridAddresses.Rows.Count != 0 && isDocChanged)
            {
                if (MessageBox.Show("Сохранить список перед закрытием?", "Сохранить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK) SaveDoc(saveFileDialog.FileName);
                    gridAddresses.Rows.Clear();
                }
            }
            notifyIcon1.Visible = false;
            CloseExcel();
            Environment.Exit(0);
        }
        private int[] CountKeys(int currentMonth)
        {
            int[] result = new int[2];
            int amount = 0;
            while (amount == 0)
            {
                currentMonth++;
                foreach (DataGridViewRow row in gridAddresses.Rows)
                {
                    int month; ;
                    var date = gridAddresses[9, row.Index].Value.ToString();
                    date = date.Replace("-", ".");
                    if (date != "")
                    {
                        month = DateTime.Parse(date).Month;
                        if (month == currentMonth) amount++;
                    }
                }
            }
            result[0] = amount;
            result[1] = currentMonth;
            return result;
        }
        private string SetBaloonText(string variant)
        {
            string str="";
            switch (variant)
            {
                case "start":
                    if (DateTime.Now.Hour >= 7 && DateTime.Now.Hour < 12)
                    {
                        str = "Доброе утро!";
                    }
                    else if(DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 17)
                    {
                        str = "Добрый день!";
                    }
                    else if(DateTime.Now.Hour >= 17 && DateTime.Now.Hour < 24)
                    {
                        str = "Добрый вечер!";
                    }
                    else
                    {
                        str = "Жаль";
                    }
                    break;
                case "keys":
                    var result = CountKeys(DateTime.Now.Month);
                    var month = new DateTime(DateTime.Now.Year, result[1], DateTime.Now.Day).ToString("MMMM");
                    str = "Колличество ключей истекающих в следующем месяце("+ month +"): " +result[0].ToString();
                    break;                    
            }
            return str;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            isDocChanged = false;
            gridAddresses.AutoGenerateColumns = false;
            timerRefresh.Interval = Properties.Settings.Default.TimerAutoUpdate;
            notifyIcon1.BalloonTipText = SetBaloonText("start");
            
            if (File.Exists(Environment.CurrentDirectory + "\\Планшеты мавт.json"))
            {
                //loadThread = new Thread(new ParameterizedThreadStart(LoadDoc));
                //loadThread.Start(Environment.CurrentDirectory + "\\Планшеты мавт.json");
                LoadDoc(Environment.CurrentDirectory + "\\Планшеты мавт.json");
            }
            ultraVNCToolStripMenuItem.Visible = Properties.Settings.Default.AllowUltraVNC;
            ultraVNCToolStripMenuItem.Enabled = Properties.Settings.Default.AllowUltraVNC;
            SyncMavt();
            timerReloadServ.Enabled = true;
            notifyIcon1.ShowBalloonTip(1);
        }

        private void timerRLabel_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Готово";
            timerRLabel.Enabled=false;
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            timerRefresh.Start();
            //txtSearch.Text = "Введите наименование, адрес или IP адрес";
            //txtSearch.Font = new Font(txtSearch.Font, FontStyle.Italic);
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void toolStripMenuItemPing_Click(object sender, EventArgs e)
        {
            timerRefresh.Enabled = false;
            frmPing f = new frmPing();
            f.Owner = this;
            f.ShowDialog();
        }
        public void OneUTM(object parameters)
        {
            string[] param = (string[])parameters;
            var IP = param[0];
            var Port = param[1];
            var url = "http://" + IP + ":" + Port + "/";
            var result = Parser(url);
            int index = int.Parse(param[2]);
            Invoke(new System.Action(() =>
            {
                if (result[0] != "")
                {
                    gridAddresses[7, index].Value = result[0];
                    gridAddresses[8, index].Value = result[1];
                    gridAddresses[9, index].Value = result[2];
                }
            }));
        }

        private void uTMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridAddresses[7, gridAddresses.CurrentRow.Index].Value.ToString() != " ")
            {
                Thread oneutmThread = new Thread(new ParameterizedThreadStart(OneUTM));
                string[] parameters = new string[3];
                parameters[0] = gridAddresses[4, gridAddresses.CurrentRow.Index].Value.ToString();
                parameters[1]= gridAddresses[5, gridAddresses.CurrentRow.Index].Value.ToString();
                parameters[2] = gridAddresses.CurrentRow.Index.ToString();
                
                oneutmThread.Start(parameters);
            }
            if (Properties.Settings.Default.AllowPagesiteUTM)
            {
                timerRefresh.Enabled = false;
                frmUTM f = new frmUTM();
                f.Owner = this;
                f.ShowDialog();
            }
            else
            {
                string IP = gridAddresses.Rows[gridAddresses.CurrentRow.Index].Cells[4].Value.ToString();
                string Port = gridAddresses.Rows[gridAddresses.CurrentRow.Index].Cells[5].Value.ToString();
                WebRequest request = WebRequest.Create("http://" + IP+":" + Port+"/");
                try
                {
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    if (response == null || response.StatusCode != HttpStatusCode.OK)
                    {
                        MessageBox.Show("УТМ по адресу: " + IP+": " + Port+" не запущен", "УТМ " + IP, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("УТМ по адресу: " + IP + ": " + Port + " запущен", "УТМ " + IP, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    response.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Не удалось соедениться с указанным узлом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    log.Error(error);
                }
            }
        }
        private void ultraVNCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.AllowUltraVNC)
            {
                timerRefresh.Enabled = false;
                string path = Properties.Settings.Default.PathUltraVNC;
                var ip = gridAddresses.Rows[gridAddresses.CurrentRow.Index].Cells[4].Value.ToString();
                try
                {
                    Process.Start(path, ip);
                }
                catch (Exception err)
                {
                    MessageBox.Show("Не удалось запусть UltraVNC, проверьте правильность пути: " + path + " и повторите попытку",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    log.Error(err);
                }

            }
            //var mainHandle = WinAPI.FindWindow(null, "UltraVNC Viewer - 1.2.1.1");
            //var comboboxHandle = WinAPI.FindWindowEx((IntPtr)mainHandle, (IntPtr)0, "ComboBox",null);
            //var editHandle = WinAPI.FindWindowEx((IntPtr)comboboxHandle, (IntPtr)0, "Edit",null);
            //var ip = gridAdresses.Rows[gridAdresses.CurrentRow.Index].Cells[3].Value.ToString();
            //WinAPI.SendMessage(editHandle, WM_SETTEXT, 1, ip);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            timerRefresh.Stop();
            txtSearch.Text = "";
            txtSearch.Font = new System.Drawing.Font(txtSearch.Font, FontStyle.Regular);
        }

        int index = -1;
        bool found = false;
        private int Find(string text)
        {
            int _index;
            for (_index = 0; _index < gridAddresses.Rows.Count;_index++)
            {
                for (var j = 0; j < gridAddresses.Columns.Count; j++)
                {
                    if (gridAddresses[j, _index].FormattedValue.ToString().ToLower().
                       Contains(text.ToLower().Trim()))
                    {
                        found = true;
                        return _index;
                    }
                }
            }
            if (found)
            {
                index = _index;
                return _index;
            }
            else return 0;
        }
        private int FindNext(string text, int _index)
        {
            if (index < 0)
            {
                _index = 0;
            }
            for (var i = _index+1; i < gridAddresses.Rows.Count; i++)
            {
                for (var j = 0; j < gridAddresses.Columns.Count; j++)
                {
                    if (gridAddresses[j, i].FormattedValue.ToString().ToLower().
                       Contains(text.ToLower().Trim()))
                    {
                        found = true;
                        _index = i;
                        return _index;
                    }
                }
            }
            if (found)
            {
                index = _index;
                return _index;
            }
            else
            {
                index = -1;
                return index;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                if (index < 0)
                {
                    index = Find(txtSearch.Text);
                    gridAddresses.CurrentCell = gridAddresses[0, index];
                }
                else
                {
                    found = false;
                    index = FindNext(txtSearch.Text, index);
                    if (index < 0)
                    {
                        index = Find(txtSearch.Text);
                    }
                    gridAddresses.CurrentCell = gridAddresses[0, index];
                }
            }
            //if (index >= 0)
            //{
            //    index = Find(index + 1);
            //    gridAddresses.CurrentCell = gridAddresses[0, index];
            //    return;
            //}
            //else
            //{
            //    index = Find(0);
            //    gridAddresses.CurrentCell = gridAddresses[0, index];
            //    return;
            //}
        }

        private void txtName_Enter(object sender, EventArgs e)
        {

        }

        private void txtName_Leave(object sender, EventArgs e)
        {
           
        }

        private void ipAddressControl1_Enter(object sender, EventArgs e)
        {
            
        }

        private void ipAddressControl1_Leave(object sender, EventArgs e)
        {
        }

        private void txtAdress_Enter(object sender, EventArgs e)
        {

        }

        private void txtAdress_Leave(object sender, EventArgs e)
        {

        }

        private void gridAddresses_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridAddresses_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                gridAddresses.CurrentCell = gridAddresses[0, e.RowIndex];
                gridAddresses.Rows[e.RowIndex].Selected = true;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить строку?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridAddresses.Rows.RemoveAt(gridAddresses.CurrentRow.Index);
                isDocChanged = true;
                foreach (DataGridViewRow row in gridAddresses.Rows)
                {
                    gridAddresses.Rows[row.Index].Cells[0].Value = row.Index + 1;
                }
                Recolor();
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) button1.PerformClick();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerRefresh.Enabled = false;
            frmSettings f = new frmSettings();
            f.Owner = this;
            f.ShowDialog();
        }

        private void gridAddresses_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
          
        }

        private void gridAddresses_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
      
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Owner = this;
            f.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }
        public void LoadUTM()
        {
            if (gridAddresses.Rows.Count != 0)
            {
                isDocChanged = true;
                Invoke(new System.Action(() =>
                {
                    timerRefresh.Enabled = false;
                    toolStripStatusLabel.Text = "Пожалуйста подождите, идет получение сведений об UTM: ";
                    toolStripProgressBar.Value = 0;
                    toolStripProgressBar.Visible = true;
                    toolStripProgressBar.Step = toolStripProgressBar.Maximum / gridAddresses.Rows.Count;
                }));
                foreach (DataGridViewRow item in gridAddresses.Rows)
                {
                    Invoke(new System.Action(() =>
                    {
                        toolLabelAddress.Visible = true;
                        toolLabelAddress.Text = gridAddresses[1, item.Index].Value.ToString();
                        toolStripProgressBar.PerformStep();
                    }));
                    var url = "http://" + gridAddresses[4, item.Index].Value.ToString() + ":" + gridAddresses[5, item.Index].Value.ToString() + "/";
                    var result = Parser(url);
                    Invoke(new System.Action(() =>
                    {
                        if (result[0] != "")
                        {
                            gridAddresses[7, item.Index].Value = result[0];
                            gridAddresses[8, item.Index].Value = result[1];
                            gridAddresses[9, item.Index].Value = result[2];
                        }
                    }));
                }
                Invoke(new System.Action(() =>
                {
                    timerRefresh.Enabled = true;
                    toolLabelAddress.Visible = false;
                    toolStripStatusLabel.Text = "Готово";
                    toolStripProgressBar.Visible = false;
                    toolStripProgressBar.Value = 0;
                }));
            }
        }
        private void получитьСведенияОбUTMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread loadUtmThread = new Thread(new ThreadStart(LoadUTM));
            loadUtmThread.Start();
            SetBaloonText("keys");

        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshThread = new Thread(new ThreadStart(RefreshTable));
            refreshThread.Start();
        }

        private void toExcellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            application = new Excell
            {
                DisplayAlerts = false
            };
            application.Visible = false;
            const string template = "template.xltm";
            workBook = application.Workbooks.Open(Path.Combine(Environment.CurrentDirectory, template));
            worksheet = workBook.ActiveSheet as Worksheet;
            int rowExcel = 2;
            for (int i = 0; i < gridAddresses.Rows.Count; i++)
            {
                worksheet.Cells[rowExcel, "A"] = gridAddresses.Rows[i].Cells[0].Value;
                worksheet.Cells[rowExcel, "B"] = gridAddresses.Rows[i].Cells[1].Value;
                worksheet.Cells[rowExcel, "C"] = gridAddresses.Rows[i].Cells[2].Value;
                worksheet.Cells[rowExcel, "D"] = gridAddresses.Rows[i].Cells[3].Value;
                worksheet.Cells[rowExcel, "E"] = gridAddresses.Rows[i].Cells[8].Value;
                worksheet.Cells[rowExcel, "F"] = gridAddresses.Rows[i].Cells[9].Value;
                ++rowExcel;
            }
            application.Run("Format");
            var range= worksheet.get_Range("A1", "F"+rowExcel);
            range.EntireColumn.AutoFit();
            range.EntireRow.AutoFit();
            application.Visible = true;
            application.UserControl = true;
            TopMost = false;
        }

        private void toolStripMenuItemPing_Click_1(object sender, EventArgs e)
        {
            timerRefresh.Enabled = false;
            frmPing f = new frmPing();
            f.Owner = this;
            f.ShowDialog();
        }
        Bitmap[] pingStatus;
        private Bitmap[] SavePingStatus()
        {
            pingStatus = new Bitmap[gridAddresses.Rows.Count];
            foreach (DataGridViewRow row in gridAddresses.Rows)
            {
                pingStatus[row.Index] = (Bitmap)gridAddresses[6, row.Index].EditedFormattedValue;
            }
            return pingStatus;
        }
        private void LoadPingStatus()
        {
            for (var i = 0; i < pingStatus.Length; i++)
            {
                gridAddresses[5, i].Value = pingStatus[i];
            }
        }
        private void frmMain_Deactivate(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Minimized)
            //{
            //    SavePingStatus();
            //    this.ShowInTaskbar = false;
            //    notifyIcon1.Visible = true;
            //}
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Minimized)
            //{
                
            //    this.WindowState = FormWindowState.Normal;
            //    this.ShowInTaskbar = true;
            //    notifyIcon1.Visible = false;
            //    LoadPingStatus();
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timerBaloon_Tick(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipText= SetBaloonText("keys");
            notifyIcon1.Text = notifyIcon1.BalloonTipText;
            timerBaloon.Enabled = false;
            notifyIcon1.ShowBalloonTip(2);
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
        }

        private void poslistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerRefresh.Enabled = false;
            frmDBList f = new frmDBList();
            f.Owner = this;
            f.ShowDialog();
        }

        private void frmMain_MaximumSizeChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        //private static String connString = "DATA SOURCE=ISORA;PASSWORD=ie_oper;PERSIST SECURITY INFO=True;USER ID = IE_OPER";
        public static System.Data.DataTable Query(string query)
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
                MessageBox.Show("Произошла ошибка при подключении к базе данных","Ошибка БД", MessageBoxButtons.OK,MessageBoxIcon.Error);
                log.Error(ex);
            }
            finally
            {
                if (connect.State != ConnectionState.Closed)
                    connect.Close();
            }
            return result;
        }
        private void SyncMavt()
        {
            string zapros = "Select description, Sync_time, version From EXTERNAL.EGAIS_ES_POS_LIST order by description";
            var data = Query(zapros);
            foreach (DataGridViewRow row in gridAddresses.Rows)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    if (gridAddresses[1, row.Index].Value.ToString().ToLower() == data.Rows[i][0].ToString().ToLower())
                    {
                        gridAddresses[10, row.Index].Value = data.Rows[i][2].ToString();
                        gridAddresses[11, row.Index].Value = data.Rows[i][1].ToString();
                    }
                }
            }
            Recolor();
        }
        private void getCompNames()
        {
            bool found = false;
            string zapros = @"select b.description, b.version, b.sync_time, b.ip, a.Inhabit_place, a.Avenue, a.House_No, a.subj_id 
                                            from subject_address a, external.egais_es_pos_list b
                                            where b.fsrar_id=a.egais_id and b.sync_time is not null
                                            group by b.description, b.version, b.sync_time, b.ip, a.Inhabit_place, a.Avenue, a.House_No, a.subj_id ";
            var data = Query(zapros);
            int pos = 0;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                foreach (DataGridViewRow item in gridAddresses.Rows)
                {
                    if (gridAddresses.Rows[item.Index].Cells[1].Value.ToString().ToLower() == data.Rows[i][0].ToString().ToLower())
                    {
                        found = true;
                        break;
                    }
                    else
                    {
                        found = false;
                        pos = i;
                    }
                }
                if (found == false)
                {
                    int ind = 0;
                    if (gridAddresses.Rows.Count == 0)
                    {
                        ind = 0;
                    }
                    else
                    {
                        ind = int.Parse(gridAddresses.Rows[gridAddresses.Rows.Count - 1].Cells[0].Value.ToString());
                    }
                    string ip = "0.0.0.0";
                    BindingSource bs = (BindingSource)gridAddresses.DataSource;
                    var re = new Regex(@"(10\.8\.\d{1,3}\.\d{1,3})");
                    string ooo = "";
                    if (re.Match(data.Rows[pos][3].ToString()).Success)
                    {
                        MatchCollection mc = re.Matches(data.Rows[pos][3].ToString());
                        ip = mc[0].ToString();
                    }
                    string adr = data.Rows[pos][4].ToString() + ", " + data.Rows[pos][5].ToString() + " " + data.Rows[pos][6].ToString();
                    if (data.Rows[pos][7].ToString() == "00012")
                    {
                        ooo = "Ком-Трейд";
                    }
                    else if (data.Rows[pos][7].ToString() == "00005")
                    {
                        ooo = "Комтех";
                    }
                    bs.Add(new Resource()
                    {
                        Id = ind + 1,
                        Name = data.Rows[pos][0].ToString().ToUpper(),
                        OOO = ooo,
                        Address = adr,
                        IP = ip,
                        Port = "8080",
                        UTMVer = "",
                        PKI = "",
                        Gost = "",

                    });
                    bs.EndEdit();
                    gridAddresses[10, gridAddresses.Rows.Count - 1].Value = data.Rows[pos][1].ToString();
                    gridAddresses[11, gridAddresses.Rows.Count - 1].Value = data.Rows[pos][2].ToString();
                }
            }
            Recolor();
        }

        private void загрузитьДанныеССервераMAVTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SyncMavt();
        }

        private void обновитьСписокПланшетовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getCompNames();
        }

        private void timerReloadServ_Tick(object sender, EventArgs e)
        {
            SyncMavt();
        }

        private void зарегистрироватьПланшетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerRefresh.Enabled = false;
            frmReg f = new frmReg();
            f.Owner = this;
            f.ShowDialog();
        }

        private void продажиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSales f = new frmSales();
            f.Owner = this;
            f.Show();
        }

        private void списокПродажToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSales f = new frmSales();
            f.Owner = this;
            f.description = gridAddresses[1, gridAddresses.CurrentRow.Index].Value.ToString().ToLower();
            f.Show();
        }
    }
}
