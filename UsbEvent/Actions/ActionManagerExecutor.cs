﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsbActioner.Actions
{
    public class ActionManagerExecutor
    {
        public static async Task ExecActions(USB.UsbEvent e)
        {
            var actions_to_execute = ActionManager.Actions.Where(n => n.device.Equals(e.device) && n.HasType(e.event_type));

            List<Task> tasks = new List<Task>();

            foreach (var a in actions_to_execute)
            {
                var task = Task.Run(() =>
                {
                    a.LastRun = DateTime.Now;
                    a.Execute();
                });
                
                tasks.Add(task);
            }

           await Task.WhenAll(tasks.ToArray());
        }
    }
}
