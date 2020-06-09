using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsbActioner.USB
{
    public class UsbEvent
    {
        public UsbDevice device;
        public string event_name;

        public override string ToString()
        {
            return $"{event_name} - {device.ToString()}";
        }
    }

}
