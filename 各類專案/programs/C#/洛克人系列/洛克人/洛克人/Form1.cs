using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 洛克人
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyDown  += new KeyEventHandler(Form1_KeyPress);
        }

        void Form1_KeyPress(object sender, KeyEventArgs e)
        {
            //throw new NotImplementedException();
        }

       
    }
}
