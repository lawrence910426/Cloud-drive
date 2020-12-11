using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
 
namespace stopper
{ 
  
   class EnterCode :Form
    {
     public  string code =(string ) null;
      bool a;
        public EnterCode()
        { 
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            code = textBox1.Text;

            Close();

        }
    }
}
