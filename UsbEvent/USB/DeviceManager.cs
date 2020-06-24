using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsbActioner.USB
{
    public static class DeviceManager
    {
        public const string FILENAME = "dmgr.json";
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
            SaveDevicesToFile();
        }

        public static void AddRange(IEnumerable<UsbDevice> e)
        {
            _devices.AddRange(e);
            SaveDevicesToFile();
        }

        public static void Remove(UsbDevice e)
        {
            _devices.Remove(e);
            SaveDevicesToFile();
        }

        public static void RemoveAt(int index)
        {
            _devices.RemoveAt(index);
            SaveDevicesToFile();
        }

        public static void Clear()
        {
            _devices.Clear();
            SaveDevicesToFile();
        }

        public static void AddDeviceFromEvent(UsbEvent e)
        {
            var device = _devices.SingleOrDefault(n => n.Equals(e.device));

            if (device != null)
                device.last_event = e.event_type;
            else
            {
                _devices.Add(e.device);
                SaveDevicesToFile();

            }
        }

        public static void LoadDevicesFromFile(string filename = FILENAME)
        {
            try
            {
                var result = FileOperations.FileOperation.LoadObject<IEnumerable<UsbDevice>>(filename);

                if (result != null)
                    _devices = result.ToList();
            }
            catch (FileNotFoundException)
            { 
                if(filename != FILENAME)
                    throw; 
            }
            catch (DirectoryNotFoundException)
            {
                if (filename != FILENAME)
                    throw;
            }

            if (_devices == null)
                _devices = new List<UsbDevice>();
        }

        public static void SaveDevicesToFile(string filename = FILENAME)
        {
             FileOperations.FileOperation.SaveContent(_devices, filename);
        }

    }
}
