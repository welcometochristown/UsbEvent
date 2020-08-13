namespace UsbActioner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.listDevices = new System.Windows.Forms.ListView();
            this.cxtDevices = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restartApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.listActions = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cxtActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.forceExecuteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addAnotherEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartApplicationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.setDisplayModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.chkKeepWSAlive = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.reloadDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openApplicationFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cxtDevices.SuspendLayout();
            this.cxtActions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(3, 3);
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
            this.btnStop.Location = new System.Drawing.Point(84, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // listDevices
            // 
            this.listDevices.ContextMenuStrip = this.cxtDevices;
            this.listDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDevices.HideSelection = false;
            this.listDevices.Location = new System.Drawing.Point(0, 13);
            this.listDevices.MultiSelect = false;
            this.listDevices.Name = "listDevices";
            this.listDevices.Size = new System.Drawing.Size(1091, 233);
            this.listDevices.TabIndex = 1;
            this.listDevices.UseCompatibleStateImageBehavior = false;
            this.listDevices.View = System.Windows.Forms.View.List;
            // 
            // cxtDevices
            // 
            this.cxtDevices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartApplicationToolStripMenuItem,
            this.changeScreenToolStripMenuItem,
            this.batchFileToolStripMenuItem});
            this.cxtDevices.Name = "contextMenuStrip1";
            this.cxtDevices.Size = new System.Drawing.Size(175, 70);
            this.cxtDevices.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // restartApplicationToolStripMenuItem
            // 
            this.restartApplicationToolStripMenuItem.Image = global::UsbActioner.Properties.Resources.page_refresh;
            this.restartApplicationToolStripMenuItem.Name = "restartApplicationToolStripMenuItem";
            this.restartApplicationToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.restartApplicationToolStripMenuItem.Text = "Restart Application";
            this.restartApplicationToolStripMenuItem.Click += new System.EventHandler(this.restartApplicationToolStripMenuItem_Click);
            // 
            // changeScreenToolStripMenuItem
            // 
            this.changeScreenToolStripMenuItem.Image = global::UsbActioner.Properties.Resources.monitor_go;
            this.changeScreenToolStripMenuItem.Name = "changeScreenToolStripMenuItem";
            this.changeScreenToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.changeScreenToolStripMenuItem.Text = "Set Display Mode";
            this.changeScreenToolStripMenuItem.Click += new System.EventHandler(this.changeScreenToolStripMenuItem_Click);
            // 
            // batchFileToolStripMenuItem
            // 
            this.batchFileToolStripMenuItem.Image = global::UsbActioner.Properties.Resources.cog;
            this.batchFileToolStripMenuItem.Name = "batchFileToolStripMenuItem";
            this.batchFileToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.batchFileToolStripMenuItem.Text = "Batch File";
            this.batchFileToolStripMenuItem.Click += new System.EventHandler(this.batchFileToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 569);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1101, 22);
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
            this.listActions.ContextMenuStrip = this.cxtActions;
            this.listActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listActions.HideSelection = false;
            this.listActions.Location = new System.Drawing.Point(0, 13);
            this.listActions.Name = "listActions";
            this.listActions.Size = new System.Drawing.Size(1091, 231);
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
            // cxtActions
            // 
            this.cxtActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forceExecuteToolStripMenuItem,
            this.toolStripSeparator3,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.refreshToolStripMenuItem,
            this.toolStripSeparator2,
            this.addAnotherEventToolStripMenuItem});
            this.cxtActions.Name = "contextMenuStrip2";
            this.cxtActions.Size = new System.Drawing.Size(131, 132);
            // 
            // forceExecuteToolStripMenuItem
            // 
            this.forceExecuteToolStripMenuItem.Image = global::UsbActioner.Properties.Resources.lightning;
            this.forceExecuteToolStripMenuItem.Name = "forceExecuteToolStripMenuItem";
            this.forceExecuteToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.forceExecuteToolStripMenuItem.Text = "Execute";
            this.forceExecuteToolStripMenuItem.Click += new System.EventHandler(this.forceExecuteToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(127, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::UsbActioner.Properties.Resources.application_edit;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::UsbActioner.Properties.Resources.application_delete;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(127, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::UsbActioner.Properties.Resources.arrow_refresh_small;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(127, 6);
            // 
            // addAnotherEventToolStripMenuItem
            // 
            this.addAnotherEventToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartApplicationToolStripMenuItem1,
            this.setDisplayModeToolStripMenuItem,
            this.batchFileToolStripMenuItem1});
            this.addAnotherEventToolStripMenuItem.Image = global::UsbActioner.Properties.Resources.application_add;
            this.addAnotherEventToolStripMenuItem.Name = "addAnotherEventToolStripMenuItem";
            this.addAnotherEventToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.addAnotherEventToolStripMenuItem.Text = "New Event";
            // 
            // restartApplicationToolStripMenuItem1
            // 
            this.restartApplicationToolStripMenuItem1.Image = global::UsbActioner.Properties.Resources.page_refresh;
            this.restartApplicationToolStripMenuItem1.Name = "restartApplicationToolStripMenuItem1";
            this.restartApplicationToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.restartApplicationToolStripMenuItem1.Text = "Restart Application";
            this.restartApplicationToolStripMenuItem1.Click += new System.EventHandler(this.restartApplicationToolStripMenuItem1_Click);
            // 
            // setDisplayModeToolStripMenuItem
            // 
            this.setDisplayModeToolStripMenuItem.Image = global::UsbActioner.Properties.Resources.monitor_go;
            this.setDisplayModeToolStripMenuItem.Name = "setDisplayModeToolStripMenuItem";
            this.setDisplayModeToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.setDisplayModeToolStripMenuItem.Text = "Set Display Mode";
            this.setDisplayModeToolStripMenuItem.Click += new System.EventHandler(this.setDisplayModeToolStripMenuItem_Click);
            // 
            // batchFileToolStripMenuItem1
            // 
            this.batchFileToolStripMenuItem1.Image = global::UsbActioner.Properties.Resources.cog;
            this.batchFileToolStripMenuItem1.Name = "batchFileToolStripMenuItem1";
            this.batchFileToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.batchFileToolStripMenuItem1.Text = "Batch File";
            this.batchFileToolStripMenuItem1.Click += new System.EventHandler(this.batchFileToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
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
            this.chkKeepWSAlive.Location = new System.Drawing.Point(933, 7);
            this.chkKeepWSAlive.Name = "chkKeepWSAlive";
            this.chkKeepWSAlive.Size = new System.Drawing.Size(155, 17);
            this.chkKeepWSAlive.TabIndex = 4;
            this.chkKeepWSAlive.Text = "Keep Workstation Awake";
            this.chkKeepWSAlive.UseVisualStyleBackColor = true;
            this.chkKeepWSAlive.CheckedChanged += new System.EventHandler(this.chkKeepWSAlive_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1101, 545);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listDevices);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1091, 246);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnStart);
            this.panel4.Controls.Add(this.btnStop);
            this.panel4.Controls.Add(this.chkKeepWSAlive);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(5, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1091, 45);
            this.panel4.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listActions);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(5, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1091, 244);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Actions";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.helpToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1101, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem,
            this.toolStripSeparator6,
            this.reloadDevicesToolStripMenuItem,
            this.reloadActionsToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configToolStripMenuItem.Text = "Open Config";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(177, 6);
            // 
            // reloadDevicesToolStripMenuItem
            // 
            this.reloadDevicesToolStripMenuItem.Name = "reloadDevicesToolStripMenuItem";
            this.reloadDevicesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reloadDevicesToolStripMenuItem.Text = "Reload Devices";
            this.reloadDevicesToolStripMenuItem.Click += new System.EventHandler(this.reloadDevicesToolStripMenuItem_Click);
            // 
            // reloadActionsToolStripMenuItem
            // 
            this.reloadActionsToolStripMenuItem.Name = "reloadActionsToolStripMenuItem";
            this.reloadActionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reloadActionsToolStripMenuItem.Text = "Reload Actions";
            this.reloadActionsToolStripMenuItem.Click += new System.EventHandler(this.reloadActionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearDevicesToolStripMenuItem});
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // clearDevicesToolStripMenuItem
            // 
            this.clearDevicesToolStripMenuItem.Name = "clearDevicesToolStripMenuItem";
            this.clearDevicesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearDevicesToolStripMenuItem.Text = "Clear Devices";
            this.clearDevicesToolStripMenuItem.Click += new System.EventHandler(this.clearDevicesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem2
            // 
            this.helpToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem2.Name = "helpToolStripMenuItem2";
            this.helpToolStripMenuItem2.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem2.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Image = global::UsbActioner.Properties.Resources.usb;
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openApplicationFolderToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.helpToolStripMenuItem.Text = "File";
            // 
            // openApplicationFolderToolStripMenuItem
            // 
            this.openApplicationFolderToolStripMenuItem.Name = "openApplicationFolderToolStripMenuItem";
            this.openApplicationFolderToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.openApplicationFolderToolStripMenuItem.Text = "Open Application Folder";
            this.openApplicationFolderToolStripMenuItem.Click += new System.EventHandler(this.openApplicationFolderToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(200, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem1.Text = "About";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 591);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "UsbEvent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.cxtDevices.ResumeLayout(false);
            this.cxtActions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ContextMenuStrip cxtDevices;
        private System.Windows.Forms.ToolStripMenuItem restartApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeScreenToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ContextMenuStrip cxtActions;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAnotherEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartApplicationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem setDisplayModeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem forceExecuteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openApplicationFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem batchFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batchFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearDevicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem reloadDevicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadActionsToolStripMenuItem;
    }
}