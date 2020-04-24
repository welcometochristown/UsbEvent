using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Diagnostics;

namespace UsbEvent
{
    class Program
    {
        static readonly Guid GUID_DEVCLASS_USB = new Guid("{c166523c-fe0c-4a94-a586-f1a80cfbbf3e}");
        static readonly string NAME = "Microphone (Blue Snowball)";

        static void RestartApplication(string processname)
        {
            var process = Process.GetProcessesByName(processname)[0];

            if (process != null)
            {
                process.Kill();

                ProcessStartInfo startInfo = new ProcessStartInfo(process.MainModule.FileName);

                startInfo.WindowStyle = ProcessWindowStyle.Minimized;
                startInfo.UseShellExecute = true;

                Process.Start(startInfo);
            }
        }

        static void Main(string[] args)
        {
            try
            {
                StartMonitoring();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
       
        }

        private static void StartMonitoring()
        {
            var query = new WqlEventQuery();
            query.EventClassName = "__InstanceOperationEvent";
            query.WithinInterval = new TimeSpan(0, 0, 2);
            query.Condition = @"TargetInstance ISA 'Win32_PnPEntity'";

            ManagementEventWatcher watcher = new ManagementEventWatcher();
            watcher.EventArrived += new EventArrivedEventHandler(watcher_EventArrived);
            watcher.Query = query;
            watcher.Start();

            while (true)
            {
                watcher.WaitForNextEvent();
            }

        }

        private static void SetDisplayMode(DisplayMode mode)
        {
            var proc = new Process();
            proc.StartInfo.FileName = "DisplaySwitch.exe";
            switch (mode)
            {
                case DisplayMode.External:
                    proc.StartInfo.Arguments = "/external";
                    break;
                case DisplayMode.Internal:
                    proc.StartInfo.Arguments = "/internal";
                    break;
                case DisplayMode.Extend:
                    proc.StartInfo.Arguments = "/extend";
                    break;
                case DisplayMode.Duplicate:
                    proc.StartInfo.Arguments = "/clone";
                    break;
            }
            proc.Start();
        }
        enum DisplayMode
        {
            Internal,
            External,
            Extend,
            Duplicate
        }
        private static void watcher_EventArrived(object sender, EventArrivedEventArgs e)
        {
            ManagementBaseObject instance = (ManagementBaseObject)e.NewEvent["TargetInstance"];
            string name = e.NewEvent.ClassPath.ClassName;

            Console.WriteLine($"{name} - {(string)instance["Name"]} ({(string)instance["ClassGuid"]})");

            if (new Guid((string)instance["ClassGuid"]) == GUID_DEVCLASS_USB 
                && ((string)instance["Name"]).Replace(" " , String.Empty).Equals(NAME.Replace(" ", String.Empty), StringComparison.InvariantCultureIgnoreCase) )
            {
                switch(name)
                {
                    case "__InstanceCreationEvent":
                        {
                            Console.WriteLine("Restarting Reaper");
                            RestartApplication("REAPER");

                            Console.WriteLine("SetDisplayMode(Extend)");
                            SetDisplayMode(DisplayMode.Extend);

                            break;
                        }
                    case "__InstanceDeletionEvent":
                        {
                            Console.WriteLine("SetDisplayMode(Duplicate)");
                            SetDisplayMode(DisplayMode.Duplicate);

                            break;
                        }
                }

                
                
            }
        }

    }
}
