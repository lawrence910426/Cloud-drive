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
using System.Diagnostics;









namespace Tcp混亂封包
{ 
    
    public partial class Form1 : Form
    {
        byte[] bfr = new byte[1024];
        Socket rs;
        TcpListener l;
        TcpClient c;
        Thread t;
        public Form1()
        {
            InitializeComponent();
            rs = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.IP);
            l = new TcpListener(IPAddress.Parse("192.168.1.6"), 90); l.Start();
            rs.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.HeaderIncluded, 1000);
            t = new Thread(new ThreadStart(listenRawSocket)); t.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rs.Connect("192.168.1.6", 90);
            rs.Send(bfr);

            c = new TcpClient("192.168.1.6", 90);
            c.GetStream().Write(Encoding.Default.GetBytes("ehlo"), 0, Encoding.Default.GetByteCount("ehlo"));
        }
        void listenRawSocket()
        {
            Socket s = l.AcceptSocket();
            do
            {
                
                byte[] bfr = new byte[1024];
                s.Receive(bfr);
                MessageBox.Show(Encoding.Default.GetString(bfr));



            } while (true);
        }
    }
}
