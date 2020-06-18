using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsbActioner.Actions
{
    public static class ActionManager
    {
        public static readonly IEnumerable<EventAction> Actions;

        static ActionManager()
        {
            Actions = new List<EventAction>();
        }

        static void Add(EventAction e)
        {

        }

        static void Remove(EventAction e)
        {

        }

        static void Remove(int index)
        {

        }
    }
}
