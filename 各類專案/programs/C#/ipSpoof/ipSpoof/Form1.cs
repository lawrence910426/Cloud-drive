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
namespace ipSpoof
{
    public partial class Form1 : Form
    {
        Socket s;
        TcpListener c;//for checking the server
        NetworkStream nws;
        TcpClient  ls = new TcpClient() ;
        /*ipHeader header;*/
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }
        //struct ipHeader
        //{
        //    public byte[] ver = new byte[4];
        //    public byte[] ihl = new byte[4];
        //    public byte[] servT = new byte[8];
        //    public byte[] totalL = new byte[16];
        //    public byte[] iden = new byte[16];
        //    public byte[] flags = new byte[3];
        //    public byte[] frag = new byte[13];
        //    public byte[] ttl = new byte[8];
        //    public byte[] proto = new byte[8];
        //    public byte[] headerc = new byte[16];
        //    public byte[] sourceA = new byte[32];
        //    public byte[] desAdress = new byte[32];
        //    public byte[] option = new byte[0];
        //    public byte[] padding = new byte[0];
        //}
       /* public struct tcp_header
        {
            public static ushort SourPort; //源端口号
            public static ushort DestPort;//目的端口号
            public static uint SegNo; //序号
            public static uint AckNo; //确认序号
            public static byte HLen; //首部长度 (保留位)
            public static byte Flag;//标识(保留位)
            public static uint Window; //窗口大小
            public static ushort ChkSum; //校验和
            public static ushort UrgPtr;//紧急指针
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                s = new Socket(AddressFamily.InterNetwork, SocketType.Raw , ProtocolType.IP);
                //c = new TcpListener(IPAddress.Parse("192.168.0.3"), 90); c.Start();
                s.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.HeaderIncluded, 0);
                //s.Connect("163.20.142.2" , 80);
                byte[] bfr = new byte[10];
                bfr[0] = 10;
                bfr[1] = 20;
                bfr[3] = 50;
                s.Send(bfr);
               // s.Send (




                //ls = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //nws = ls.GetStream();
                //ls.Receive (new byte[10]);
     














       

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }


       /* void startHeader()
        {
            header.ver[0] = 4;
            header.ihl[0] = 0;
          









        }*/
    }
}
