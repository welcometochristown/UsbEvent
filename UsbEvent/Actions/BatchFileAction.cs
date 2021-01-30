using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsbActioner.Actions.Forms;
using UsbActioner.Exceptions;

namespace UsbActioner.Actions
{
    public class BatchFileAction : EventAction
    {
        public override string Name => nameof(BatchFileAction);

        public string BatchFilePath { get; set; }

        public override async Task Execute()
        {
            try
            {
                await Task.Run(() =>
                {
                    Process.Start(BatchFilePath);
                });
            }
            catch (Exception ex)
            {
                throw new ActionExecutionFailedException($"Failed to execute {BatchFilePath}", ex);
            }
        }

        public override DialogResult EditAction()
        {
            return FrmBatchFile.EditAction(this);
        }


        public override string ToString()
        {
            return $"{base.ToString()} | {BatchFilePath})";
        }
    }
}
