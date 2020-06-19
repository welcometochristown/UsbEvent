using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsbActioner.Actions
{
    public static class ActionManager
    {
        public const string FILENAME = "amgr.json";

        private static List<EventAction> _actions;
        public static IEnumerable<EventAction> Actions
        {
            get
            {
                return _actions;
            }
        }

        static ActionManager()
        {
            _actions = new List<EventAction>();
        }

        public static void Add(EventAction e)
        {
            _actions.Add(e);
            SaveToFile();
        }

        public static void SaveToFile(string filename = FILENAME)
        {
            FileOperations.FileOperation.SaveContent(_actions, filename);
        }

        public static void AddRange(IEnumerable<EventAction> e)
        {
            _actions.AddRange(e);
            SaveToFile();
        }

        public static void Remove(EventAction e)
        {
            _actions.Remove(e);
        }

        public static void RemoveAt(int index)
        {
            _actions.RemoveAt(index);
        }

    }
}
