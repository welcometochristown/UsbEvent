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

        public const uint WS_MAXIMIZE = 0x01000000;
        public const uint WS_MINIMIZE = 0x20000000;

        static readonly int GWL_STYLE = -16;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        static extern UInt32 GetWindowLong(IntPtr hWnd, int nIndex);
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
                    var proc = Process.GetProcessesByName(processname);

                    if (proc.Any())
                    {
                        foreach (var p in proc.Where(n => n.MainWindowHandle.ToInt32() != 0))
                        {
                            try
                            {
                                var style = GetWindowLong(p.MainWindowHandle, GWL_STYLE);

                                if ((style & WS_MINIMIZE) == WS_MINIMIZE)
                                {
                                    //minimizing complete
                                    return true;
                                }

                                //attempt another minimize
                                ShowWindow(p.MainWindowHandle, SW_MINIMIZE);
                            }
                            catch
                            {
                                break;
                            }
                        }
                    }
                    return false;

                });
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
