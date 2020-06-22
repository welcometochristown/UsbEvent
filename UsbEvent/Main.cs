﻿using System;
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
using UsbActioner.Extensions;

namespace UsbActioner
{
    public partial class Main : Form
    {
        private UsbListener listener = new UsbListener();

        public Main()
        {
            InitializeComponent();
            InitialiseApplication();
        }

        private void InitialiseApplication()
        {
            ActionManager.LoadActionsFromFile();
            DeviceManager.LoadDevicesFromFile();

            RefreshActions();
            RefreshUsbDevices();

            listener.NewUsbEvent += Listener_NewUsbEvent;
            chkKeepWSAlive.Checked = Properties.Settings.Default.KeepAwake;

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

            Invoke(new Action(() => RefreshUsbDevices()));
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
            listActions.Items.AddRange(CreateActionListItems(ActionManager.Actions).ToArray());
        }

        private IEnumerable<ListViewItem> CreateActionListItems(IEnumerable<EventAction> actions)
        {
            foreach (var i in actions)
            {
                var item = new ListViewItem(i.ToString()){  Tag = i };

                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = i.LastRun?.ToString() });

                yield return item;
            }
        }

        private void RefreshUsbDevices()
        {
            listDevices.Sync(CreateDeviceListItems(DeviceManager.Devices));
            UpdateDeviceBackColors();
        }

        private IEnumerable<ListViewItem> CreateDeviceListItems(IEnumerable<UsbDevice> actions)
        {
            foreach (var i in actions)
            {
                yield return new ListViewItem(i.ToString()) { Tag = i, Name = i.device_guid };
            }
        }

        private void UpdateDeviceBackColors()
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

            foreach (var i in listDevices.Items.Cast<ListViewItem>())
            {
                var device = i.Tag as UsbDevice;

                if (device == null)
                    continue;

                i.BackColor = getBackColor(device.last_event);
            }
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
            if (listDevices.SelectedItems.Count == 0)
                return;

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
            ActionManager.LoadActionsFromFile();

            RefreshActions();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listDevices.SelectedItems.Count == 0)
                return;

            var ae = listActions.SelectedItems[0].Tag as EventAction;
            ActionManager.Remove(ae);
            RefreshActions();
            
        }

        private void chkKeepWSAlive_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.KeepAwake = chkKeepWSAlive.Checked;
            Properties.Settings.Default.Save();
        }

        private void changeScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listDevices.SelectedItems.Count == 0)
                return;

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
            if (listDevices.SelectedItems.Count == 0)
                return;

            var ae = listActions.SelectedItems[0].Tag as EventAction;

            if (ae is ApplicationRestartAction)
            {
                FrmApplicationRestart.EditAction(ae as ApplicationRestartAction);
                ActionManager.SaveActionsToFile();
                RefreshActions();
            }

            if (ae is DisplayModeAction)
            {
                FrmDisplayMode.EditAction(ae as DisplayModeAction);
                ActionManager.SaveActionsToFile();
                RefreshActions();
            }

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void restartApplicationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listDevices.SelectedItems.Count == 0)
                return;

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
            if (listDevices.SelectedItems.Count == 0)
                return;

            var device = ((listActions.SelectedItems[0] as ListViewItem).Tag as EventAction).device;
            var action = new DisplayModeAction { device = device };

            if (FrmDisplayMode.EditAction(action) == DialogResult.OK)
            {
                ActionManager.Add(action);
                RefreshActions();
            }
        }

        private void forceExecuteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listDevices.SelectedItems.Count == 0)
                return;

            var action = ((listActions.SelectedItems[0] as ListViewItem).Tag as EventAction);

            action?.Execute();
        }
    }
}
