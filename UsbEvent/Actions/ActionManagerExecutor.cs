using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsbActioner.Actions
{
    public class ActionManagerExecutor
    {
        public static async Task ActionEvents(USB.UsbEvent e)
        {
            var actions_to_execute = ActionManager.Actions.Where(n => n.device.Equals(e.device) && n.HasType(e.event_type));

            List<Task> tasks = new List<Task>();

            foreach (var a in actions_to_execute)
            {
                tasks.Add(new Task(() =>
                {
                    a.Execute();
                }));
            }

           await Task.WhenAll(tasks.ToArray());
        }
    }
}
