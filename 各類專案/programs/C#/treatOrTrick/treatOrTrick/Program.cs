using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace treatOrTrick
{
    class Program
    {
        static Thread t;
        static void Main(string[] args)
        {   
            t = new Thread(new ThreadStart(Scream)); t.Start();
            do
            {
                write("這會一直叫下去"); 
                Console.Read();
                write("關了沒用");
            
            } while (true);
        }
        static void write(string msg)
        {

            Console.WriteLine(msg);


        }
        static void Scream()
        {
            do
            {
                Console.Beep(6500, 1000);
                Console.Beep(7000, 500);
                Console.Beep(6750, 750);
                Console.Beep(7500, 750);
                Console.Beep(6000, 1000);
            }while(true);
        }
    }
}
