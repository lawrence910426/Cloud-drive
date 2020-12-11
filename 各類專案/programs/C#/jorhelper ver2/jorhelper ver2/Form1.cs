using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets ;
using System.Diagnostics;













namespace jorhelper_ver2
{
    public partial class Form1 : Form
    {
        System.Threading.Thread t;
        public Form1()
        {
            InitializeComponent();
        }
        #region clicking
        int redo = 1;
        System.Diagnostics.Process[] p;
        Timer waiter = new Timer();
        int processes = 0;
        int[] ids = new int[100];
        //System.Diagnostics.Process me;
        private void Form1_Load(object sender, EventArgs e)
        {
            waiter.Tick += new EventHandler(waiter_Tick);

        }


        void send(int howmuch)
        {
            try
            {
                p = new System.Diagnostics.Process[howmuch];
                processes = howmuch;
                for (int i = 0; i != howmuch; )
                {
                    p[i] = new System.Diagnostics.Process();
                    p[i].StartInfo.Arguments = textBox1.Text;
                    p[i].StartInfo.FileName = "C:/Program Files (x86)/Google/Chrome/Application/chrome.exe";
                    p[i].Start();
                    p[i].PriorityClass = System.Diagnostics.ProcessPriorityClass.High;
                    p[i].PriorityBoostEnabled = true;

                    i++;

                }
                started();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;

            send(Convert.ToInt32(textBox2.Text));

        }




        void started()
        {
            waiter.Interval = Convert.ToInt32(textBox3.Text) * 1000; //(comboBox2.SelectedIndex + 1) * 5 * 1000;
            waiter.Enabled = true;
            listBox1.Items.Add("wait for chrome to load" + (redo).ToString());

        }

        void waiter_Tick(object sender, EventArgs e)
        {
            stop();
        }
        void stop()
        {
            try
            {
                Process[] processes = Process.GetProcessesByName("chrome");
                foreach (Process p in processes)
                {
                    // 關閉目前程序前先等待 1000 毫秒
                    p.WaitForExit(100);
                    p.CloseMainWindow();
                }
                waiter.Enabled = false;

                restart();
            }
            catch { }



        }
        void restart()
        {
            send(Convert.ToInt32(textBox2.Text));
            listBox1.Items.Add("loaded,restart" + (++redo).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            try
            {
                Process[] processes = Process.GetProcessesByName("chrome");
                foreach (Process p in processes)
                {
                    // 關閉目前程序前先等待 1000 毫秒
                    p.WaitForExit(100);
                    p.CloseMainWindow();
                }
                waiter.Enabled = false;
                listBox1.Items.Add("stopped");
            }
            catch
            { }
        }
        #endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                t = new System.Threading.Thread(new System.Threading.ThreadStart(clear));
                t.Start();
          
            }
        }
        void clear()
        { 
        res:
              listBox1.Items.Clear();
        goto res;
        }
    }
}
