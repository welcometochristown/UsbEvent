﻿namespace UsbActioner
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.listDevices = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restartApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.listActions = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAnotherEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.chkKeepWSAlive = new System.Windows.Forms.CheckBox();
            this.restartApplicationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.setDisplayModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(93, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // listDevices
            // 
            this.listDevices.ContextMenuStrip = this.contextMenuStrip1;
            this.listDevices.HideSelection = false;
            this.listDevices.Location = new System.Drawing.Point(12, 66);
            this.listDevices.MultiSelect = false;
            this.listDevices.Name = "listDevices";
            this.listDevices.Size = new System.Drawing.Size(776, 180);
            this.listDevices.TabIndex = 1;
            this.listDevices.UseCompatibleStateImageBehavior = false;
            this.listDevices.View = System.Windows.Forms.View.List;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartApplicationToolStripMenuItem,
            this.changeScreenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // restartApplicationToolStripMenuItem
            // 
            this.restartApplicationToolStripMenuItem.Name = "restartApplicationToolStripMenuItem";
            this.restartApplicationToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.restartApplicationToolStripMenuItem.Text = "Restart Application";
            this.restartApplicationToolStripMenuItem.Click += new System.EventHandler(this.restartApplicationToolStripMenuItem_Click);
            // 
            // changeScreenToolStripMenuItem
            // 
            this.changeScreenToolStripMenuItem.Name = "changeScreenToolStripMenuItem";
            this.changeScreenToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.changeScreenToolStripMenuItem.Text = "Set Display Mode";
            this.changeScreenToolStripMenuItem.Click += new System.EventHandler(this.changeScreenToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 456);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(801, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Ready.";
            // 
            // listActions
            // 
            this.listActions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listActions.ContextMenuStrip = this.contextMenuStrip2;
            this.listActions.HideSelection = false;
            this.listActions.Location = new System.Drawing.Point(12, 252);
            this.listActions.Name = "listActions";
            this.listActions.Size = new System.Drawing.Size(776, 194);
            this.listActions.TabIndex = 1;
            this.listActions.UseCompatibleStateImageBehavior = false;
            this.listActions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Action";
            this.columnHeader1.Width = 578;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Last Run";
            this.columnHeader2.Width = 192;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.addAnotherEventToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(181, 114);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // addAnotherEventToolStripMenuItem
            // 
            this.addAnotherEventToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartApplicationToolStripMenuItem1,
            this.setDisplayModeToolStripMenuItem});
            this.addAnotherEventToolStripMenuItem.Name = "addAnotherEventToolStripMenuItem";
            this.addAnotherEventToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addAnotherEventToolStripMenuItem.Text = "Add Another Event";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Discovered Devices";
            // 
            // chkKeepWSAlive
            // 
            this.chkKeepWSAlive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkKeepWSAlive.AutoSize = true;
            this.chkKeepWSAlive.Checked = true;
            this.chkKeepWSAlive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKeepWSAlive.Location = new System.Drawing.Point(634, 12);
            this.chkKeepWSAlive.Name = "chkKeepWSAlive";
            this.chkKeepWSAlive.Size = new System.Drawing.Size(155, 17);
            this.chkKeepWSAlive.TabIndex = 4;
            this.chkKeepWSAlive.Text = "Keep Workstation Awake";
            this.chkKeepWSAlive.UseVisualStyleBackColor = true;
            this.chkKeepWSAlive.CheckedChanged += new System.EventHandler(this.chkKeepWSAlive_CheckedChanged);
            // 
            // restartApplicationToolStripMenuItem1
            // 
            this.restartApplicationToolStripMenuItem1.Name = "restartApplicationToolStripMenuItem1";
            this.restartApplicationToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.restartApplicationToolStripMenuItem1.Text = "Restart Application";
            this.restartApplicationToolStripMenuItem1.Click += new System.EventHandler(this.restartApplicationToolStripMenuItem1_Click);
            // 
            // setDisplayModeToolStripMenuItem
            // 
            this.setDisplayModeToolStripMenuItem.Name = "setDisplayModeToolStripMenuItem";
            this.setDisplayModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setDisplayModeToolStripMenuItem.Text = "Set Display Mode";
            this.setDisplayModeToolStripMenuItem.Click += new System.EventHandler(this.setDisplayModeToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 478);
            this.Controls.Add(this.chkKeepWSAlive);
            this.Controls.Add(this.listDevices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listActions);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Main";
            this.Text = "UsbEvent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListView listDevices;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ListView listActions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkKeepWSAlive;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem restartApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeScreenToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAnotherEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartApplicationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem setDisplayModeToolStripMenuItem;
    }
}