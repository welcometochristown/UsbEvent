using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UsbActioner.Utility;
using UsbActioner.USB;
using UsbActioner.Actions;
using System.Threading.Tasks;
using static UsbActioner.USB.UsbEvent;
using System.Configuration;

namespace UsbActioner
{
    public partial class Main : Form
    {
        private UsbListener listener = new UsbListener();

        public Main()
        {
            InitializeComponent();

            ActionManager.Init();

            chkKeepWSAlive.Checked = Properties.Settings.Default.KeepAwake;
            RefreshActions();

            listener.NewUsbEvent += Listener_NewUsbEvent;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["ListenOnStart"] == "true")
                btnStart.PerformClick();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnStop.PerformClick();
        }

        private void Listener_NewUsbEvent(UsbEvent e)
        {
            AddDeviceFromEvent(e);
            ActionEvents(e);

            Invoke(new Action(() => RefreshUSBEventList()));
            Invoke(new Action(() => RefreshActions()));
        }

        private async void ActionEvents(UsbEvent e)
        {
            await ActionManagerExecutor.ActionEvents(e);
        }

        private void AddDeviceFromEvent(UsbEvent e)
        {
            DeviceManager.AddDeviceFromEvent(e);
        }

        private void RefreshActions()
        {
            listActions.Items.Clear();
            listActions.Items.AddRange(CreateActionListItems().ToArray());
        }

        private IEnumerable<ListViewItem> CreateActionListItems()
        {
            foreach (var i in ActionManager.Actions)
            {
                var item = new ListViewItem(i.ToString()){  Tag = i };

                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = i.LastRun?.ToString() });

                yield return item;
            }
       }

        private void RefreshUSBEventList()
        {
            Color getBackColor(DeviceEventType event_name)
            {
                switch (event_name)
                {
                    case DeviceEventType.DELETION: return Color.LightGray;
                    case DeviceEventType.CREATION: return Color.LightGreen;
                    default: return Color.White;
                };
            }

            listDevices.Items.Clear();
            listDevices.Items.AddRange(DeviceManager.Devices.Select(n => new ListViewItem(n.ToString()) { Tag = n, BackColor = getBackColor(n.last_event)}).ToArray());
            listDevices.Refresh();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            listDevices.BackColor = Color.LightYellow;
            btnStop.Enabled = true;

            try
            {
                listener.StartListening();
                toolStripStatusLabel1.Text = "Listening...";

                if (chkKeepWSAlive.Checked)
                {
                    PowerHelper.ForceSystemAwake();
                }
            }catch(Exception)
            {
                btnStart.Enabled = true;
                btnStop.Enabled = false;
                listDevices.BackColor = Color.White;
            }
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            listDevices.BackColor = Color.White;

            listener.StopListening();
            toolStripStatusLabel1.Text = "Stopped";

            PowerHelper.ResetSystemDefault();
        }



        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(listDevices.SelectedItems.Count == 0)
            {
                e.Cancel = true;
                return;
            }

            UsbDevice device = (listDevices.SelectedItems[0] as ListViewItem).Tag as UsbDevice;

            if (device == null)
            {
                e.Cancel = true;
                return;
            }
        }

        private void restartApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var device = (listDevices.SelectedItems[0] as ListViewItem).Tag as UsbDevice;
            var action = new ApplicationRestartAction() { device = device };

            if (FrmApplicationRestart.EditAction(action) == DialogResult.OK)
            {
                ActionManager.Add(action);
                RefreshActions();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActionManager.LoadFromFile();

            RefreshActions();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listActions.SelectedItems.Count > 0)
            {
                var ae = listActions.SelectedItems[0].Tag as EventAction;
                ActionManager.Remove(ae);
                RefreshActions();
            }
        }

        private void chkKeepWSAlive_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.KeepAwake = chkKeepWSAlive.Checked;
            Properties.Settings.Default.Save();
        }

        private void changeScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var device = (listDevices.SelectedItems[0] as ListViewItem).Tag as UsbDevice;
            var action = new DisplayModeAction { device = device };

            if (FrmDisplayMode.EditAction(action) == DialogResult.OK)
            {
                ActionManager.Add(action);
                RefreshActions();
            }
        }



        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listActions.SelectedItems.Count > 0)
            {
                var ae = listActions.SelectedItems[0].Tag as EventAction;

                if (ae is ApplicationRestartAction)
                    FrmApplicationRestart.EditAction(ae as ApplicationRestartAction);

                if (ae is DisplayModeAction)
                    FrmDisplayMode.EditAction(ae as DisplayModeAction);

                RefreshActions();
            }
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void restartApplicationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var device = ((listActions.SelectedItems[0] as ListViewItem).Tag as EventAction).device;
            var action = new ApplicationRestartAction() { device = device };

            if (FrmApplicationRestart.EditAction(action) == DialogResult.OK)
            {
                ActionManager.Add(action);
                RefreshActions();
            }
        }

        private void setDisplayModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var device = ((listActions.SelectedItems[0] as ListViewItem).Tag as EventAction).device;
            var action = new DisplayModeAction { device = device };

            if (FrmDisplayMode.EditAction(action) == DialogResult.OK)
            {
                ActionManager.Add(action);
                RefreshActions();
            }
        }
    }
}
