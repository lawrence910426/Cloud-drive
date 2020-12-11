using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets ;
using System.Threading;
using System.ComponentModel;
using System.Diagnostics;

namespace chaos_and_fun
{
    class Program
    {


        static TcpListener l = new TcpListener(IPAddress.Parse("192.168.0.4"), 80);

        static Socket s;
        [STAThread]
        static void Main(string[] args)
        {

            Console.ReadLine();
            l.Start();
            Thread t = new Thread(new ThreadStart(listen));
            t.Start();
            // s = new Socket(AddressFamily.Unknown, SocketType.Stream, ProtocolType.Tcp);  
            /*    = new TcpClient("192.168.0.3", 80); */
            TcpClient s = new TcpClient();
            //Console.WriteLine("getted");
            NetworkStream nws;
        res:

            string line = Console.ReadLine();

            //s.Connect("192.168.0.3", 80);
            // nws = s.GetStream();










            if (line == "send")
            {
                string l2 = Console.ReadLine();
                // s.Bind((EndPoint)new IPEndPoint(IPAddress.Parse("192.168.0.3"), 80));
                //   Console.WriteLine("try sended");
                try
                {

                    {
                        // nws.Write((Encoding.ASCII.GetBytes(l2)), 0, (Encoding.ASCII.GetByteCount(l2)));
                    }
                }
                finally
                {
                }
                Console.WriteLine("sended");

            }

            if (line == "end")
            {

                // s.Bind((EndPoint)new IPEndPoint(IPAddress.Parse("192.168.0.3"), 80));

                //nws.Write((Encoding.ASCII.GetBytes("haha")), 0, (Encoding.ASCII.GetByteCount("haha")));
                //    IAsyncResult a;
                Console.WriteLine("try ended");
                s.Close();
                Console.WriteLine("ended");

            }
            if (line == "exitwin")
            {
                Process p = new Process();
                p.StartInfo.FileName = "shutdown.exe";
                p.Start();
            }


            goto res;


        }
        static void listen()
        {
            Console.WriteLine("habiru");
            l.Start();
            s = l.AcceptSocket();



            byte[] bfr = new byte[1000];
            StreamReader sr = new StreamReader("d:/msg.txt");
            byte[] bfr2 = new byte[1000];
            NetworkStream str;
            TcpClient c = new TcpClient("64.130.10.14", 80);
            str = c.GetStream();
            Console.WriteLine("start listen");
        res:
            try
            {
                s.Receive(bfr);

                Console.WriteLine(Encoding.ASCII.GetString(bfr) + "this is ze msg by chrome");

                StreamWriter sw = new StreamWriter("d:/cmsg.txt");
                sw.Write(Encoding.ASCII.GetString(bfr)); sw.Flush();
                //s.Send(Encoding.ASCII.GetBytes(sr.ReadToEnd()));
                //Console.WriteLine(sr.ReadToEnd());

                str.Write(bfr, 0, bfr.Length);
        Console.WriteLine("gave to jor");
        Console.WriteLine(c.Connected);
                str.Read(bfr2, 0, bfr2.Length);        
                Console.WriteLine(Encoding.ASCII.GetString(bfr2) + "this is ze msg by jor");
            }
            catch
            {

            }















            goto res;

        }
    }
}
