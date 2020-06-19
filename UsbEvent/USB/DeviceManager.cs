using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsbActioner.USB
{
    public static class DeviceManager
    {
        private static List<UsbDevice> _devices;
        public static IEnumerable<UsbDevice> Devices
        {
            get
            {
                return _devices;
            }
        }

        static DeviceManager()
        {
            _devices = new List<UsbDevice>();
        }

        public static void Add(UsbDevice e)
        {
            _devices.Add(e);
        }

        public static void AddRange(IEnumerable<UsbDevice> e)
        {
            _devices.AddRange(e);
        }

        public static void Remove(UsbDevice e)
        {
            _devices.Remove(e);
        }

        public static void RemoveAt(int index)
        {
            _devices.RemoveAt(index);
        }

        public static void AddDeviceFromEvent(UsbEvent e)
        {
            var device = _devices.SingleOrDefault(n => n.Equals(e.device));

            if (device != null)
                device.last_event = e;
            else
                _devices.Add(e.device);
        }

    }
}
