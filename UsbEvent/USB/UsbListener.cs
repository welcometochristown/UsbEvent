using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;

namespace UsbActioner.USB
{
    public class UsbListener
    {
       public event Action<UsbEvent> NewUsbEvent;

        private ManagementEventWatcher watcher;

        private bool isListening;

        public async void StartListening()
        {
            if (isListening)
                return;

            try
            {
                isListening = true;
                await Listen();
            } 
            catch 
            {
                //err
            }
            finally
            {
                isListening = false;
            }
        }

        private async Task Listen()
        {
            await Task.Run(() =>
            {
                var query = new WqlEventQuery();
                query.EventClassName = "__InstanceOperationEvent";
                query.WithinInterval = new TimeSpan(0, 0, 2);
                query.Condition = @"TargetInstance ISA 'Win32_PnPEntity'";

                watcher = new ManagementEventWatcher();
                watcher.EventArrived += new EventArrivedEventHandler(watcher_EventArrived);
                watcher.Query = query;
                watcher.Start();

                while (isListening)
                    watcher.WaitForNextEvent();

                watcher.Stop();
            });
        }

        private void watcher_EventArrived(object sender, EventArrivedEventArgs e)
        {
            ManagementBaseObject instance = (ManagementBaseObject)e.NewEvent["TargetInstance"];

            var evnt = new UsbEvent
            {
                event_name = e.NewEvent.ClassPath.ClassName,
                device = new UsbDevice
                {
                    device_guid = (string)instance["ClassGuid"],
                    device_name = (string)instance["Name"]
                }
            };

            evnt.device.last_event = evnt.event_type;
            NewUsbEvent?.Invoke(evnt);
        }

        public void StopListening()
        {
            isListening = false;
        }
    }
}
