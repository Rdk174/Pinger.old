using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using HtmlAgilityPack;
using System.Net;
using System.Web;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;

namespace Pinger
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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
        public void Parser()
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            var url = "http://10.8.0.110:8080/";
            doc.LoadHtml(getRequest(url));
            HtmlNodeCollection c = doc.DocumentNode.SelectNodes("//div[@class='tab-pane fade in active']/pre");
            textBox1.Text = c.Count().ToString()+ Environment.NewLine;
            for (var i = 0; i<c.Count(); i++)
            {
                var st = c[i].InnerText.Normalize();
                //string version_template = "[0-9]+.[0-9]+.[0-9]+";
                string date_template = "[0-9]+-[0-9]+-[0-9]+";
                var re = new Regex(@date_template);
                MatchCollection mc = re.Matches(st);
                foreach (Match mat in mc)
                {
                    //Console.WriteLine(mat.ToString());
                    textBox1.Text = textBox1.Text + mat.ToString() + Environment.NewLine;
                }
                
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lblAutoUpdate.Text = Properties.Settings.Default.AllowAutoUpdate.ToString();
            lblTimerUpdate.Text = Properties.Settings.Default.TimerAutoUpdate.ToString();
            lblUltraVNC.Text = Properties.Settings.Default.AllowUltraVNC.ToString();
            lblUltraVNCPath.Text = Properties.Settings.Default.PathUltraVNC.ToString();
            lblUTM.Text = Properties.Settings.Default.AllowPagesiteUTM.ToString();
            lblPort.Text = Properties.Settings.Default.UTMPort.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Parser();
        }
    }
}
