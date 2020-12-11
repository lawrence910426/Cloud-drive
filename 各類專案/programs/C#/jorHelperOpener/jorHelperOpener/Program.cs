using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
namespace jorHelperOpener
{
    class Program
    {
        static void Main(string[] args)
        {        
            do
            {
                Console.WriteLine("how much progs");
            string much = Console.ReadLine();
            Console.WriteLine(val(much)+1);
                int muchi = (val(much) + 1);
     Console.WriteLine("enter path"); 
                string cin = Console.ReadLine();
            
            for (int i = 0; i != muchi; )
            {

          
                Process p = new Process();
                try
                {
                    p.StartInfo.FileName = cin; p.Start();
                }
                catch
                {
                    Console.WriteLine("mistake path");
                    p.StartInfo.FileName = "d:/autolog.exe"; p.Start();
                }

                Console.WriteLine(i);
                i++;
            }
            } while (true);
           



        }
        static int val(string  s)
        {
            int bak = 0;
            for (int j = 0; j.ToString() != s; )
            {

                bak = j;
                j++;
            }
            return bak;
        }
    }
}
