using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuzzy_lana{
    class Program{
        static void Main(string[] args){
            //Hello World Segment
            Console.WriteLine("\aHello World!");
            Console.ReadKey();
                        
            Console.WriteLine("\aWhat's the Password?\n");
            string pass=Console.ReadLine();
            
            if(pass=="CorrectStapleHorse" || pass=="3wa4es5rd6tf*"){
                string strCmdText = "/C ping google.com";
                System.Diagnostics.Process.Start("CMD.exe", strCmdText);
                CLI_CLEAN();
                Console.ReadKey(); }

        }

        static void BATCH_DUMP(){
        //Use selector above and place code down here
        //I want it to dump VBS and batch scripts that I use regularly

        }

        static void CLI_CLEAN(){
        //Delete Temp Files, supress errors
        System.Diagnostics.Process Clean=new System.Diagnostics.Process();
        System.Diagnostics.ProcessStartInfo GitRDone=new System.Diagnostics.ProcessStartInfo();
        GitRDone.WindowStyle=System.Diagnostics.ProcessWindowStyle.Hidden;
        GitRDone.FileName="cmd.exe";

        GitRDone.Arguments = "/C del %homedrive%\\Temp\\*.* /F /S /Q"; Clean.StartInfo = GitRDone; Clean.Start();
        GitRDone.Arguments = "/C RMDIR %homedrive%\\Temp\\ /S /Q"; Clean.StartInfo = GitRDone; Clean.Start();
        GitRDone.Arguments = "/C del %localappdata%\\Temp\\*.* /F /S /Q"; Clean.StartInfo = GitRDone; Clean.Start();
        GitRDone.Arguments = "/C RMDIR %localappdata%\\Temp\\ /S /Q"; Clean.StartInfo = GitRDone; Clean.Start();
        GitRDone.Arguments = "/C del %appdata%\\Temp\\*.* /F /S /Q"; Clean.StartInfo = GitRDone; Clean.Start();
        GitRDone.Arguments = "/C RMDIR %appdata%\\Temp\\ /S /Q"; Clean.StartInfo = GitRDone; Clean.Start();
        GitRDone.Arguments = "/C del %Temp%\\*.* /F /S /Q"; Clean.StartInfo = GitRDone; Clean.Start();
        GitRDone.Arguments = "/C RMDIR %Temp%\\ /S /Q"; Clean.StartInfo = GitRDone; Clean.Start();
        
        }

        static void PROG_CLEAN(){
        //Check for %LOCALAPPDATA%\JSM - If not exist, fetch package and extract


        //Place an IF statement so that files are in JSM folder
        //Quick Clean
        string cc1 = "/AUTO";
        System.Diagnostics.Process.Start("C:\\Program Files\\CCleaner\\CCleaner.exe", cc1);
        //Quick Defrag
        string df1 = "C:\\ /QD /S";
        System.Diagnostics.Process.Start("C:\\Program Files\\Defraggler\\df.exe", df1);
        //Full Defrag - biggest to the end
        string df2 = "C:\\ /Large *.* 250 /S";
        System.Diagnostics.Process.Start("C:\\Program Files\\Defraggler\\df.exe", df2);
        }
    }
}

