using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsbActioner.Actions
{
    public class DisplayMode : EventAction
    {
        public override string Name => nameof(DisplayMode);

        enum DisplayModeEnum
        {
            Internal,
            External,
            Extend,
            Duplicate
        }

        private static void SetDisplayMode(DisplayModeEnum mode)
        {
            var proc = new Process();
            proc.StartInfo.FileName = "DisplaySwitch.exe";
            switch (mode)
            {
                case DisplayModeEnum.External:
                    proc.StartInfo.Arguments = "/external";
                    break;
                case DisplayModeEnum.Internal:
                    proc.StartInfo.Arguments = "/internal";
                    break;
                case DisplayModeEnum.Extend:
                    proc.StartInfo.Arguments = "/extend";
                    break;
                case DisplayModeEnum.Duplicate:
                    proc.StartInfo.Arguments = "/clone";
                    break;
            }
            proc.Start();
        }


        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
