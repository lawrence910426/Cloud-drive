using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;







namespace binaryReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fs;
            fs = new FileStream("d:/xxx.exe", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            byte[] b = Encoding.Default.GetBytes("hello");
            fs.Write(b, 0, b.Length);
            fs.Flush(true);
            fs.Close();
            fs = new FileStream("D:/C# Prog/yuteh/yuteh/bin/Debug/yuteh.exe",FileMode.Open  , FileAccess.Read );
            byte[] arr = new byte[ fs.Length];
            fs.Read(arr, 0, arr.Length);
            for (int i = 0; i != 10; ) { MessageBox.Show(arr[0].ToString()); i++; }
          
            fs.Close();
         
       



        }
    }
}
