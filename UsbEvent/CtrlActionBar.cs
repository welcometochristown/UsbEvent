using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsbActioner
{
    public partial class CtrlActionBar : UserControl
    {
        public USB.UsbDevice.DeviceEventAction Actions
        {
            get
            {
                USB.UsbDevice.DeviceEventAction result = USB.UsbDevice.DeviceEventAction.NONE;

                if (chkAdded.Checked)
                    result |= USB.UsbDevice.DeviceEventAction.ADDED;

                if (chkRemoved.Checked)
                    result |= USB.UsbDevice.DeviceEventAction.REMOVED;

                return result;
            }
            set
            {
                chkAdded.Checked = ((value & USB.UsbDevice.DeviceEventAction.ADDED) == USB.UsbDevice.DeviceEventAction.ADDED);
                chkRemoved.Checked = ((value & USB.UsbDevice.DeviceEventAction.REMOVED) == USB.UsbDevice.DeviceEventAction.REMOVED);
            }
        }

        public CtrlActionBar()
        {
            InitializeComponent();
        }
    }


}
