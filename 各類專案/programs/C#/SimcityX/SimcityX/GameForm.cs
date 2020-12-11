

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Media;
using Microsoft;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.MyServices;
#region 


#endregion







namespace WindowsFormsApplication1
{
    public partial class GameForm : Form
    {
        //full int
        PictureBox[,] picb = new PictureBox[1315 / 20, 651 / 20];
        




        public GameForm()
        {
            //picbsSizPos[1] = new Point();

            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {



            // this.Click += new System.EventArgs(this.form_click);
            this.MouseClick += new MouseEventHandler(GameForm_MouseClick);
           
            NewPic();








        }

        void GameForm_MouseClick(object sender, MouseEventArgs e)
        {



            MessageBox.Show("dfhgnv");













        }


        void NewPic()//String fileName, System.Drawing.Point Pos
        {
            
          









        }





    }
}
