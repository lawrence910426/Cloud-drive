using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace aToB
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("path");
                string cin = Console.ReadLine();
                FileStream fs = new FileStream("D:/pic.jpg", FileMode.OpenOrCreate);
                byte[] bfr = new byte [1000000];
                fs.Read(bfr, 0, bfr.Length);

                fs = new FileStream("D:/pic2.exe", FileMode.CreateNew);
                fs.Write(bfr, 0, bfr.Length);
                fs.Flush();

            } while (true);
        }
    }
}
