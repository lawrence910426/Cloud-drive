using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
namespace TTS_check
{
    class Program
    {
        static System.Net.Sockets.NetworkStream tc;
        static System.Net.Sockets.TcpClient c = new System.Net.Sockets.TcpClient();
        static System.Net.Sockets.TcpListener l;
        static void Main(string[] args)
        {
            
            l = new TcpListener(System.Net.IPAddress.Parse("192.168.0.4"), 900);
            l.Start();
           c = l.AcceptTcpClient();
            tc = c.GetStream();

            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(listen));
            t.Start();
            do
            {
                byte[] bfr = new byte[100000];
                bfr = Encoding.Default.GetBytes(Console.ReadLine());
                tc.Write(bfr, 0, bfr.Length);
                Console.WriteLine("fsd");
            } while (true);


        }
        static void listen()
        {
            do
            { 
                byte[] bfr = new byte[100000];
                tc.Read(bfr, 0, bfr.Length);

                Console.WriteLine(Encoding.Default.GetString(bfr));
                

            } while (true);


        }
    }
}
