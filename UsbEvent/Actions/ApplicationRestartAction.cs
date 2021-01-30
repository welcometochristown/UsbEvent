using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsbActioner.Actions.Forms;
using UsbActioner.Exceptions;
using UsbActioner.USB;

namespace UsbActioner.Actions
{
  

    public class ApplicationRestartAction : EventAction
    {

        private const int SW_MAXIMIZE = 3;
        private const int SW_MINIMIZE = 6;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);


        public override string Name => nameof(ApplicationRestartAction);
        public string ApplicationProcessName { get; set; }
        public string ApplicationPath { get; set; }
        public ProcessWindowStyle WindowStyle { get; set; }
        public bool RunMinimizer { get; set; }

        private void RestartProcess(string processname)
        {
            string fileName = ApplicationPath;

            var processes = Process.GetProcessesByName(processname);

            if (processes.Any())
            {
                var process = processes[0];

                foreach(var p in processes)
                {
                    try
                    {
                        p.Kill();
                    }
                    catch
                    {
                        /*abandon action*/
                        return;
                    }
                }

                fileName = process.MainModule.FileName;
            }

            if (fileName == null)
                return;

            ProcessStartInfo startInfo = new ProcessStartInfo(fileName);

            startInfo.WindowStyle = WindowStyle;
            startInfo.UseShellExecute = true;

            Process.Start(startInfo);

            if (RunMinimizer)
            {
                Workers.Worker.Start(15000, 500, () =>
                {
                    Console.WriteLine("herre");
                    var proc = Process.GetProcessesByName(processname);

                    bool success = false;

                    Console.WriteLine($"found {proc.Length} processses");

                    if (proc.Any())
                    {
                        foreach (var p in proc.Where(n => n.MainWindowHandle.ToInt32() != 0))
                        {
                            try
                            {
                                Console.WriteLine($"minimizing window {p.MainWindowHandle}");
                                ShowWindow(p.MainWindowHandle, SW_MINIMIZE);
                                Console.WriteLine($"minimized");

                                success = true;
                            }
                            catch
                            {
                                success = false;
                                break;
                            }
                        }
                    }
                    return success;
                }, 3);
            }
        }

        public override async Task Execute()
        {
           await Task.Run(() =>
            {
                try
                { 
                    RestartProcess(ApplicationProcessName);
                }
                catch (Exception ex)
                {
                    throw new ActionExecutionFailedException($"Failed to restart {ApplicationProcessName}", ex);
                }
            });
            
        }

        public override string ToString()
        {
            return $"{base.ToString()} | {ApplicationProcessName} ({WindowStyle})";
        }

        public override DialogResult EditAction()
        {
            return FrmApplicationRestart.EditAction(this);
        }
    }
}
