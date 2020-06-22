using System;

namespace UsbActioner.USB
{
    public class UsbEvent
    {
        [Flags]
        public enum DeviceEventType
        {
            NONE = 0x0,
            UNKNOWN = 0x1,
            CREATION = 0x2,
            DELETION = 0x4

        }
        public UsbDevice device;
        public string event_name;


        public DeviceEventType event_type
        {
            get
            {
                return ParseEventName(event_name);
            }
        }

        public DeviceEventType ParseEventName(string name)
        {
            switch (name)
            {
                case "__InstanceCreationEvent": return DeviceEventType.CREATION;
                case "__InstanceDeletionEvent": return DeviceEventType.DELETION;
                default: return DeviceEventType.UNKNOWN;
            }
        }

        public override string ToString()
        {
            return $"{event_name} - {device.ToString()}";
        }
    }

}
