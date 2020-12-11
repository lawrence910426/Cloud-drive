using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net ;
using System.Threading;
using Microsoft.VisualBasic;
using System.IO;
using System.Diagnostics;
//using Microsoft.VisualBasic;













namespace TCPconnect
{
    public partial class Form1 : Form
    {
        Socket s;
        Thread t;
      TcpListener tcpl;
        TcpClient tcpc;
        NetworkStream nws;
        public Form1()
        {
            InitializeComponent();
        }
        



        private void button1_Click(object sender, EventArgs e)
        {

            //tcpc.Connect(textBox2.Text, 10);
 
          
           // myip();
            byte[] msg = Encoding.UTF8.GetBytes(textBox1 .Text );
            nws.Write(msg, 0, msg.Length);


        }
        void listen()
        {
    
         //   NetworkStream nws2;
      s = tcpl.AcceptSocket();
            do
            {
                byte[] b =  new byte[1024];
                s.Receive(b);
                //tcpl.Server.Receive(b);
                string str = "";
                str = Encoding.ASCII.GetString(b);

                MessageBox.Show(str);


            } while (true);




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //tcpc = new TcpClient(textBox2.Text, 10);

           

            //tcpc = new TcpClient ("10.231.136.31",10);


            CheckForIllegalCrossThreadCalls = false;
            myip();





        }





        private void button2_Click(object sender, EventArgs e)
        {       
            IPAddress ipa;
            ipa = IPAddress.Parse("192.168.0.6");//我端 我的ip ，爸端 爸的ip
            tcpl = new TcpListener(ipa, 360);
            tcpl.Start();
       //    s = tcpl.AcceptSocket();
       
         
            tcpc = new TcpClient();
            tcpc.Connect("192.168.0.6", 360);//我端 192.168.0.6 改成老爸電腦的IP ，爸端 我的IP
            nws = tcpc.GetStream();
       //     tcpc .
            
 
           // nws.Flush();
            ThreadStart ts = new ThreadStart(listen);
            t = new Thread(ts);
            t.Start();
           



           


          


        }

       
        //string  myip()
        //{
        //    string ip = (string ) null;
        //  IPAddress[] ipadrs;
        //  ipadrs = Dns.GetHostAddresses(Dns.GetHostName());
        //  foreach (IPAddress it in ipadrs)
        //  {
        //      //= (null)ipadrs
           







        //  }

        //  MessageBox.Show(ip);





        //    return ip;

        //}












    }
}
