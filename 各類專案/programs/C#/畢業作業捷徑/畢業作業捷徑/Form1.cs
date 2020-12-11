using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Diagnostics.PerformanceData;
namespace 畢業作業捷徑
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "ddd";
            //boost up
            p.PriorityBoostEnabled = true;
            
            ProcessPriorityClass ppc = new ProcessPriorityClass();
            p.PriorityClass = ppc;
            p.Start();
            Close();
      
        }
            WebBrowser web = new WebBrowser();
        private void Form1_Load(object sender, EventArgs e)
        {
            web.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(web_DocumentCompleted);
            web.Url = new Uri("http://tw.yahoo.com/");

          
        }

        void web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
          
            MessageBox.Show(web.Document.GetElementById("searchsubmit").GetAttribute(""));
        }
        void loadded()
        {


        }
    }
}
