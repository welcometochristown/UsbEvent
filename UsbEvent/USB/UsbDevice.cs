using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsbActioner.USB
{
    public class UsbDevice
    {
        public string device_name;
        public string device_guid;

        public UsbEvent last_event;

        public override bool Equals(object obj)
        {
            var u = obj as UsbDevice;
            return u.device_guid.Equals(device_guid) && u.device_name.Equals(device_name);
        }

        public override string ToString()
        {
            return $"{device_name} {device_guid}";
        }
    }
}
