using System;
using System.Windows.Forms;

namespace UsbActioner.Actions.Forms
{
    public partial class FrmApplicationKill : FrmEventActionBase
    {
        public string Process_Name { get; set; }

        public FrmApplicationKill()
        {
            InitializeComponent();
        }

        private void FrmApplicationRestart_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Process_Name = txtProcessName.Text;
        }

        private void FrmApplicationRestart_Load(object sender, EventArgs e)
        {
            txtProcessName.Text = this.Process_Name;
        }

        public static DialogResult EditAction(ApplicationKillAction action)
        {
            FrmApplicationKill frm = new FrmApplicationKill();
            frm.Process_Name = action.ApplicationProcessName;

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                action.ApplicationProcessName =frm.Process_Name;
            }

            return result;
        }

    }
}
