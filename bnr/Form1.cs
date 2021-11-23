using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIUtils;
using CCY.Common.WindowsAPI;
using Utils;

namespace BlockedNewsReader
{
    public partial class Form1 : frmUserBase
    {
        public string baseHost = "";
        private string[] urls;

            public Form1()
        {
            InitializeComponent();
            Clipboard.Clear();
            if (!Directory.Exists(@"c:\temp"))
                Directory.CreateDirectory(@"c:\temp");
            OpenMonitorForm();
            loadUrls();
            Process.Start(txInitialUrl.Text);
        }


        //too manyt redirections
        //https://stackoverflow.com/questions/26654369/why-im-getting-exception-too-many-automatic-redirections-were-attempted-on-web
        public string getUrlContent2(string linkUrl )
        {
            string res = "";
            HttpWebRequest webReq = (HttpWebRequest)HttpWebRequest.Create(linkUrl);
            try
            {
                webReq.CookieContainer = new CookieContainer();
                webReq.Method = "GET";
                using (WebResponse response = webReq.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(stream);
                        res = reader.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                res = "Error re-reading url:\r\n" + linkUrl + "\r\n" + ex.Message;
            }
            return res;
        }

        //https://stackoverflow.com/questions/4736831/open-webpage-programmatically-and-retrieve-its-html-contain-as-a-string
        public string getUrlContent(string url)
        {
            string strResponse = "";
            try
            {
                string url2 = url.ToLower().Trim();
                Uri bHost = new Uri(url2);
                if (!string.IsNullOrEmpty(bHost.Host))
                    baseHost = "https://" + bHost.Host;
                url = url2.Replace(@"file:///c:", baseHost);

                try
                {
                    WebRequest myWebRequest = WebRequest.Create(url);
                    WebResponse myWebResponse = myWebRequest.GetResponse();
                    Stream ReceiveStream = myWebResponse.GetResponseStream();
                    Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
                    StreamReader readStream = new StreamReader(ReceiveStream, encode);
                    strResponse = readStream.ReadToEnd();
                    readStream.Close();
                    myWebResponse.Close();
                }
                catch (Exception ex)
                {
                    strResponse = "Error leyendo url.\r\n" + url + "\r\n" + ex.Message;
                    //txPage.Visible = true;
                    strResponse = getUrlContent2(url);

                }
            }
            catch (Exception ex)
            {
                strResponse = "invalid url. " + url;
            }

            return strResponse;
        }

        private string removeAdBlockControl(string html)
        {
            string start = "<div id='floatingBlockerGuide'";
            string end = @"<div id=""cX-root""";

            html = U.RemoveBetween(html, start, end,true);
            return html;
        }


        private void processClipboard(string text)
        {
            Cursor = Cursors.WaitCursor;
            if ( !string.IsNullOrEmpty(text))
            {       
                string html = getUrlContent(text);
                if (chbRemoveJScript.Checked)
                    html = removeJavaScript(html);

                html = removeAdBlockControl(html);
                html = html.Replace(@"<div class=""contenido-exclusivo-nota"" style=""display: block"">",
                    @"<div class=""contenido-exclusivo-nota"" style=""display: none"">");

                txPage.Text = html;
                string fileName = @"c:\temp\PAGE.HTML";
                File.WriteAllText(fileName, html);
                Process.Start(fileName);
                txUrl.Text = "";

            }
            Cursor = Cursors.Arrow;
        }

        private string removeJavaScript(string html)
        {
            string t1 = "<script";
            string t2 = "</script>";
            int i1 = html.IndexOf(t1);
            int i2 = 0;

            
            while( i1>0)
            {
                i2 = html.IndexOf(t2, i1 + t1.Length);
                if (i2 > i1)
                    html = html.Substring(0, i1) + html.Substring(i2 + t2.Length);
                i1 = html.IndexOf(t1);
            }
             
            html = html.Replace("display:none", "display:block");

            return html;


        }


        private void loadUrls()
        {
            string fName = $"{AppDomain.CurrentDomain.BaseDirectory}\\urls.txt";
            string[] lines;
            if (File.Exists(fName))
            {
                lines = File.ReadAllLines(fName);
                try
                {
                    txInitialUrl.Text = lines[0];
                    txFolder.Text = lines[1];
                    txPrefix.Text = lines[2];
                    txCount.Text = lines[3];
                }
                catch(Exception ex)
                {

                }
            }
            if (string.IsNullOrEmpty(txInitialUrl.Text))
                txInitialUrl.Text = "https://www.elpais.com.uy";


        }

        private void saveUrls()
        {
            string fName = $"{AppDomain.CurrentDomain.BaseDirectory}\\urls.txt";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(txInitialUrl.Text);
            sb.AppendLine(txFolder.Text);
            sb.AppendLine(txPrefix.Text);
            sb.AppendLine(frmClipboardCatcher.Count.ToString());
            File.WriteAllText(fName,sb.ToString());
        }

         
        public override void ClipboardCapture(string text)
        {
            text = text.ToLower();
            if (text.Contains("http") ||
                text.Contains("www.") ||
                text.Contains("file:///c:/"))
                txUrl.Text = text;
                processClipboard(text);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveUrls();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if ( !string.IsNullOrEmpty(txInitialUrl.Text))
                {
                    Uri uri = new Uri(txInitialUrl.Text);
                    Process.Start(txInitialUrl.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("invalid url");
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            fdb.SelectedPath = txFolder.Text;
            if (fdb.ShowDialog() == DialogResult.OK)
                txFolder.Text = fdb.SelectedPath;
        }

        private void txFolder_TextChanged(object sender, EventArgs e)
        {
            frmClipboardCatcher.OutputFolder = txFolder.Text;
        }

        private void textBtxPrefixox2_TextChanged(object sender, EventArgs e)
        {
            frmClipboardCatcher.Prefix = txPrefix.Text;
        }

        private void txCount_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            int.TryParse(txCount.Text, out value);
            frmClipboardCatcher.Count = value;
        }
    }
}
