using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO ;
using System.Net;









namespace 迷宮
{
    public partial class Form1 : Form
    {
        bool whichimg = false;
        bool right = false;//false right, true left
        bool climbing = false;
        bool falling = false;
        bool moving = false;
        int[,] linesPos = new int[3, 100];//X1 X2 Y MAX 100 lines
        int lines = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPress += new KeyPressEventHandler(Form1_KeyPress);
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
            line(new Point(100, 100), new Point(10, 100));

            //  MessageBox.Show(lines.ToString); 

        }



        void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            moving = false;
            ////throw new NotImplementedException();
            for (int i = 0; i == lines; )
            {
                if (pictureBox1.Location.Y + pictureBox1.Size.Height >= linesPos[2, i])
                {
                    if(pictureBox1 .Location.X +




                }
                i++;
            }

        }

        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //throw new NotImplementedException();

            if (e.KeyChar == 'a' | e.KeyChar == 'A')
            {
                moving = true;
                pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);
                right = false;



            }
            else
            {

                if (e.KeyChar == 'w' | e.KeyChar == 'W')
                {
                    moving = true;
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 10);
                    climbing = true;
                }
                else
                {

                    if (e.KeyChar == 'S' | e.KeyChar == 's')
                    {
                        moving = true;
                        pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 10);
                        climbing = true;
                    }
                    else
                    {

                        if (e.KeyChar == 'd' | e.KeyChar == 'D')
                        {
                            moving = true;
                            pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
                            right = true;
                        }
                        else
                        {
                            // MessageBox.Show("please use awsd");

                        }
                    }
                }
            }

        }





        void line(Point startloc, Point endloc)
        {
            if (startloc.Y == endloc.Y)
            {

                Microsoft.VisualBasic.PowerPacks.LineShape l1;
                l1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
                l1.Visible = true;
                l1.X1 = startloc.X;
                l1.Y1 = startloc.Y;
                l1.X2 = endloc.X;
                l1.Y2 = endloc.Y;
                shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.LineShape[] { l1 });
                this.Controls.Add(shapeContainer1);
                linesPos[0, lines] = startloc.X;
                linesPos[1, lines] = endloc.X;
                linesPos[2, lines] = startloc.Y;
                lines++;

            }
            else
            {
                throw new FormatException();
            }
        }

        private void actor_Tick(object sender, EventArgs e)
        {
            if (moving)
            {
                if (whichimg)
                {
                    whichimg = false;
                    if (right)
                    {


                        pictureBox1.ImageLocation = "d:/c# prog/迷宮/jerk2.png";




                    }
                    else
                    {
                        //whichimg = false;
                        pictureBox1.ImageLocation = "d:/c# prog/迷宮/o-jerk2.png";


                    }
                }
                else
                {
                    whichimg = true;
                    if (right)
                    {


                        //pictureBox1.ImageLocation = "d:/c# prog/迷宮/jerk2.png";
                        pictureBox1.ImageLocation = "D:/C# Prog/迷宮/jerK.png";



                    }
                    else
                    {
                        //whichimg = false;
                        pictureBox1.ImageLocation = "d:/c# prog/迷宮/o-jerk.png";


                    }


                }
            }
        }
    }
}
