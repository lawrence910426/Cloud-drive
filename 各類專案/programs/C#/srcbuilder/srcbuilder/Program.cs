using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace srcbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int i = 0; string[] command = new string[1000];
            Console.WriteLine("enter buildfile to build a file or enter scream to ...");
            do
            {
                string cin = Console.ReadLine();
                
                if (cin == "buildfile")
                {
                    Console.WriteLine("select a kind of build");
                    Console.WriteLine("only addenw this kind");
                    string mod = Console.ReadLine();
                    if (mod == "addnew")
                    {
                        Console.WriteLine("mod type :: addnew ,please enter the path for the file you are going to build");
                        string path = Console.ReadLine();
                        Console.WriteLine("enter the path for the output file");
                        string path2 = Console.ReadLine();
                        FileStream fs = new FileStream(path2, FileMode.OpenOrCreate); byte[] bfr = new byte[fs.Length]; 
                        //byte[] filebfrb = new byte[1000];
                        fs.Read(bfr, 0, bfr.Length);
                        fs = new FileStream(path, FileMode.OpenOrCreate);
                        fs.Write(bfr, 0, bfr.Length);
                        //for (int j = 0; j != i; )
                        //{
                        //    filebfrb = Encoding.ASCII.GetBytes(command[j]);
                        //    j++;
                        //}
                        //fs.Write(filebfrb, 0, filebfrb.Length);
                        Console.WriteLine("finish work");
                      //  Console.Beep(10000, 1000000);
                    }
                    else
                    {
                        if (mod == "new")
                        {


                        }
                        else
                        {
                        }
                    }

                    //  fs.Read (
                }
                else
                {
                    if (cin == "scream")
                    {
                        Console.WriteLine("enter frequency");

                        string freq = Console.ReadLine(); int fre = 8250; Console.WriteLine("screeeeeeeeeeeeeaming!!!!!!!!");
                        for (int q = 0; q != 30000; )
                        {
                            if (q.ToString() == freq)
                            {
                                fre = q;

                            }
                                q++;
                        }
                        Console.Beep(fre,5000);
                    }
                    else
                    {
                        command[i] = cin;
                    }
                }


                i++;
            } while (true);
        }
    }
}
