﻿using System;
using System.Diagnostics;
using System.Windows.Forms;
using static UsbActioner.USB.UsbEvent;

namespace UsbActioner
{
    public partial class FrmApplicationRestart : Form
    {
        public string Application_Name { get; set; }
        public ProcessWindowStyle Window_Style { get; set; } = ProcessWindowStyle.Normal;
        public DeviceEventType DeviceActions { get; set; } = DeviceEventType.NONE;

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
