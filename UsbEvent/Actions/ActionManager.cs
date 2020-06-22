using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UsbActioner.Actions.EventAction;

namespace UsbActioner.Actions
{
    public static class ActionManager
    {
        public const string FILENAME = "amgr.json";

        private static List<EventAction> _actions = new List<EventAction>();
        public static IEnumerable<EventAction> Actions
        {
            get
            {
                return _actions;
            }
        }

        public static void Add(EventAction e)
        {
            _actions.Add(e);
            SaveActionsToFile();
        }

        public static void LoadActionsFromFile(string filename = FILENAME)
        {
            try
            {
                var result = FileOperations.FileOperation.LoadObject<EventActionCollectionWrapper>(filename);

                if(result != null)
                    _actions = result.UnWrap().ToList();
            }
            catch (FileNotFoundException)
            { }
            catch (DirectoryNotFoundException)
            { }
            if (_actions == null)
                _actions = new List<EventAction>();
        }

        public static void SaveActionsToFile(string filename = FILENAME)
        {
            FileOperations.FileOperation.SaveContent(EventActionCollectionWrapper.Wrap(_actions), filename);
        }

        public static void AddRange(IEnumerable<EventAction> e)
        {
            _actions.AddRange(e);
            SaveActionsToFile();
        }

        public static void Remove(EventAction e)
        {
            _actions.Remove(e);
            SaveActionsToFile();
        }

        public static void RemoveAt(int index)
        {
            _actions.RemoveAt(index);
            SaveActionsToFile();
        }

    }
}
