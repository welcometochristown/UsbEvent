using Newtonsoft.Json;
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

        public DateTime? LastRun { get; set; }

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

        public class EventActionCollectionWrapper
        {
            public List<EventActionWrapper> Items = new List<EventActionWrapper>();

            public static EventActionCollectionWrapper Wrap(IEnumerable<EventAction> col)
            {
                return new EventActionCollectionWrapper()
                {
                    Items = col.Select(n => EventActionWrapper.Wrap(n)).ToList()
                };
            }
            public IEnumerable<EventAction> UnWrap()
            {
                foreach(var i in Items)
                {
                    yield return JsonConvert.DeserializeObject(i.Object, i.ActionType) as EventAction;
                }
            }

        }

        public class EventActionWrapper
        {
            public Type ActionType;
            public string Object;

            public static EventActionWrapper Wrap(EventAction obj)
            {
                return new EventActionWrapper { ActionType = obj.GetType(), Object = Newtonsoft.Json.JsonConvert.SerializeObject(obj) };
            }
        }
    }

  
}
