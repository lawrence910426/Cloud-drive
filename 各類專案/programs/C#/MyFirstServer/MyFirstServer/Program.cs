using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;









namespace MyFirstServer
{
    class Program
    {
        static TcpListener l;
        static Thread t;
        static void Main(string[] args)
        {
            l = new TcpListener(IPAddress.Parse("192.168.1.5"), 80);
            //TcpListener l2 = new TcpListener(IPAddress.Parse("192.168.1.5"), 80);
            //l.Server.ExclusiveAddressUse = false;
            l.Start(int.MaxValue);

            t = new Thread(new ThreadStart(mainListen));
            t.Start();
            //TestClient[] tc = new TestClient [ 100];
            //for (int i = 0; i != 100; )
            //{
                
            //    tc[i] = new TestClient(IPAddress.Parse("192.168.1.5"), 80);
            //    i++;
            //}
            do
            {
                
                // tc = new TestClient();
                //TcpClient c = new TcpClient("192.168.1.5", 80);
                // NetworkStream nws = c.GetStream();
                // nws.Write(Encoding.ASCII.GetBytes("test assol alapha"), 0, 15);// Encoding.ASCII.GetByteCount("test assol alapha")
                // for (int i = 0; i != 10000000; )
                // {
                //     i++;
                // }
                // TcpClient c2 = new TcpClient("192.168.1.5", 80);
                // NetworkStream nws2 = c2.GetStream();
                // nws2.Write(Encoding.ASCII.GetBytes("test assol betaaa"), 0, 15);
                // for (int i = 0; i != 10000000; )
                // {
                //     i++;
                // }
                // TcpClient c3 = new TcpClient("192.168.1.5", 80);
                // NetworkStream nws3 = c3.GetStream();
                // nws3.Write(Encoding.ASCII.GetBytes("test assol threee"), 0, 15);










            } while (true);//deathly loop
        }
      static   int port;
      static void mainListen()
      {

          port = 0;
      restart:
          Socket s = l.AcceptSocket();
          byte[] bfr = new byte[64];

          port++;
          //
          //bfr[1]~bfr[2] is the thing will work (計算式 bfr[0] + bfr[1]*10 + bfr[2]*100
          bfr[0] = (byte)port;
          //
          //
          Thread t = new Thread(new ThreadStart(subListen));
          t.Start();
          

          s.Send(bfr);
          //s.Receive(bfr);
          //Console.WriteLine(Encoding.ASCII.GetString(bfr));
          //s.ReceiveBufferSize = int.MaxValue;
          s.Close();
          goto restart;
      }
      static void subListen()
        {
            if(port == 80)
            {
                port++;
            }
            retry:
            TcpListener l;
            try
            {

                l = new TcpListener(IPAddress.Parse("192.168.1.5"), port);
                l.Start();
            }
            catch
            {

                port++;
                goto retry;
            }
            Socket s = l.AcceptSocket();
            while (true)
            {
                byte[] bfr = new byte[1024];
                bfr[0] = 1;
             
                bfr[1] = 0;
                bfr[2] = 163;
                bfr[3] = 20;
                bfr[4] = 142;
                bfr[5] = 2;
                //6
                //7
                bfr[8] = 10;
                //9
                bfr[10] = 1;

                try
                {

                    s.Send(bfr);
                }
                catch
                {
                }
                //Console.WriteLine(Encoding.ASCII.GetString(bfr));



            }
        }
    }
    class TestClient
    {
        TcpClient c;
        NetworkStream nws;
        public TestClient(IPAddress ipa, int port)//
        {
            c = new TcpClient(ipa.ToString(), port);
            nws = c.GetStream();
            byte[] bfr = new byte[64];
            nws.Read(bfr, 0, 64);
            c.Close();
            for (int i = 0; i != 10000; )
            {


                i++;
            }
            c = new TcpClient(ipa.ToString(), bfr[0]);
            nws = c.GetStream();
            nws.Write(Encoding.ASCII.GetBytes("fuck"), 0, 4);
            nws.Write(Encoding.ASCII.GetBytes("pee poo"), 0, 7);


        }






    }

}