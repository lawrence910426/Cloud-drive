using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace jorHelper
{
    public partial class Form1 : Form
    {
        WebBrowser[] browsers = new WebBrowser[1000];
        int i = 0; int indexi = 0;
        public Form1()
        {
            InitializeComponent();
        }
         //[MTAThread]0
        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("http://ri.search.yahoo.com/_ylt=A8tUwZIYJRtToxkARC9r1gt.;_ylu=X3oDMTE3OXJ0Yzg4BHNlYwNzcgRwb3MDMTUEY29sbwN0dzEEdnRpZANWSVBUVzY2XzUxOA--/RV=2/RE=1394316697/RO=10/RU=http%3a%2f%2fwww.jor.com.tw%2f/RK=0/RS=vFofN57CGY_kFZOhdXXjD8Kt3VU-");
            for (int i = 0; i != 1000; )
            {
                browsers[i] = new WebBrowser();
                browsers[i].DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(Program_DocumentCompleted);
                browsers[i].Url = new Uri("http://ri.search.yahoo.com/_ylt=A8tUwZIYJRtToxkARC9r1gt.;_ylu=X3oDMTE3OXJ0Yzg4BHNlYwNzcgRwb3MDMTUEY29sbwN0dzEEdnRpZANWSVBUVzY2XzUxOA--/RV=2/RE=1394316697/RO=10/RU=http%3a%2f%2fwww.jor.com.tw%2f/RK=0/RS=vFofN57CGY_kFZOhdXXjD8Kt3VU-");
                i++;

            }
       
        }
       
        void sta()
        {

        }
       void Program_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
           allload();
           if ((i % 100) == 0)
           {
  Console.WriteLine("log" + (indexi).ToString());

           }
         
        }
       void allload()
       {
           if (i == 999)
           {
               for (int j = 0; j != 1000; )
               {
                   browsers [j].Url  = new Uri("http://ri.search.yahoo.com/_ylt=A8tUwZIYJRtToxkARC9r1gt.;_ylu=X3oDMTE3OXJ0Yzg4BHNlYwNzcgRwb3MDMTUEY29sbwN0dzEEdnRpZANWSVBUVzY2XzUxOA--/RV=2/RE=1394316697/RO=10/RU=http%3a%2f%2fwww.jor.com.tw%2f/RK=0/RS=vFofN57CGY_kFZOhdXXjD8Kt3VU-");
                   j++;
               }
               i = 0;
               Console.WriteLine("another thouthand"); indexi++;
           }
           i++;
           indexi++;
       }

       private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
       {
           MessageBox.Show("comp");
       }
    }
}
