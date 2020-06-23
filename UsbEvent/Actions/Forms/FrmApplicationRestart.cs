using System;
using System.Diagnostics;
using System.Windows.Forms;
using UsbActioner.Actions;
using static UsbActioner.USB.UsbEvent;

namespace UsbActioner.Actions.Forms
{
    public partial class FrmApplicationRestart : FrmEventActionBase
    {
        public string Application_Name { get; set; }
        public ProcessWindowStyle Window_Style { get; set; } = ProcessWindowStyle.Normal;

        public FrmApplicationRestart()
        {
            InitializeComponent();
        }

        private void FrmApplicationRestart_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Application_Name = txtProcessName.Text;
            this.Window_Style = (ProcessWindowStyle)Enum.Parse(typeof(ProcessWindowStyle), cboStartMode.Text);
        }

        private void FrmApplicationRestart_Load(object sender, EventArgs e)
        {
            txtProcessName.Text = this.Application_Name;
            cboStartMode.Text = this.Window_Style.ToString();
        }

        public static DialogResult EditAction(ApplicationRestartAction action)
        {
            FrmApplicationRestart frm = new FrmApplicationRestart();
            frm.Application_Name = action.ApplicationProcessName;
            frm.Window_Style = action.WindowStyle;
            frm.DeviceActions = action.Actions;

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                action.ApplicationProcessName =frm.Application_Name;
                action.WindowStyle = frm.Window_Style;
                action.Actions = frm.DeviceActions;
            }

            return result;
        }
    }
}
