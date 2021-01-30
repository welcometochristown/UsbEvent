using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
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

        public string DisplayMethod { get; set; }

        public const string DisplaySwitch = "DS";
        public const string DisplayConfig = "DC";

        public enum DisplayModeOptionEnum
        {
            Internal,
            External,
            Extend,
            Clone
        }

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern long SetDisplayConfig(uint numPathArrayElements,
        IntPtr pathArray, uint numModeArrayElements, IntPtr modeArray, uint flags);

        UInt32 SDC_TOPOLOGY_INTERNAL = 0x00000001;
        UInt32 SDC_TOPOLOGY_CLONE = 0x00000002;
        UInt32 SDC_TOPOLOGY_EXTEND = 0x00000004;
        UInt32 SDC_TOPOLOGY_EXTERNAL = 0x00000008;
        UInt32 SDC_APPLY = 0x00000080;

        public void CloneDisplays()
        {
            SetDisplayConfig(0, IntPtr.Zero, 0, IntPtr.Zero, (SDC_APPLY | SDC_TOPOLOGY_CLONE));
        }

        public void ExtendDisplays()
        {
            SetDisplayConfig(0, IntPtr.Zero, 0, IntPtr.Zero, (SDC_APPLY | SDC_TOPOLOGY_EXTEND));
        }

        public void ExternalDisplay()
        {
            SetDisplayConfig(0, IntPtr.Zero, 0, IntPtr.Zero, (SDC_APPLY | SDC_TOPOLOGY_EXTERNAL));
        }

        public void InternalDisplay()
        {
            SetDisplayConfig(0, IntPtr.Zero, 0, IntPtr.Zero, (SDC_APPLY | SDC_TOPOLOGY_INTERNAL));
        }

        private void SetDisplayModeDC(DisplayModeOptionEnum mode)
        {
            switch (mode)
            {
                case DisplayModeOptionEnum.External:
                    ExternalDisplay();
                    break;
                case DisplayModeOptionEnum.Internal:
                    InternalDisplay();
                    break;
                case DisplayModeOptionEnum.Extend:
                    ExtendDisplays();
                    break;
                case DisplayModeOptionEnum.Clone:
                    CloneDisplays();
                    break;
            }
        }

        private void SetDisplayModeDS(DisplayModeOptionEnum mode)
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
                case DisplayModeOptionEnum.Clone:
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
                    if(DisplayMethod == DisplaySwitch)
                        SetDisplayModeDS(DisplayMode);

                    if (DisplayMethod == DisplayConfig)
                        SetDisplayModeDC(DisplayMode);
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
