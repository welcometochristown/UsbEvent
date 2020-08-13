namespace UsbActioner.Actions.Forms
{
    partial class FrmApplicationRestart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApplicationRestart));
            this.txtProcessName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboStartMode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRunApplication = new System.Windows.Forms.TextBox();
            this.lblRunApplication = new System.Windows.Forms.Label();
            this.chkRunApplication = new System.Windows.Forms.CheckBox();
            this.btnRunApplicationBrowse = new System.Windows.Forms.Button();
            this.pnlRunApplication = new System.Windows.Forms.Panel();
            this.pnlRunApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProcessName
            // 
            this.txtProcessName.Location = new System.Drawing.Point(98, 40);
            this.txtProcessName.Name = "txtProcessName";
            this.txtProcessName.Size = new System.Drawing.Size(351, 22);
            this.txtProcessName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Process Name";
            // 
            // cboStartMode
            // 
            this.cboStartMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStartMode.FormattingEnabled = true;
            this.cboStartMode.Items.AddRange(new object[] {
            "Normal",
            "Hidden",
            "Maximized",
            "Minimized"});
            this.cboStartMode.Location = new System.Drawing.Point(98, 66);
            this.cboStartMode.Name = "cboStartMode";
            this.cboStartMode.Size = new System.Drawing.Size(175, 21);
            this.cboStartMode.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Window Mode";
            // 
            // txtRunApplication
            // 
            this.txtRunApplication.BackColor = System.Drawing.Color.Bisque;
            this.txtRunApplication.Location = new System.Drawing.Point(93, 1);
            this.txtRunApplication.Name = "txtRunApplication";
            this.txtRunApplication.ReadOnly = true;
            this.txtRunApplication.Size = new System.Drawing.Size(351, 22);
            this.txtRunApplication.TabIndex = 0;
            // 
            // lblRunApplication
            // 
            this.lblRunApplication.AutoSize = true;
            this.lblRunApplication.Location = new System.Drawing.Point(3, 5);
            this.lblRunApplication.Name = "lblRunApplication";
            this.lblRunApplication.Size = new System.Drawing.Size(66, 13);
            this.lblRunApplication.TabIndex = 1;
            this.lblRunApplication.Text = "Application";
            // 
            // chkRunApplication
            // 
            this.chkRunApplication.AutoSize = true;
            this.chkRunApplication.Location = new System.Drawing.Point(9, 99);
            this.chkRunApplication.Name = "chkRunApplication";
            this.chkRunApplication.Size = new System.Drawing.Size(239, 17);
            this.chkRunApplication.TabIndex = 14;
            this.chkRunApplication.Text = "Start Application (If Not Already Running)";
            this.chkRunApplication.UseVisualStyleBackColor = true;
            this.chkRunApplication.CheckedChanged += new System.EventHandler(this.chkRunApplication_CheckedChanged);
            // 
            // btnRunApplicationBrowse
            // 
            this.btnRunApplicationBrowse.Location = new System.Drawing.Point(445, 0);
            this.btnRunApplicationBrowse.Name = "btnRunApplicationBrowse";
            this.btnRunApplicationBrowse.Size = new System.Drawing.Size(32, 23);
            this.btnRunApplicationBrowse.TabIndex = 15;
            this.btnRunApplicationBrowse.Text = "...";
            this.btnRunApplicationBrowse.UseVisualStyleBackColor = true;
            this.btnRunApplicationBrowse.Click += new System.EventHandler(this.btnRunApplicationBrowse_Click);
            // 
            // pnlRunApplication
            // 
            this.pnlRunApplication.Controls.Add(this.btnRunApplicationBrowse);
            this.pnlRunApplication.Controls.Add(this.txtRunApplication);
            this.pnlRunApplication.Controls.Add(this.lblRunApplication);
            this.pnlRunApplication.Enabled = false;
            this.pnlRunApplication.Location = new System.Drawing.Point(5, 120);
            this.pnlRunApplication.Name = "pnlRunApplication";
            this.pnlRunApplication.Size = new System.Drawing.Size(491, 25);
            this.pnlRunApplication.TabIndex = 16;
            // 
            // FrmApplicationRestart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 196);
            this.Controls.Add(this.pnlRunApplication);
            this.Controls.Add(this.chkRunApplication);
            this.Controls.Add(this.cboStartMode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProcessName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmApplicationRestart";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Application Restart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmApplicationRestart_FormClosing);
            this.Load += new System.EventHandler(this.FrmApplicationRestart_Load);
            this.Controls.SetChildIndex(this.txtProcessName, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cboStartMode, 0);
            this.Controls.SetChildIndex(this.chkRunApplication, 0);
            this.Controls.SetChildIndex(this.pnlRunApplication, 0);
            this.pnlRunApplication.ResumeLayout(false);
            this.pnlRunApplication.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProcessName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStartMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRunApplication;
        private System.Windows.Forms.Label lblRunApplication;
        private System.Windows.Forms.CheckBox chkRunApplication;
        private System.Windows.Forms.Button btnRunApplicationBrowse;
        private System.Windows.Forms.Panel pnlRunApplication;
    }
}