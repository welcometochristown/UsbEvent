using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsbActioner.USB;

namespace UsbActioner.Actions
{
    public class ApplicationRestartAction : EventAction
    {
        public override string Name => nameof(ApplicationRestartAction);
        public string ApplicationProcessName { get; set; }
        public ProcessWindowStyle WindowStyle { get; set; }

        public ApplicationRestartAction()
        {
        }

        private void RestartProcess(string processname)
        {
            var processes = Process.GetProcessesByName(this.ApplicationProcessName);

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

        public override void Execute()
        {
            RestartProcess(ApplicationProcessName);
        }

        public override string ToString()
        {
            return $"{base.ToString()} | {ApplicationProcessName} ({WindowStyle.ToString()})";
        }
    }
}
