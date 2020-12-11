using System;

using System.Windows.Forms;
using System.Linq;
using System.Text;
namespace jorHelper
{
    
   class Program
    {
       [STAThread]
     //   
      //  static WebBrowser[] browsers = new WebBrowser[1000];
    //    static int i = 0;
        static void Main(string[] args)
        {
            
           // do
           // {
               
              //  for (int i = 0; i != 1; )
               // {
                 //   browsers[i] = new WebBrowser();
                   // browsers[i].DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(Program_DocumentCompleted);
                   // browsers[i].Url = new Uri("http://ri.search.yahoo.com/_ylt=A8tUwZMsxBpTa0IADB9r1gt.;_ylu=X3oDMTE2NWRsb2Q4BHNlYwNzcgRwb3MDMQRjb2xvA3R3MQR2dGlkA1ZJUFRXNjZfNTE4/RV=2/RE=1394291885/RO=10/RU=http%3a%2f%2fwww.jor.com.tw%2f/RK=0/RS=YDY4NrxD7drg0Qdn3qIDL34Y3Hg-");
                 //   i++;

               // }
                Console.WriteLine("start");Application .Run (new Form1() );
           /// } while (true);
        }

        //static void Program_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        //{
        //  allload();
           
        //}
        //static void allload()
        //{
        //    if (i == 1)
        //    {
        //        for (int j = 0; j != 1; )
        //        {
        //            browsers[j].Url = new Uri("http://ri.search.yahoo.com/_ylt=A8tUwZMsxBpTa0IADB9r1gt.;_ylu=X3oDMTE2NWRsb2Q4BHNlYwNzcgRwb3MDMQRjb2xvA3R3MQR2dGlkA1ZJUFRXNjZfNTE4/RV=2/RE=1394291885/RO=10/RU=http%3a%2f%2fwww.jor.com.tw%2f/RK=0/RS=YDY4NrxD7drg0Qdn3qIDL34Y3Hg-");
        //            j++;
        //        }
        //        i = 0;
        //        Console.WriteLine("another 1000");
        //    }
        //    i++;

        //}
    }

}
