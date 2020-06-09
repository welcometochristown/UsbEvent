using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsbActioner.USB;

namespace UsbActioner.Actions
{
    public abstract class EventAction
    {
        public UsbDevice device;

        public abstract void Execute();

        public abstract string Name { get; }

        public USB.UsbDevice.DeviceEventAction Actions { get; set;}

        public override string ToString()
        {
            List<USB.UsbDevice.DeviceEventAction> action_list = new List<UsbDevice.DeviceEventAction>();

            if((Actions & USB.UsbDevice.DeviceEventAction.ADDED) == USB.UsbDevice.DeviceEventAction.ADDED)
                action_list.Add(USB.UsbDevice.DeviceEventAction.ADDED);

            if ((Actions & USB.UsbDevice.DeviceEventAction.REMOVED) == USB.UsbDevice.DeviceEventAction.REMOVED)
                action_list.Add(USB.UsbDevice.DeviceEventAction.REMOVED);

            if (action_list.Count == 0)
                action_list.Add(UsbDevice.DeviceEventAction.NONE);

            return $"{device.device_name} | {string.Join(",", action_list)} | {Name}";
        }

    }
}
