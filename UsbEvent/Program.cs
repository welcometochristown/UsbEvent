using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace UsbEvent
{
 
    class Program
    {
        public enum State
        {
            Unknown, Active, Passive
        }

        public class Device
        {
            public Guid Guid;
            public string Name;
        }

        static readonly IEnumerable<Device> Devices = new[] {
            new Device { Name = "Microphone (Blue Snowball)", Guid = new Guid("{c166523c-fe0c-4a94-a586-f1a80cfbbf3e}") }
            ,new Device { Name = "Blue Snowball", Guid = new Guid("{4d36e96c-e325-11ce-bfc1-08002be10318}") }
            ,new Device { Name ="HID-compliant consumer control device" , Guid = new Guid("{745a17a0-74d3-11d0-b6fe-00a0c90f57da}") }
            ,new Device { Name ="USB Input Device", Guid = new Guid("{745a17a0-74d3-11d0-b6fe-00a0c90f57da}") }
            ,new Device { Name ="USB Composite Device", Guid = new Guid("{36fc9e60-c465-11cf-8056-444553540000}") }
        };

        static State CurrentState = State.Unknown;

        static partial class NativeMethods
        {
            [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

            [FlagsAttribute]
            public enum EXECUTION_STATE : uint
            {
                ES_AWAYMODE_REQUIRED = 0x00000040,
                ES_CONTINUOUS = 0x80000000,
                ES_DISPLAY_REQUIRED = 0x00000002,
                ES_SYSTEM_REQUIRED = 0x00000001

                // Legacy flag, should not be used.
                // ES_USER_PRESENT = 0x00000004
            }
        }

        public static class PowerHelper
        {
            public static void ForceSystemAwake()
            {
                NativeMethods.SetThreadExecutionState(NativeMethods.EXECUTION_STATE.ES_CONTINUOUS |
                                                      NativeMethods.EXECUTION_STATE.ES_DISPLAY_REQUIRED |
                                                      NativeMethods.EXECUTION_STATE.ES_SYSTEM_REQUIRED |
                                                      NativeMethods.EXECUTION_STATE.ES_AWAYMODE_REQUIRED);
            }

            public static void ResetSystemDefault()
            {
                Console.WriteLine("Setting Force System Awake OFF");
                NativeMethods.SetThreadExecutionState(NativeMethods.EXECUTION_STATE.ES_CONTINUOUS);
            }
        }


        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Setting Force System Awake ON");
                PowerHelper.ForceSystemAwake();

                Console.WriteLine("Monitoring...");
                StartMonitoring();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            finally
            {
                Console.WriteLine("Setting Force System Awake OFF");
                PowerHelper.ResetSystemDefault();
                Console.WriteLine("Exiting..");
            }
       
        }

        private static void RestartApplication(string processname)
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

            string instance_name = (string)instance["Name"];
            string instance_guid = (string)instance["ClassGuid"];

            string event_name = e.NewEvent.ClassPath.ClassName;

            Console.WriteLine($"{event_name} - {instance_name} ({instance_guid})");

            switch (event_name)
            {
                case "__InstanceCreationEvent":
                    {
                        if (CurrentState == State.Active)
                            break;

                        if (!Devices.Any(n => n.Guid == new Guid(instance_guid) && (instance_name).Replace(" ", String.Empty).Equals(n.Name.Replace(" ", String.Empty), StringComparison.InvariantCultureIgnoreCase)))
                            break;

                        Console.WriteLine("SetDisplayMode(Extend)");
                        SetDisplayMode(DisplayMode.Extend);

                        Console.WriteLine("Restarting Reaper");
                        RestartApplication("REAPER");

                        CurrentState = State.Active;

                        break;
                    }
                case "__InstanceDeletionEvent":
                    {
                        if (CurrentState == State.Passive)
                            break;

                        if (!Devices.Any(n => n.Guid == new Guid(instance_guid) && (instance_name).Replace(" ", String.Empty).Equals(n.Name.Replace(" ", String.Empty), StringComparison.InvariantCultureIgnoreCase)))
                            break;

                        Console.WriteLine("SetDisplayMode(Duplicate)");
                        SetDisplayMode(DisplayMode.Duplicate);

                        CurrentState = State.Passive;

                        break;
                    }
            }
        }
    }
}
