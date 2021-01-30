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
    public class ApplicationKillAction : EventAction
    {
        public override string Name => nameof(ApplicationKillAction);
        public string ApplicationProcessName { get; set; }

        private void KillProcess(string processname)
        {
            var processes = Process.GetProcessesByName(processname);

            if (processes.Any())
            {
                var process = processes[0];

                foreach (var p in processes)
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
            }
        }

        public override async Task Execute()
        {
            await Task.Run(() =>
            {
                try
                {
                    KillProcess(ApplicationProcessName);
                }
                catch (Exception ex)
                {
                    throw new ActionExecutionFailedException($"Failed to restart {ApplicationProcessName}", ex);
                }
            });

        }

        public override string ToString()
        {
            return $"{base.ToString()} | {ApplicationProcessName})";
        }

        public override DialogResult EditAction()
        {
            return FrmApplicationKill.EditAction(this);
        }
    }
}
