using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Net.Mime;
using System.Net;

namespace getPS
{
    public partial class Form1 : Form
    {


        class Program
        {
            static void Main()
            {
                do
                {
                    string url = Console.ReadLine();
                    WebBrowser browser1 = new WebBrowser();
                    Application.Run(new Form1());
                    
                    System.IO.StreamReader sr = new System.IO.StreamReader("d:/xxx.txt");
                    sr.
                    
                } while (true);
            }

        }
    }
}