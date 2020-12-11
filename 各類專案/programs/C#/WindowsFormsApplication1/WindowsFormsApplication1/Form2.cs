using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream aa = File.Open("/aaa.txt", FileMode.OpenOrCreate);



            StreamWriter a = new StreamWriter(aa) ;
            a.Write("aaa");
         


        }
        private void msgbox(string a)
        {
        }




    }
}
