namespace UsbActioner.Actions.Forms
{
    partial class FrmEventActionBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDone = new System.Windows.Forms.Button();
            this.ctrlActionBar1 = new UsbActioner.CtrlActionBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDone.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDone.Location = new System.Drawing.Point(504, 5);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 28);
            this.btnDone.TabIndex = 12;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            // 
            // ctrlActionBar1
            // 
            this.ctrlActionBar1.Actions = UsbActioner.USB.UsbEvent.DeviceEventType.NONE;
            this.ctrlActionBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlActionBar1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlActionBar1.Location = new System.Drawing.Point(0, 0);
            this.ctrlActionBar1.Name = "ctrlActionBar1";
            this.ctrlActionBar1.Size = new System.Drawing.Size(584, 21);
            this.ctrlActionBar1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDone);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 103);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(584, 38);
            this.panel1.TabIndex = 13;
            // 
            // FrmEventActionBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 141);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ctrlActionBar1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmEventActionBase";
            this.Text = "FrmEventActionBase";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEventActionBase_FormClosing);
            this.Load += new System.EventHandler(this.FrmEventActionBase_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDone;
        private CtrlActionBar ctrlActionBar1;
        private System.Windows.Forms.Panel panel1;
    }
}