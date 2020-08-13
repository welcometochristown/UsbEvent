using System;
using System.Diagnostics;
using System.Windows.Forms;
using UsbActioner.Actions;
using static UsbActioner.USB.UsbEvent;

namespace UsbActioner.Actions.Forms
{
    public partial class FrmApplicationRestart : FrmEventActionBase
    {
        public string Process_Name { get; set; }
        public ProcessWindowStyle Window_Style { get; set; } = ProcessWindowStyle.Normal;
        public string Application_Path { get; set; }

        public FrmApplicationRestart()
        {
            InitializeComponent();
        }

        private void FrmApplicationRestart_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.Process_Name = txtProcessName.Text;
            this.Application_Path = !chkRunApplication.Checked || string.IsNullOrWhiteSpace(txtRunApplication.Text) ? null : txtRunApplication.Text;
            this.Window_Style = (ProcessWindowStyle)Enum.Parse(typeof(ProcessWindowStyle), cboStartMode.Text);
        }

        private void FrmApplicationRestart_Load(object sender, EventArgs e)
        {
            txtProcessName.Text = this.Process_Name;
            txtRunApplication.Text = this.Application_Path;
            cboStartMode.Text = this.Window_Style.ToString();
            chkRunApplication.Checked = this.Application_Path != null;
        }

        public static DialogResult EditAction(ApplicationRestartAction action)
        {
            FrmApplicationRestart frm = new FrmApplicationRestart();
            frm.Process_Name = action.ApplicationProcessName;
            frm.Window_Style = action.WindowStyle;
            frm.DeviceActions = action.Actions;
            frm.Application_Path = action.ApplicationPath;

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                action.ApplicationProcessName =frm.Process_Name;
                action.WindowStyle = frm.Window_Style;
                action.Actions = frm.DeviceActions;
                action.ApplicationPath = frm.Application_Path;
            }

            return result;
        }

        private void btnRunApplicationBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Executables (.exe) | *.exe";

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                txtRunApplication.Text = dlg.FileName;
            }
        }

        private void chkRunApplication_CheckedChanged(object sender, EventArgs e)
        {
            pnlRunApplication.Enabled = chkRunApplication.Checked;
        }
    }
}
