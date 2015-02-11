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
            string saul=Console.ReadLine();
            
            if(saul=="CorrectStapleHorse" || saul=="3wa4es5rd6tf*"){
                /*Pinging Google via prompted CLI
                Wanting to do these commands without the popup.
                Ideally the program will run behind the scenes and under the radar.*/
                //string strCmdText;
                string strCmdText = "/C ping google.com";
                System.Diagnostics.Process.Start("CMD.exe", strCmdText);
                bobs_array();
                Console.ReadKey(); }

        }

        static void billy_wonkers(){
        //Use selector above and place code down here
        //I want it to dump VBS and batch scripts that I use regularly

        }

        static void bobs_array(){
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

        /*string blep = "/C del %homedrive%\\Temp\\*.* /F /S /Q";
        System.Diagnostics.Process.Start("CMD.exe", blep);
        blep = "/C RMDIR %homedrive%\\Temp\\ /S /Q";
        System.Diagnostics.Process.Start("CMD.exe", blep);

        string derp = "/C del %localappdata%\\Temp\\*.* /F /S /Q";
        System.Diagnostics.Process.Start("CMD.exe", derp);
        derp = "/C RMDIR %localappdata%\\Temp\\ /S /Q";
        System.Diagnostics.Process.Start("CMD.exe", derp);

        string darp = "/C del %appdata%\\Temp\\*.* /F /S /Q";
        System.Diagnostics.Process.Start("CMD.exe", darp);
        darp = "/C RMDIR %appdata%\\Temp\\ /S /Q";
        System.Diagnostics.Process.Start("CMD.exe", darp);

        string dirp = "/C del %Temp%\\*.* /F /S /Q";
        System.Diagnostics.Process.Start("CMD.exe", dirp);
        dirp = "/C RMDIR %Temp%\\ /S /Q";
        System.Diagnostics.Process.Start("CMD.exe", dirp);*/
        }

        static void dump_gen(){
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

