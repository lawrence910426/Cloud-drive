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


namespace 溢出漏洞測試
{
    unsafe public partial class Form1 : Form
    {
        TcpClient c;
        NetworkStream nws;
        TcpListener l;
        Socket skt;
        Thread t;
        string s;

        public Form1()
        {
            InitializeComponent();
            t = new Thread(new ThreadStart(listen)); t.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c = new TcpClient("192.168.1.5", 80);
            nws = c.GetStream();
            nws.Write(Encoding.ASCII.GetBytes("sadfhasdjfhsjajksdafhsfhgjagasfdg"), 0, Encoding.ASCII.GetByteCount("sadfhasdjfhsjajksdafhsfhgjagasfdg"));
        }
        void listen()
        {
            l = new TcpListener(IPAddress.Parse("192.168.1.5"), 80);
            l.Start();
            skt = l.AcceptSocket();
            skt.ReceiveBufferSize = 1;
        restart:
            byte[] bfr = new byte[100];
            skt.Receive(bfr);
            MessageBox.Show(Encoding.ASCII.GetString(bfr));
           

            goto restart;
        }
        void msgbox()
        {
            MessageBox.Show("this was been called");

        }
    }
}
