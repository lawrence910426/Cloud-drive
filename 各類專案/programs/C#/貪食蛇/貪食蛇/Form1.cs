using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 貪食蛇
{
    public partial class Form1 : Form
    {
        PictureBox[,] picb = new PictureBox[108, 36];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i == 108; i++)
            {
                for (int j = 0; j == 36; j++)
                {
                    picb[i, j].ImageLocation = "d:/c# prog/迷宮/o-climbing.png";
                    PictureBoxSizeMode p;
                    p = PictureBoxSizeMode.Zoom;
                    picb[i, j].SizeMode = p;
                    this.Controls.Add(picb[i, j]);
                    picb[i, j].Show();
                    picb[i, j].BringToFront();
                }



            }






        }
    }
}
