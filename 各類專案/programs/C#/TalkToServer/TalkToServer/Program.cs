using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;




namespace TalkToServer
{







    class Program
    {
        static TcpClient c = new TcpClient();
        static NetworkStream nws;
        static void Main(string[] args)
        {
           
            //System.IO.StreamWriter sw = new System.IO.StreamWriter("d:/res.txt");
            //sw.Write("");
            //sw.Flush();
            //sw.Dispose();
            write("welcome 2 use server talker V001");
            write("use start as well");
            do
            {
                string s = Read();
                if (s == "start")
                {
                    write("start talking engine");
                    talk();
                }


            } while (true);
        }
        static void write(string msg = null)
        {
       
            //System.IO.StreamReader sr = new System.IO.StreamReader("d:/res.txt");        
           // string s = sr.ReadToEnd();
           // sr.Dispose();
            /* Console.WriteLine(s);*/
            //sr = new System.IO.StreamReader("d:/res.txt");
            // string s = sr.ReadToEnd();
            // sr.Dispose();
            //System.IO.StreamWriter sw = new System.IO.StreamWriter("d:/res.txt");
          //  sw.WriteLine(s + msg);
          //  sw.Flush();
            Console.WriteLine(msg);
        }
        static string Read()
        {

            return Console.ReadLine();
        }
        //static void listen()
        //{

        //    do
        //    {
        //        byte[] bfr = new byte[9999999];
        //        nws.Read(bfr, 0, bfr.Length);
        //        write(Encoding.ASCII.GetString(bfr));
        //        write("by the server");


        //    } while (true);

        //}

        static void talk()
        {

            System.Threading.Thread ts = new Thread(new System.Threading.ThreadStart(trylisten));
            ts.Start();




            /*全域變數
             * 
             *
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             */

            int port = 0;
        retry:
            write("next; enter server's port");



            try
            {
                port = Convert.ToInt32(Read());
            }
            catch
            {
                write("don't trick me; i'm smarter than U!!!(port)");
                goto retry; ;
            }


            write("enter server's ip");
            string ip = Read();
            try
            {
                c.Connect(IPAddress.Parse(ip), port);
            }
            catch
            { write("give me an working ipa+port(ip)"); goto retry; }
            write("connected!!!");
            write("enter the message you want to give to that jerk server");
            nws = c.GetStream();

            write("here is ze endP");
            write(c.Client.LocalEndPoint.ToString());

            System.Threading.Thread t = new Thread(new System.Threading.ThreadStart(listen));
            t.Start();


            do
            {
                string msgs = Read();
                if (msgs == "get msg")
                {

                    write("started");
                    break;
                }
                msgtoserver(msgs);
                //if (msgs == "//")
                //{
                //    t.Abort();
                //    t = new Thread(new System.Threading.ThreadStart(listen));
                //    t.Start();
                //}
  

            } while (true);
            return;
        }
        static void msgtoserver(string msg)
        {
              byte[] msgs = Encoding.ASCII.GetBytes(msg);
                write("               BY THE CLIENT");
                try
                {
                    nws.Write(msgs, 0, msgs.Length);
                }
                catch {  }



        }





       static void listen()
        {
            System.IO.StreamReader sr = new System.IO.StreamReader("d:/aaa.txt");
            
           char enter = ((sr.ReadToEnd().ToCharArray()))[0];



          // Thread t = new Thread(new ThreadStart(trylisten));
         //  t.Start();
           sr.Dispose();
           int i = 0;
            while (true)
            {
                byte[] bfr = new byte[300];
                nws.Read(bfr, 0, bfr.Length);


            //    {
                    
            //        foreach (char chkenter in prefer)
            //        {
            //            if (chkenter == enter)
            //            {
            //                break;
            //            }
            //            i++;

            //        }
            //    }
            //char[] msg = new char[i];
            //    for (int j = 0; j != i; )
            //    {
            //        msg[j] = prefer[j];
            //        j++;
            //    }
                string msg = Encoding.Default.GetString(bfr);
                
               // msg.Remove(200);
                write(msg);
                for(int ii = 0 ; ii != 100000000; ii++)
                {
                   
                }
                i++;
                if (i >= 10)
                {
                    Read();
                    i = 0; 

                }
                write("               BY THE SERVER");

            }
        }



        
        static void trylisten()
        {
            TcpListener l = new TcpListener(IPAddress.Parse("192.168.2.194"), 80); l.Start();
            Socket s = l.AcceptSocket();
            do
            {
                byte[] bfr = new byte[100];
                s.Receive(bfr);
                write(Encoding.ASCII.GetString(bfr));
                for (int ii = 0; ii != 100000000; ii++)
                {

                }
                write("               BY THE TEST SERVER");


            } while (true);

        }
         
    }
    class GetResponse
    {
        Program main = new Program();
        public GetResponse()
        {



        }
       ~GetResponse()
       {



       }

    }








}
