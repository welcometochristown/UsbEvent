using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static UsbActioner.USB.UsbEvent;

namespace UsbActioner.Actions.Forms
{
    public partial class FrmEventActionBase : Form
    {
        public DeviceEventType DeviceActions { get; set; } = DeviceEventType.NONE;

        public FrmEventActionBase()
        {
            InitializeComponent();
        }

        private void FrmEventActionBase_Load(object sender, EventArgs e)
        {
             ctrlActionBar1.Actions = this.DeviceActions;
        }

        private void FrmEventActionBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DeviceActions = ctrlActionBar1.Actions;
        }
    }
}
