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
            // FrmApplicationRestart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 141);
            this.Controls.Add(this.cboStartMode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProcessName);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProcessName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStartMode;
        private System.Windows.Forms.Label label2;
    }
}