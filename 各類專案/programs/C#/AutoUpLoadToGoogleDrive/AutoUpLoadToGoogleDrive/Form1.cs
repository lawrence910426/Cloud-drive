using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
namespace AutoUpLoadToGoogleDrive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //D:/C# Prog/AutoUpLoadToGoogleDrive/AutoUpLoadToGoogleDrive/bin/Debug/AutoUpLoadToGoogleDrive.exe
            RegistryKey rk1 = Registry.LocalMachine;
            RegistryKey rk2 = rk1.CreateSubKey("SOFTWARE");
            RegistryKey rk3 = rk2.CreateSubKey("Microsoft");
            RegistryKey rk4 = rk3.CreateSubKey("Windows");
            RegistryKey rk5 = rk4.CreateSubKey("CurrentVersion");
            RegistryKey rk6 = rk5.CreateSubKey("Run");
            rk6.SetValue("RemoteCallC", "C:/AutoUpLoadToGoogleDrive.exe");
            rk6.Close();



        }
    }
}
