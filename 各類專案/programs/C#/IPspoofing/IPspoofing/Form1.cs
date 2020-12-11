
//crash with cannot build properlly










using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Net.Sockets;

namespace IPspoofing
{
    public partial class Form1 : Form
    {
     // MessageBox.Show(     ( Form1 ~form1));
        #region haha
        //int threadz;
        //Socket[] sockets;
        //Thread[] thread;

        //public Form1()
        //{
        //    InitializeComponent();
        //}

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    for (int i = 0; i != 300; )
        //    {
        //        atkp.Items.Add(i);
              
        //        trs.Items.Add(i);

        //        i++;
        //    }
        //    Control.CheckForIllegalCrossThreadCalls = false;
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    int threads = 0;
        //    //   string max = "";
        //    int fakP = 0;
        //    for (int i = 0; i != 300; )
        //    {
        //        if (i.ToString() == trs.ToString())
        //        {
        //            threads = i;
        //            i = 500;
        //        }

        //    }
        //    for (int i2 = 0; i2 != 300; )
        //    {
        //        if (i2.ToString() == trs.ToString())
        //        {
        //            fakP = i2;
        //            i2 = 500;
        //        }

        //    }
        //    threadz = threads;
        //    sockets = new Socket[threadz];
        //    for (int j = 0; j != threadz; )
        //    {



        //        thread[j] = new Thread(new ThreadStart(sending));
        //        sockets[j] = new Socket(AddressFamily.Unknown, SocketType.Raw, ProtocolType.Raw);
        //        IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(fakip.Text), fakP);
        //        sockets[j].Connect(ipe);
        //        thread[j].Start();
        //        j++;
        //    }

        //}





        //int i = 0;

        ////   i  =  5;
        //void sending()
        //{
        //    int myi = 0;
        //    myi = i;
        //    i++;
        //restart:





        //    //sockets[myi].Send();









        //    goto restart;


        //}
#endregion
        private void refresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(url.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            url.Text = webBrowser1.Url.ToString();
        }

  
     

  








    }







}


