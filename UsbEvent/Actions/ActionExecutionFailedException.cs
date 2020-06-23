using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsbActioner.Actions
{
    public class ActionExecutionFailedException : Exception
    {
        public ActionExecutionFailedException(string message, Exception ex)
            :base(message, ex)
        {

        }

        public ActionExecutionFailedException(string message)
            :base(message)
        {

        }
    }
}
