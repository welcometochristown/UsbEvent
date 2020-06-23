using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsbActioner.Actions.Forms
{
    public partial class FrmBatchFile : FrmEventActionBase
    {
        public string File_Path{ get; set; }

        public FrmBatchFile()
        {
            InitializeComponent();
        }

        private void FrmBatchFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.File_Path = txtFilePath.Text;
        }

        private void FrmBatchFile_Load(object sender, EventArgs e)
        {
           txtFilePath.Text = this.File_Path;
        }

        public static DialogResult EditAction(BatchFileAction action)
        {
            FrmBatchFile frm = new FrmBatchFile();
            frm.File_Path = action.BatchFilePath;
            frm.DeviceActions = action.Actions;

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                action.BatchFilePath = frm.File_Path;
                action.Actions = frm.DeviceActions;
            }

            return result;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.Filter = "batch files (*.bat)|*.bat|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog.FileName;
            }
        }
    }
}
