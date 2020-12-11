using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;





namespace tryServer
{
    class Program
    {
        static int i = 0;
        static void Main(string[] args)
        {
            TcpClient sender = new TcpClient();
            do
            {
                string cin = Console.ReadLine();
                if (cin == "startlis")
                {

                    Thread t = new Thread(new ThreadStart(lis)); t.Start();
                    Console.WriteLine("start listening");
                }

                if (cin == "send")
                {
                    sender.GetStream().Write(Encoding.ASCII.GetBytes("       haha"), 0, Encoding.ASCII.GetBytes("       haha").Length);

                    sender.Close();
                    i++;
                }

                if (cin == "connect")
                {
                    sender = new TcpClient();
                    sender.Connect(IPAddress.Parse("192.168.0.4"), 450 + i);



                }







            } while (true);

        }
        static void lis()
        {
            Console.WriteLine("listening");
            TcpListener l = new TcpListener(IPAddress.Parse("192.168.0.4"), 450);
            l.ExclusiveAddressUse = false;
            l.Start();
            Socket s = null;
            //Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            byte[] bfr = new byte[10000];
            //s.Connect(new IPEndPoint(IPAddress.Parse("192.168.0.4"), 450));
            //bfr = Encoding.ASCII.GetBytes("hahhahahah"); s.Send(bfr);

            //ls = l.AcceptSocket();
            Console.WriteLine("start listen");
            s = l.AcceptSocket();





            do
            {










                try
                {

                    s.Receive(bfr); Console.WriteLine("get en msg"
                     + Encoding.ASCII.GetString(bfr) +
                     "end ov ze msg");
                    Console.WriteLine(i.ToString());
                }
                catch
                {
                }

                l = new TcpListener(IPAddress.Parse("192.168.0.4"), 450 + i); l.Start();
                s.Close();
                s = l.AcceptSocket();
            } while (true);

        }
    }
}
