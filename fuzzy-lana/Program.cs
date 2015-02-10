using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuzzy_lana
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hello World Segment
            Console.WriteLine("Hello World!");
            Console.ReadKey();
                        
            Console.WriteLine("What's the Password?\n");
            string saul=Console.ReadLine();
            
            if(saul=="ILoveBoobs" || saul=="3wa4es5rd6tf*"){
                /*Pinging Google via prompted CLI
                Wanting to do these commands without the popup.
                Ideally the program will run behind the scenes and under the radar.*/
                //string strCmdText;
                string strCmdText = "/C ping google.com";
                System.Diagnostics.Process.Start("CMD.exe", strCmdText);
                Console.ReadKey(); }

        }
    }
}
