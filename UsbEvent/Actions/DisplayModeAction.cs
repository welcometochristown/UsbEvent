using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsbActioner.Actions.Forms;
using UsbActioner.Exceptions;

namespace UsbActioner.Actions
{
    public class DisplayModeAction : EventAction
    {
        public override string Name => nameof(DisplayMode);

        public DisplayModeOptionEnum DisplayMode { get; set; }

        public enum DisplayModeOptionEnum
        {
            Internal,
            External,
            Extend,
            Duplicate
        }

        private static void SetDisplayMode(DisplayModeOptionEnum mode)
        {
            var proc = new Process();
            proc.StartInfo.FileName = "DisplaySwitch.exe";
            switch (mode)
            {
                case DisplayModeOptionEnum.External:
                    proc.StartInfo.Arguments = "/external";
                    break;
                case DisplayModeOptionEnum.Internal:
                    proc.StartInfo.Arguments = "/internal";
                    break;
                case DisplayModeOptionEnum.Extend:
                    proc.StartInfo.Arguments = "/extend";
                    break;
                case DisplayModeOptionEnum.Duplicate:
                    proc.StartInfo.Arguments = "/clone";
                    break;
            }
            proc.Start();
        }


        public override async Task Execute()
        {
            try
            {
                await Task.Run(() =>
                {
                    SetDisplayMode(DisplayMode);
                });
            }
            catch (Exception ex)
            {
                throw new ActionExecutionFailedException($"Failed to set display mode to {DisplayMode}", ex);
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} | {DisplayMode.ToString()}";
        }

        public override DialogResult EditAction()
        {
            return FrmDisplayMode.EditAction(this);
        }
    }
}
