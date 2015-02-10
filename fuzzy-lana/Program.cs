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
            Console.WriteLine("Hello World!");
            Console.ReadKey();
            string strCmdText;
            strCmdText = "/C ping google.com";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            Console.ReadKey();
        }
    }
}
