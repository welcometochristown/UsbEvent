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

namespace UsbActioner
{
    public partial class Form1 : Form
    {
        UsbListener listener;
        List<UsbDevice> usbDevices = new List<UsbDevice>();
        List<EventAction> actions = new List<EventAction>();

        public Form1()
        {
            InitializeComponent();
            listener = new UsbListener();
            listener.NewUsbEvent += Listener_NewUsbEvent;
        }

        private void Listener_NewUsbEvent(UsbEvent e)
        {
            AddDeviceFromEvent(e);
            Invoke(new Action(() => RefreshUSBEventList()));
        }

        private void AddDeviceFromEvent(UsbEvent e)
        {
            var device = usbDevices.SingleOrDefault(n => n.Equals(e.device));

            if (device != null)
                device.last_event = e;
            else
                usbDevices.Add(e.device);
        }

        private void RefreshActions()
        {
            listView2.Items.Clear();
            listView2.Items.AddRange(actions.Select(n => new ListViewItem(n.ToString()) { Tag = n }).ToArray());
        }

        private void RefreshUSBEventList()
        {
            Color getBackColor(string event_name)
            {
                switch (event_name)
                {
                    case "__InstanceDeletionEvent": return Color.LightGray;
                    case "__InstanceCreationEvent": return Color.LightGreen;
                    default: return Color.White;
                };
            }

            listView1.Items.Clear();
            listView1.Items.AddRange(usbDevices.Select(n => new ListViewItem(n.ToString()) { Tag = n, BackColor = getBackColor(n.last_event.event_name)}).ToArray());
            listView1.Refresh();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
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
                btnStart.Enabled = true ;
                btnStop.Enabled = false;
            }
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;

            listener.StopListening();
            toolStripStatusLabel1.Text = "Stopped";

            PowerHelper.ResetSystemDefault();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnStop.PerformClick();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(listView1.SelectedItems.Count == 0)
            {
                e.Cancel = true;
                return;
            }

            UsbDevice device = (listView1.SelectedItems[0] as ListViewItem).Tag as UsbDevice;

            if (device == null)
            {
                e.Cancel = true;
                return;
            }
            
        }

        private void restartApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsbDevice device = (listView1.SelectedItems[0] as ListViewItem).Tag as UsbDevice;

            FrmApplicationRestart frm = new FrmApplicationRestart();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                actions.Add(new ApplicationRestart(frm.Application_Name)
                {
                    WindowStyle = frm.Window_Style,
                    Actions = frm.DeviceActions, 
                    device = device
                });

                RefreshActions();
            }            
        }

    }
}