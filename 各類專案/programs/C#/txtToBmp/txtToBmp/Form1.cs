using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace txtToBmp
{
    public partial class Form1 : Form
    {
        StreamReader sw;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sw = new StreamReader(textBox1.Text);
            FileStream fsW = new FileStream(textBox2.Text, FileMode.OpenOrCreate);
            BufferedStream bs = new BufferedStream(fsW);

            //for (long i = sw.; i != sw.Length; )
            //{
            //    byte[] b = new byte[10000];//do ten thouthand bytes a time
            //    fs.Read(b, 0, b.Length);
            //    bs.Write(b, 0, b.Length);
            //}
            bs.Flush();
        }
    }
}
