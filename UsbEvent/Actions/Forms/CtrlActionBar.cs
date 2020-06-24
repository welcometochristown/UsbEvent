using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static UsbActioner.USB.UsbEvent;

namespace UsbActioner.Actions.Forms
{
    public partial class CtrlActionBar : UserControl
    {
        public CtrlActionBar()
        {
            InitializeComponent();
        }

        public DeviceEventType Actions
        {
            get
            {
                DeviceEventType result = DeviceEventType.NONE;

                if (chkAdded.Checked)
                    result |= DeviceEventType.CREATION;

                if (chkRemoved.Checked)
                    result |= DeviceEventType.DELETION;

                return result;
            }
            set
            {
                 chkAdded.Checked = ((value & DeviceEventType.CREATION) == DeviceEventType.CREATION);
                 chkRemoved.Checked = ((value & DeviceEventType.DELETION) == DeviceEventType.DELETION);
            }
        }


    }


}
