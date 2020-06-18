using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsbActioner.USB;
using static UsbActioner.USB.UsbEvent;

namespace UsbActioner.Actions
{
    public abstract class EventAction
    {
        public UsbDevice device;

        public abstract void Execute();

        public abstract string Name { get; }

        public DeviceEventType Actions { get; set;}

        public bool HasType(DeviceEventType type)
        {
            return ((Actions & type) == type);
        }

        public override string ToString()
        {
            List<DeviceEventType> action_list = new List<DeviceEventType>();

            if((Actions & DeviceEventType.CREATION) == DeviceEventType.CREATION)
                action_list.Add(DeviceEventType.CREATION);

            if ((Actions & DeviceEventType.DELETION) == DeviceEventType.DELETION)
                action_list.Add(DeviceEventType.DELETION);

            if (action_list.Count == 0)
                action_list.Add(DeviceEventType.NONE);

            return $"{device.device_name} | {string.Join(",", action_list)} | {Name}";
        }

    }
}
