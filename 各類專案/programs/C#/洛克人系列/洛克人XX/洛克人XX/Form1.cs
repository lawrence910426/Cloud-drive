using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 洛克人XX
{
    public partial class Form1 : Form
    {
        Timer ft = new Timer();
        Timer[] tBs = new Timer[3];
        bool stand = false;
        bool gun = true;
        bool faceRight = true;
        short Sbullets = 0;
        PictureBox[] bullet = new PictureBox[3];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ft.Tick += new EventHandler(ft_Tick);
            this.KeyPress += new KeyPressEventHandler(Form1_KeyPress);
            System.Threading.Thread onG = new System.Threading.Thread(new System.Threading.ThreadStart(onGround));
            onG.Start();
            for (int i = 0; i != 3; )
            {

                tBs[i] = new Timer();
                bullet[i] = new PictureBox();
                //  this.Controls.Add(tBs[i]);
                i++;

            }
            Control.CheckForIllegalCrossThreadCalls = false;
            tBs[0].Interval = 10;
            tBs[0].Tick += new EventHandler(tb1_Tick);
            tBs[1].Interval = 10;
            tBs[1].Tick += new EventHandler(tb2_Tick);
            tBs[2].Interval = 10;
            tBs[2].Tick += new EventHandler(tb3_Tick);
        }




        int jumps = 0;
        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //throw new NotImplementedException();
            if (e.KeyChar == 'a' | e.KeyChar == 'A')
            {
                MainChara.Location = new Point(MainChara.Location.X - 10, MainChara.Location.Y);
                faceRight = false;
            }
            if (e.KeyChar == 'd' | e.KeyChar == 'D')
            {
                MainChara.Location = new Point(MainChara.Location.X + 10, MainChara.Location.Y);
                faceRight = true;
            }
            if (e.KeyChar == 'W' | e.KeyChar == 'w')
            {
                if (jumps != 2)
                {
                    jumps++;
                    jump();
                }
            }
            if (e.KeyChar == 'S' | e.KeyChar == 's')
            {
                if (gun == false)
                {
                    gun = true;
                }
                else
                {

                    gun = false;
                }


            }
            if (e.KeyChar == ' ' | e.KeyChar == ' ')
            {
                if (Sbullets != 3)
                {

                    shutBullet();
                }

            }
        }









        #region BasicBullet



        bool fr1; bool fr2; bool fr3;
        void shutBullet()
        {
            //remove = destory
            bullet[Sbullets].ImageLocation = "dfsssssssss";
            bullet[Sbullets].Size = new Size(10, 10);
            bullet[Sbullets].SizeMode = PictureBoxSizeMode.Zoom;
            if (faceRight)
            {
                bullet[Sbullets].Location = new Point(MainChara.Location.X + 10 + MainChara.Size.Width, MainChara.Location.Y + MainChara.Size.Height / 2);
            }
            else
            {
                bullet[Sbullets].Location = new Point(MainChara.Location.X - 10, MainChara.Location.Y + MainChara.Size.Height / 2);
            }

            this.Controls.Add(bullet[Sbullets]);
            Sbullets++;
            if (!tBs[0].Enabled)
            {

                tBs[0].Enabled = true;
                fr1 = faceRight;
            }
            else
            {
                if (!tBs[1].Enabled)
                {

                    tBs[1].Enabled = true;
                    fr2 = faceRight;
                }
                else
                {
                    if (!tBs[2].Enabled)
                    {
                        tBs[2].Enabled = true;
                        fr3 = faceRight;
                    }
                    else
                    {
                        MessageBox.Show("dd");
                    }
                }



            }
        }




        void tb1_Tick(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            if (fr1)
            {
                bullet[0].Location = new Point(bullet[0].Location.X + 15, bullet[0].Location.Y);
            }
            else
            {
                bullet[0].Location = new Point(bullet[0].Location.X - 15, bullet[0].Location.Y);
            }
            if (((bullet[0].Location.X + bullet[0].Size.Width) >= 1380) | (bullet[0].Location.X <= 0))
            {
                tBs[0].Enabled = false;
                this.Controls.Remove(bullet[0]);
                short max = 1;
                Sbullets = (short)(Sbullets - max);

            }


        }
        void tb2_Tick(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            if (fr2)
            {
                bullet[1].Location = new Point(bullet[1].Location.X + 15, bullet[1].Location.Y);
            }
            else
            {
                bullet[1].Location = new Point(bullet[1].Location.X - 15, bullet[1].Location.Y);
            }
            if (((bullet[1].Location.X + bullet[1].Size.Width) >= 1380) | (bullet[1].Location.X <= 0))
            {
                tBs[1].Enabled = false;
                this.Controls.Remove(bullet[1]);
                short max = 1;
                Sbullets = (short)(Sbullets - max);

            }



        }
        void tb3_Tick(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            if (fr3)
            {
                bullet[2].Location = new Point(bullet[2].Location.X + 15, bullet[2].Location.Y);
            }
            else
            {
                bullet[2].Location = new Point(bullet[2].Location.X - 15, bullet[2].Location.Y);
            }
            if (((bullet[2].Location.X + bullet[2].Size.Width) >= 1380) | (bullet[2].Location.X <= 0))
            {
                tBs[2].Enabled = false;
                this.Controls.Remove(bullet[2]);
                short max = 1;
                Sbullets = (short)(Sbullets - max);

            }

        }



        #endregion
        #region jumpProg



        bool jumping = false;
        Timer t = new Timer();
        int upForc = 0;
        //  int deupForc = 0;
        int groundLine = 0;
        bool firstJ = false;
        void jump()
        {
            jumping = true;
            if (!firstJ)
            {
                groundLine = lineShape1.Y1;
                t.Tick += new EventHandler(t_Tick);
                t.Interval = 10;
            }
            upForc = 75;
            firstJ = true;

            // upForc -= 1;
            //  MessageBox.Show("d");
            // CheckForIllegalCrossThreadCalls = false;
            // System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(grav));

            t.Enabled = true;
            MainChara.Location = new Point(MainChara.Location.X, MainChara.Location.Y - (int)(upForc * 0.1));
        }
        void onGround()
        {
        restart:


            if (((MainChara.Location.Y + MainChara.Size.Height) >= lineShape1.Y1) | ((MainChara.Location.Y + MainChara.Size.Height >= lineShape2.Y1) && (MainChara.Location.X + MainChara.Size.Width >= lineShape2.X1)|(MainChara .Location .X <= lineShape2 .X2 )))
            {
                if (jumps == 2)
                {
                    jumps = 0;
                }

                stand = true;

            }
            else
            {

                if (!jumping)
                {
                    fall();
                }
            }








            goto restart;
        }
        int downF = 1;

        void fall()
        {

            ft.Interval = 10;
            ft.Enabled = true;
           MessageBox.Show("lllsad/nssss");
        }
        void ft_Tick(object sender, EventArgs e)
        {
            if ((MainChara.Location.Y + MainChara.Size.Height) >= lineShape1.Y1)
            {
                ft.Enabled = false;
                MainChara.Location = new Point(MainChara.Location.X, lineShape1.Y1 - MainChara.Size.Height);
                jump();
            }
            //        MessageBox.Show(downF.ToString());
            downF++;
            MainChara.Location = new Point(MainChara.Location.X, MainChara.Location.Y + (int)(downF * 0.1)); //throw new NotImplementedException();

        }








        void t_Tick(object sender, EventArgs e)
        {
            if (((MainChara.Location.Y + MainChara.Size.Height) >= lineShape1.Y1) | ((MainChara.Location.Y + MainChara.Size.Height >= lineShape2.Y1) && ((MainChara.Location.X + MainChara.Size.Width >= lineShape2.X1)|(MainChara .Location .X <= lineShape2 .X2 ))))
            {
                if (((MainChara.Location.Y + MainChara.Size.Height) >= lineShape1.Y1))
                {

                    
                    MainChara.Location = new Point(MainChara.Location.X, lineShape1.Y1 - MainChara.Size.Height);
                }
                else
                {
           
                    MainChara.Location = new Point(MainChara.Location.X, lineShape2.Y1 - MainChara.Size.Height);
                }
         jumping = false;
                    t.Enabled = false;
            }
            else
            {
                MainChara.Location = new Point(MainChara.Location.X, MainChara.Location.Y - (int)(upForc * .1));
                upForc -= 1;
            }
        }
        #endregion
    }
}
