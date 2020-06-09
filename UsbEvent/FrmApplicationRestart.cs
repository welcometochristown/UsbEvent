using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace UsbActioner
{
    public partial class FrmApplicationRestart : Form
    {
        public string Application_Name { get; set; }
        public ProcessWindowStyle Window_Style { get; set; } = ProcessWindowStyle.Normal;
        public USB.UsbDevice.DeviceEventAction DeviceActions { get; set; } = USB.UsbDevice.DeviceEventAction.NONE;

        public FrmApplicationRestart()
        {
            InitializeComponent();
        }

        private void FrmApplicationRestart_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Application_Name = txtProcessName.Text;
            this.Window_Style = (ProcessWindowStyle)Enum.Parse(typeof(ProcessWindowStyle), cboStartMode.Text);
            this.DeviceActions = ctrlActionBar1.Actions;
        }

        private void FrmApplicationRestart_Load(object sender, EventArgs e)
        {
            txtProcessName.Text = this.Application_Name;
            cboStartMode.Text = this.Window_Style.ToString();
            ctrlActionBar1.Actions = this.DeviceActions;
        }
    }
}
