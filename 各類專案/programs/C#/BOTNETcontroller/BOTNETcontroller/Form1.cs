using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace BOTNETcontroller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TreeNode[] n = new TreeNode[100];
        int users = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            //            TreeNode n  = new TreeNode ();
            //n = new TreeNode("d:/");
            //            //n.Node  s.Add("ddd").Nodes.Add("ppp");
            //            //treeView1.Nodes.Add(n);
            //            //lv1
            //            foreach (string s in Directory.GetDirectories("d:/"))
            //            {
            //              //lv2
            //                TreeNode t2 = new TreeNode(s);



            //                try
            //                {
            //                    foreach (string ss in Directory.GetFiles(s))
            //                    {
            //                        t2.Nodes.Add (ss) ;
            //                    }

            //                    foreach (string ss in Directory.GetDirectories(s))
            //                    {
            //                        //lv3
            //                        TreeNode t3 = new TreeNode(ss);
            //                //        foreach (string sss in Directory.GetFiles(s))
            //                //        {
            //                //            t2.Nodes.Add(sss);
            //                //        }

            //                //        foreach (string sss in Directory.GetDirectories(s))
            //                //        {
            //                //            TreeNode t3 = new TreeNode(sss);
            //                //            foreach (string ssss in Directory.GetFiles(s))
            //                //            {
            //                //                t3.Nodes.Add(ssss);
            //                //            }
            //                //            t2.Nodes.Add(t3);
            //                //        }
            //                        t2.Nodes.Add(t3);
            //                    }
            //               }
            //                catch
            //                {
            //                }
            //                n.Nodes.Add(t2);
            //            }
            //            treeView1.Nodes.Add(n);
            // treeView1.NodeMouseDoubleClick += new TreeNodeMouseClickEventHandler(treeView1_NodeMouseDoubleClick);

            //    string[] s = null;
            //    try
            //    {


            //        s = Directory.GetDirectories("D:/", "c", SearchOption.AllDirectories);
            //    }
            //    catch
            //    {

            //    }
            //foreach (string str in s)
            //{
            //    MessageBox.Show(str);
            // }

















        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            addusr("191","fsaasafaf::dsfa:","fgdfgds");
        }
        void addusr(string ip,string ip6, string name)
        {
            users++;
            Label l = new Label();
            Label l2 = new Label();
            Label l3 = new Label();
            l.Location = new Point(15, label1.Location.Y + 30 + users * 30);
            l.Text = ip;
            l.Width = 50;
            l2.Location = new Point(label5.Location.X, label5.Location.Y + users * 30);
            l2.Text = name;
            l2.TextAlign = ContentAlignment.TopCenter;
            l2.Width = 41;
            l2.MaximumSize = new System.Drawing.Size(int.MaxValue, int.MaxValue);
            l3.Location = new Point(104, label6.Location.Y + 30 + users * 30);
            l3.Text = ip6;

            this.Controls.Add(l); this.Controls.Add(l2); this.Controls.Add(l3);//this.Controls.Add(t);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(Mainlisten));
            t.Start();

        }





        Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        void Mainlisten()
        {

            TcpListener tcpl = new TcpListener(IPAddress.Parse(ip()), 900);
            tcpl.Start();
            s = tcpl.AcceptSocket();
        restart:
            byte[] bfr = new byte[100000000000000];
        s.Receive(bfr);
            Encoding .ASCII .GetString (bfr).spl
            
















            goto restart;


        }
        string ip()
        {
            IPAddress[] ipa = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress ip in ipa)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();

                }

            }

            return "";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //TreeNode n = new TreeNode("d:/");
            //string[,] s = new string[100, 100];
            //string[] bfr = Directory.GetDirectories("d:/");
            //for (int i = 0; i != bfr.Length; )
            //{
            //    s[i, 0] = bfr[i];

            //    i++;

            //}

            //treeView1.Nodes.Add(n);


            TreeNode n = new TreeNode();
            n = new TreeNode("d:/");
            //n.Node  s.Add("ddd").Nodes.Add("ppp");
            //treeView1.Nodes.Add(n);
            //lv1
            foreach (string s in Directory.GetDirectories("d:/"))
            {
                //lv2
                TreeNode t2 = new TreeNode(s);



                try
                {
                    foreach (string ss in Directory.GetFiles(s))
                    {
                        t2.Nodes.Add(ss);
                    }

                    foreach (string ss in Directory.GetDirectories(s))
                    {
                        //lv3
                        TreeNode t3 = new TreeNode(ss);
                        foreach (string sss in Directory.GetFiles(ss))
                        {
                            t3.Nodes.Add(sss);
                        }

                        foreach (string sss in Directory.GetDirectories(s))
                        {
                            TreeNode t4 = new TreeNode(sss);
                            foreach (string ssss in Directory.GetFiles(sss))
                            {
                                t4.Nodes.Add(ssss);
                            }
                            t3.Nodes.Add(t4);
                        }
                        t2.Nodes.Add(t3);
                    }
                }
                catch
                {
                }
                n.Nodes.Add(t2);
            }
            //treeView1.Nodes.Add(n);






        }



    }
}
