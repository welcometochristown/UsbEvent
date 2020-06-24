namespace UsbActioner.Actions.Forms
{
    partial class CtrlActionBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkAdded = new System.Windows.Forms.CheckBox();
            this.chkRemoved = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkAdded
            // 
            this.chkAdded.AutoSize = true;
            this.chkAdded.Location = new System.Drawing.Point(3, 3);
            this.chkAdded.Name = "chkAdded";
            this.chkAdded.Size = new System.Drawing.Size(60, 17);
            this.chkAdded.TabIndex = 0;
            this.chkAdded.Text = "Added";
            this.chkAdded.UseVisualStyleBackColor = true;
            // 
            // chkRemoved
            // 
            this.chkRemoved.AutoSize = true;
            this.chkRemoved.Location = new System.Drawing.Point(91, 3);
            this.chkRemoved.Name = "chkRemoved";
            this.chkRemoved.Size = new System.Drawing.Size(73, 17);
            this.chkRemoved.TabIndex = 0;
            this.chkRemoved.Text = "Removed";
            this.chkRemoved.UseVisualStyleBackColor = true;
            // 
            // CtrlActionBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkRemoved);
            this.Controls.Add(this.chkAdded);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CtrlActionBar";
            this.Size = new System.Drawing.Size(166, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAdded;
        private System.Windows.Forms.CheckBox chkRemoved;
    }
}
