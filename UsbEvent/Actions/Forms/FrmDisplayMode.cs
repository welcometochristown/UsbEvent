using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsbActioner.Actions;
using static UsbActioner.Actions.DisplayModeAction;
using static UsbActioner.USB.UsbEvent;

namespace UsbActioner.Actions.Forms
{
    public partial class FrmDisplayMode : FrmEventActionBase
    {
        public DisplayModeOptionEnum DisplayModeOption { get; set; } = DisplayModeOptionEnum.Internal;


        public RadioButton [] buttons;

        public FrmDisplayMode()
        {
            InitializeComponent();
            buttons = new[] { rdoInternal, rdoExternal, rdoExtend, rdoDuplicate };
        }

        private void FrmDisplayMode_Load(object sender, EventArgs e)
        {
            foreach (var rb in buttons)
            {
                rb.Checked = (rb.Text == DisplayModeOption.ToString());
            }

        }

        private void FrmDisplayMode_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach(var rb in buttons)
            {
                if(rb.Checked)
                {
                    this.DisplayModeOption = (DisplayModeOptionEnum)Enum.Parse(typeof(DisplayModeOptionEnum), rb.Text);
                    break;
                }
            }
        }

        public static DialogResult EditAction(DisplayModeAction action)
        {
            FrmDisplayMode frm = new FrmDisplayMode();
            frm.DisplayModeOption = action.DisplayMode;
            frm.DeviceActions = action.Actions;

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                action.DisplayMode = frm.DisplayModeOption;
                action.Actions = frm.DeviceActions;
            }

            return result;
        }
    }
}

