namespace UsbActioner.Actions.Forms
{
    partial class FrmDisplayMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDisplayMode));
            this.rdoInternal = new System.Windows.Forms.RadioButton();
            this.rdoExternal = new System.Windows.Forms.RadioButton();
            this.rdoExtend = new System.Windows.Forms.RadioButton();
            this.rdoDuplicate = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rdoInternal
            // 
            this.rdoInternal.AutoSize = true;
            this.rdoInternal.Checked = true;
            this.rdoInternal.Location = new System.Drawing.Point(8, 42);
            this.rdoInternal.Name = "rdoInternal";
            this.rdoInternal.Size = new System.Drawing.Size(65, 17);
            this.rdoInternal.TabIndex = 0;
            this.rdoInternal.TabStop = true;
            this.rdoInternal.Text = "Internal";
            this.rdoInternal.UseVisualStyleBackColor = true;
            // 
            // rdoExternal
            // 
            this.rdoExternal.AutoSize = true;
            this.rdoExternal.Location = new System.Drawing.Point(97, 42);
            this.rdoExternal.Name = "rdoExternal";
            this.rdoExternal.Size = new System.Drawing.Size(66, 17);
            this.rdoExternal.TabIndex = 0;
            this.rdoExternal.Text = "External";
            this.rdoExternal.UseVisualStyleBackColor = true;
            // 
            // rdoExtend
            // 
            this.rdoExtend.AutoSize = true;
            this.rdoExtend.Location = new System.Drawing.Point(187, 42);
            this.rdoExtend.Name = "rdoExtend";
            this.rdoExtend.Size = new System.Drawing.Size(60, 17);
            this.rdoExtend.TabIndex = 0;
            this.rdoExtend.Text = "Extend";
            this.rdoExtend.UseVisualStyleBackColor = true;
            // 
            // rdoDuplicate
            // 
            this.rdoDuplicate.AutoSize = true;
            this.rdoDuplicate.Location = new System.Drawing.Point(269, 42);
            this.rdoDuplicate.Name = "rdoDuplicate";
            this.rdoDuplicate.Size = new System.Drawing.Size(74, 17);
            this.rdoDuplicate.TabIndex = 0;
            this.rdoDuplicate.Text = "Duplicate";
            this.rdoDuplicate.UseVisualStyleBackColor = true;
            // 
            // FrmDisplayMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 116);
            this.Controls.Add(this.rdoDuplicate);
            this.Controls.Add(this.rdoExtend);
            this.Controls.Add(this.rdoExternal);
            this.Controls.Add(this.rdoInternal);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDisplayMode";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmDisplayMode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDisplayMode_FormClosing);
            this.Load += new System.EventHandler(this.FrmDisplayMode_Load);
            this.Controls.SetChildIndex(this.rdoInternal, 0);
            this.Controls.SetChildIndex(this.rdoExternal, 0);
            this.Controls.SetChildIndex(this.rdoExtend, 0);
            this.Controls.SetChildIndex(this.rdoDuplicate, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoInternal;
        private System.Windows.Forms.RadioButton rdoExternal;
        private System.Windows.Forms.RadioButton rdoExtend;
        private System.Windows.Forms.RadioButton rdoDuplicate;
    }
}