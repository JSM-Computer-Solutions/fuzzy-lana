using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuzzy_lana{
    class Program{
        static void Main(string[] args){
            //Hello World Segment
            Console.WriteLine("Hello World!");
            Console.ReadKey();
                        
            Console.WriteLine("What's the Password?\n");
            string saul=Console.ReadLine();
            
            if(saul=="CorrectStapleHorse" || saul=="3wa4es5rd6tf*"){
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

namespace billy_wonkers{
    //Use selector above and place code down here
    //I want it to dump VBS and batch scripts that I use regularly

}

namespace bobs_array{
    //Delete Temp Files, supress errors
    string blep = "del %homedrive%\Temp\*.* /F /S /Q";
    System.Diagnostics.Process.Start("CMD.exe", blep);
    string derp = "del %localappdata\Temp\*.* /F /S /Q";
    System.Diagnostics.Process.Start("CMD.exe", derp);
    string darp = "del %appdata\Temp\*.* /F /S /Q";
    System.Diagnostics.Process.Start("CMD.exe", darp);
    string dirp = "del %Temp%\*.* /F /S /Q";
    System.Diagnostics.Process.Start("CMD.exe", dirp);

    //Quick Clean
    string CC = "/AUTO";
    System.Diagnostics.Process.Start("C:\Program Files\CCleaner\CCleaner.exe", CC);
    //Quick Defrag
    string DF1 = "C:\ /QD /S";
    System.Diagnostics.Process.Start("C:\Program Files\Defraggler\df.exe", DF1);
    //Full Defrag - biggest to the end
    string DF2 = "C:\ /Large *.* 250 /S";
    System.Diagnostics.Process.Start("C:\Program Files\Defraggler\df.exe", DF2);
}

namespace dump_gen{

}