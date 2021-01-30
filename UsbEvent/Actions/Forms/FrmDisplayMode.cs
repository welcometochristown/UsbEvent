using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsbActioner.Actions;
using static UsbActioner.Actions.DisplayModeAction;
using static UsbActioner.USB.UsbEvent;

namespace UsbActioner.Actions.Forms
{
    public partial class FrmDisplayMode : FrmEventActionBase
    {
        private class DisplayComboItem 
        { 
            public string Method { get; set; }
            public string Description { get; set; }
            public override string ToString()
            {
                return Description;
            }
        }

        public DisplayModeOptionEnum DisplayModeOption { get; set; } = DisplayModeOptionEnum.Internal;

        public string DisplayMethod { get; set; }

        public RadioButton [] buttons;

        public FrmDisplayMode()
        {
            InitializeComponent();
            buttons = new[] { rdoInternal, rdoExternal, rdoExtend, rdoDuplicate };
            comboBox1.Items.AddRange(new[]
            {
                new DisplayComboItem() {Method = "DC", Description = "Display Config (Recommended)"},
                new DisplayComboItem() {Method = "DS", Description = "Display Switch"}
            });
        }

        private void FrmDisplayMode_Load(object sender, EventArgs e)
        {
            foreach (var rb in buttons)
            {
                rb.Checked = (rb.Text == DisplayModeOption.ToString());
            }

            comboBox1.SelectedItem = comboBox1.Items.Cast<DisplayComboItem>().SingleOrDefault(n => n.Method == DisplayMethod);

            if (comboBox1.SelectedItem == null)
                comboBox1.SelectedIndex = 0;
        }

        private void FrmDisplayMode_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach(var rb in buttons)
            {
                if(rb.Checked)
                {
                    this.DisplayModeOption = (DisplayModeOptionEnum)Enum.Parse(typeof(DisplayModeOptionEnum), rb.Text);
                    break;
                }
            }

            DisplayMethod = (comboBox1.SelectedItem as DisplayComboItem).Method;
        }

        public static DialogResult EditAction(DisplayModeAction action)
        {
            FrmDisplayMode frm = new FrmDisplayMode();
            frm.DisplayModeOption = action.DisplayMode;
            frm.DeviceActions = action.Actions;
            frm.DisplayMethod = action.DisplayMethod;

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                action.DisplayMode = frm.DisplayModeOption;
                action.Actions = frm.DeviceActions;
                action.DisplayMethod = frm.DisplayMethod;
            }

            return result;
        }
    }
}

