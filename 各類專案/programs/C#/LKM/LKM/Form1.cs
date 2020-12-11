using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;



namespace LKM
{
    public partial class Form1 : Form
    {    System.Windows.Forms.Timer act = new System.Windows.Forms.Timer ();
        int ticks =  0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPress += new KeyPressEventHandler(Form1_KeyPress);
            bullet.BringToFront();
            missle.BringToFront();
            missle2.BringToFront();



            ThreadStart ts = new ThreadStart(catchmov);
          


//  t.IsBackground = true;




            charater.BringToFront();








        }

        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //throw new NotImplementedException();
            if ((e.KeyChar == 'a') | (e.KeyChar == 'A'))
            {
                Point pt = charater.Location;
                pt.X -= 3;
                charater.Location  = pt;
            }
            else
            {
                if ((e.KeyChar == 'W') | (e.KeyChar == 'w'))
                {
                    Point pt = charater.Location;
                    pt.Y -= 3;
                    charater.Location = pt;
                }
                else
                {
                    if ((e.KeyChar == 'S') | (e.KeyChar == 's'))
                    {
                        Point pt = charater.Location;
                        pt.Y += 3;
                        charater.Location = pt;
                    }
                    else
                    {
                        if ((e.KeyChar == 'D') | (e.KeyChar == 'd'))
                        {
                            Point pt = charater.Location;
                            pt.X += 3;
                            charater.Location = pt;
                        }
                        else
                        {
                            if (e.KeyChar == 'y')
                            {
                                bullet.Visible = true;


                            }
                            else
                            {
                                if (e.KeyChar == 'h')
                                {

                                    bullet.Visible = true;

                                }
                                else
                                {
                                    if (e.KeyChar == 'b')
                                    {


                                        bullet.Visible = true;
                                    }
                                    else
                                    {
                                        if (e.KeyChar == 'u')
                                        {
                                            bullet.Visible = true;


                                        }
                                        else
                                        {
                                            if (e.KeyChar == 'j')
                                            {


                                                bullet.Visible = true;
                                            }
                                            else
                                            {
                                                if (e.KeyChar == 'n')
                                                {

                                                    bullet.Visible = true;
                                                   // bullet.BringToFront();
                                                }
                                                else
                                                {
                                                    if (e.KeyChar == 'o')
                                                    {
                                                        if (missle.Visible == true)
                                                        {
   
                                                            act.Enabled = true;
                                                            act.Interval = 500;
                                                            act.Tick += new EventHandler(act_Tick);
                                                        }
                                                        else
                                                        {

                                                            missle.Visible = true;
                                                            missle2.Visible = true;

                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (e.KeyChar == 'p')
                                                        {
                                                            if (missle.Visible == true)
                                                            {

                                                                act.Enabled = true;
                                                                act.Interval = 500;
                                                                act.Tick += new EventHandler(act_Tick);




                                                            }
                                                            else
                                                            {

                                                                missle.Visible = true;
                                                                missle2.Visible = true;

                                                            }
                                                       


                                                        }
                                                        else
                                                        {
                                                            if (e.KeyChar == 'l')
                                                            {
                                                                if (missle.Visible == true)
                                                                {

                                                                    act.Enabled = true;
                                                                    act.Interval = 500;
                                                                    act.Tick += new EventHandler(act_Tick);
                                                                }
                                                                else
                                                                {

                                                                    missle.Visible = true;
                                                                    missle2.Visible = true;

                                                                }


                                                            }
                                                            else
                                                            {
                                                                

                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }

                                }

                            }



                        }
                    }
                }
            }







        }


        //Point mslloc;

        void act_Tick(object sender, EventArgs e)
        {
            //  throw new NotImplementedException();
            if (ticks == 10)
            {
            //   InitializeComponent();
                background.BringToFront();
                charater.BringToFront();
                ticks = 0;
                act.Enabled = false;
        
         
 
                //Application .Run(new Form1() );
           //     Application.Restart();
            }
            else
            {        
                background.BringToFront();
                charater.BringToFront();
                ticks++;
                PictureBox picb = new PictureBox();
                picb.ImageLocation = "d:/C# prog/LKM/missle.png";
                this.Controls.Add(picb);
                picb.Location = new Point(charater.Location.X + ticks * 100, charater.Location.Y);
                picb.BringToFront();
                picb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                picb.BringToFront();
                PictureBox Msl4 = new PictureBox();
                Msl4.ImageLocation = "d:/C# prog/LKM/missle.png";
                this.Controls.Add(Msl4);
                Msl4.Location = new Point(charater.Location.X + ticks * 100, charater.Location.Y);
                Msl4.BringToFront(); Msl4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                Msl4.BringToFront();
            }







        }
        void catchmov()
        {
            
       









        }

      

    



    }
}
