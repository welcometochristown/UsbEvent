using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
        public override string Name => nameof(ApplicationRestartAction);
        public string ApplicationProcessName { get; set; }
        public ProcessWindowStyle WindowStyle { get; set; }

        private void RestartProcess(string processname)
        {
            var processes = Process.GetProcessesByName(processname);

            if (!processes.Any())
                return;

            var process = processes[0];

            if (process == null)
                return;

            process.Kill();

            ProcessStartInfo startInfo = new ProcessStartInfo(process.MainModule.FileName);

            startInfo.WindowStyle = WindowStyle;
            startInfo.UseShellExecute = true;

            Process.Start(startInfo);            
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
