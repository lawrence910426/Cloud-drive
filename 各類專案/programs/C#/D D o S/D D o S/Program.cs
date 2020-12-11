using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
namespace D_D_o_S
{

    
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // File.Create("c:/windows/system32/AAA.txt");
            StreamWriter sw = new StreamWriter("AAA.txt");//c:/Windows/System32/_AAA.txt
            sw.WriteLine("sdfaf");
            sw.Flush();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
