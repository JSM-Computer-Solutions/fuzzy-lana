using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;

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

        //SPAAAAAAAACCCEEEE
        static void CLI_CLEAN(){
            //Delete Temp Files, supress errors - FINISHED
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
            GitRDone.Arguments = "/C powercfg /hibernate off"; Clean.StartInfo = GitRDone; Clean.Start();
        }

        //SPAAAAAAAACCCEEEE
        static void PROG_CLEAN(){
            //Check for %LOCALAPPDATA%\JSM - If not exist, fetch package and extract


            //Place an IF statement so that files are in JSM folder
            //Quick Clean
            string cc1 = "/C /AUTO";
            System.Diagnostics.Process.Start("C:\\Program Files\\CCleaner\\CCleaner.exe", cc1);
            //Quick Defrag
            string df1 = "/C C:\\ /QD /S";
            System.Diagnostics.Process.Start("C:\\Program Files\\Defraggler\\df.exe", df1);
            //Full Defrag - biggest to the end
            string df2 = "/C C:\\ /Large *.* 250 /S";
            System.Diagnostics.Process.Start("C:\\Program Files\\Defraggler\\df.exe", df2);
        }

        //SPAAAAAAAACCCEEEE
        static void Exchange_2013_RUNNING(){
            
        ServiceProvider sc = new ServiceController(MSExchangeADTopology);
            
        switch (sc.Status){
            case ServiceControllerStatus.Running:
                return "Running";
            case ServiceControllerStatus.Stopped:
                return "Stopped";
            case ServiceControllerStatus.Paused:
                return "Paused";
            case ServiceControllerStatus.StopPending:
                return "Stopping";
            case ServiceControllerStatus.StartPending:
                return "Starting";
            default:
                return "Status Changing";
            }

            //Check for running MS Exchange 2013 Processes
            System.Diagnostics.Process Check=new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo CheckThis=new System.Diagnostics.ProcessStartInfo();
            CheckThis.WindowStyle=System.Diagnostics.ProcessWindowStyle.Hidden;
            CheckThis.FileName="cmd.exe";

            
            CheckThis.Arguments = "sc query MSExchangeADTopology \| find \"STATE\" \| find \"RUNNING\"\rif .%errorlevel%.==.1. sc start \"MSExchangeADTopology\""; Check.StartInfo=CheckThis; CheckThis.Start();
            
            sc query MSExchangeAntispamUpdate | find "STATE" | find "RUNNING"
            if .%errorlevel%.==.1. sc start "MSExchangeAntispamUpdate"
            
            sc query MSExchangeDagMgmt | find "STATE" | find "RUNNING"
            if .%errorlevel%.==.1. sc start "MSExchangeDagMgmt"

            sc query MSExchangeDiagnostics | find "STATE" | find "RUNNING"
            if .%errorlevel%.==.1. sc start "MSExchangeDiagnostics"

            sc query MSExchangeEdgeSync | find "STATE" | find "RUNNING"
            if .%errorlevel%.==.1. sc start "MSExchangeEdgeSync"

            sc query MSExchangeFrontEndTransport | find "STATE" | find "RUNNING"
            if .%errorlevel%.==.1. sc start "MSExchangeFrontEndTransport"

            sc query MSExchangeHM | find "STATE" | find "RUNNING"
            if .%errorlevel%.==.1. sc start "MSExchangeHM"

            sc query MSExchangeIS | find "STATE" | find "RUNNING"
            if .%errorlevel%.==.1. sc start "MSExchangeIS"

            sc query MSExchangeMailboxAssistants | find "STATE" | find "RUNNING"
            if .%errorlevel%.==.1. sc start "MSExchangeMailboxAssistants"

            sc query MSExchangeMailboxReplication | find "STATE" | find "RUNNING"
            if .%errorlevel%.==.1. sc start "MSExchangeMailboxReplication"

            sc query MSExchangeDelivery | find "STATE" | find "RUNNING"
            if .%errorlevel%.==.1. sc start "MSExchangeDelivery"

            sc query MSExchangeSubmission | find "STATE" | find "RUNNING"
            if .%errorlevel%.==.1. sc start "MSExchangeSubmission"

            sc query MSExchangeMigrationWorkflow | find "STATE" | find "RUNNING"
            if .%errorlevel%.==.1. sc start "MSExchangeMigrationWorkflow"

            sc query MSExchangeRepl | find "STATE" | find "RUNNING"
            if .%errorlevel%.==.1. sc start "MSExchangeRepl"

            sc query MSExchangeRPC | find "STATE" | find "RUNNING"
            if .%errorlevel%.==.1. sc start "MSExchangeRPC"

            sc query MSExchangeFastSearch | find "STATE" | find "RUNNING"
            if .%errorlevel%.==.1. sc start "MSExchangeFastSearch"

            sc query HostControllerService | find "STATE" | find "RUNNING"
            if .%errorlevel%.==.1. sc start "HostControllerService"

            sc query MSExchangeServiceHost | find "STATE" | find "RUNNING"
            if .%errorlevel%.==.1. sc start "MSExchangeServiceHost"

            sc query MSExchangeThrottling | find "STATE" | find "RUNNING"
            if .%errorlevel%.==.1. sc start "MSExchangeThrottling"

            sc query MSExchangeTransport | find "STATE" | find "RUNNING"
            if .%errorlevel%.==.1. sc start "MSExchangeTransport"

            sc query MSExchangeTransportLogSearch | find "STATE" | find "RUNNING"
            if .%errorlevel%.==.1. sc start "MSExchangeTransportLogSearch"

            sc query MSExchangeUM | find "STATE" | find "RUNNING"
            if .%errorlevel%.==.1. sc start "MSExchangeUM"

            sc query MSExchangeUMCR | find "STATE" | find "RUNNING"
            if .%errorlevel%.==.1. sc start "MSExchangeUMCR"

            sc query FMS | find "STATE" | find "RUNNING"
            if .%errorlevel%.==.1. sc start "FMS"

            sc query msoidsvc | find "STATE" | find "RUNNING"
            if .%errorlevel%.==.1. sc start "msoidsvc"
            
        }
    }
}

