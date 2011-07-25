﻿namespace rtmpGUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.channel_name = new System.Windows.Forms.ColumnHeader();
            this.swf_url = new System.Windows.Forms.ColumnHeader();
            this.rtmp_url = new System.Windows.Forms.ColumnHeader();
            this.http_url = new System.Windows.Forms.ColumnHeader();
            this.additional_info = new System.Windows.Forms.ColumnHeader();
            this.channel_language = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addChannel = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteChannel = new System.Windows.Forms.ToolStripMenuItem();
            this.editChannel = new System.Windows.Forms.ToolStripMenuItem();
            this.recordChannel = new System.Windows.Forms.ToolStripMenuItem();
            this.saveChannels = new System.Windows.Forms.ToolStripMenuItem();
            this.submitChannel = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sysLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsPBar = new System.Windows.Forms.ToolStripProgressBar();
            this.wbApp = new System.Windows.Forms.WebBrowser();
            this.txtCommands = new System.Windows.Forms.TextBox();
            this.locateVLC = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteXmlLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalXMLLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.webpageRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.showCommands = new System.Windows.Forms.ToolStripMenuItem();
            this.checkUpdatesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.howToMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(574, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locateVLC,
            this.refreshMenu,
            this.showCommands,
            this.checkUpdatesMenu,
            this.toolStripSeparator1,
            this.exitMenu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(205, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToMenu,
            this.aboutMenu});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.channel_name,
            this.swf_url,
            this.rtmp_url,
            this.http_url,
            this.additional_info,
            this.channel_language});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(0, 27);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(191, 296);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // channel_name
            // 
            this.channel_name.Text = "Channel Name";
            this.channel_name.Width = 102;
            // 
            // swf_url
            // 
            this.swf_url.DisplayIndex = 2;
            this.swf_url.Text = "SWF URL";
            this.swf_url.Width = 80;
            // 
            // rtmp_url
            // 
            this.rtmp_url.DisplayIndex = 3;
            this.rtmp_url.Text = "Link";
            this.rtmp_url.Width = 80;
            // 
            // http_url
            // 
            this.http_url.DisplayIndex = 4;
            this.http_url.Text = "Page URL";
            // 
            // additional_info
            // 
            this.additional_info.DisplayIndex = 5;
            this.additional_info.Text = "Playpath";
            // 
            // channel_language
            // 
            this.channel_language.DisplayIndex = 1;
            this.channel_language.Text = "Language";
            this.channel_language.Width = 77;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addChannel,
            this.deleteChannel,
            this.editChannel,
            this.recordChannel,
            this.saveChannels,
            this.submitChannel});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 136);
            // 
            // addChannel
            // 
            this.addChannel.Name = "addChannel";
            this.addChannel.Size = new System.Drawing.Size(159, 22);
            this.addChannel.Text = "Add Channel";
            this.addChannel.Click += new System.EventHandler(this.addChannel_Click);
            // 
            // deleteChannel
            // 
            this.deleteChannel.Name = "deleteChannel";
            this.deleteChannel.Size = new System.Drawing.Size(159, 22);
            this.deleteChannel.Text = "Delete Channel";
            this.deleteChannel.Click += new System.EventHandler(this.deleteChannel_Click);
            // 
            // editChannel
            // 
            this.editChannel.Name = "editChannel";
            this.editChannel.Size = new System.Drawing.Size(159, 22);
            this.editChannel.Text = "Edit Channel";
            this.editChannel.Click += new System.EventHandler(this.editChannel_Click);
            // 
            // recordChannel
            // 
            this.recordChannel.Name = "recordChannel";
            this.recordChannel.Size = new System.Drawing.Size(159, 22);
            this.recordChannel.Text = "Record Channel";
            this.recordChannel.Click += new System.EventHandler(this.recordChannel_Click);
            // 
            // saveChannels
            // 
            this.saveChannels.Name = "saveChannels";
            this.saveChannels.Size = new System.Drawing.Size(159, 22);
            this.saveChannels.Text = "Save Channels";
            this.saveChannels.Click += new System.EventHandler(this.saveChannels_Click);
            // 
            // submitChannel
            // 
            this.submitChannel.Name = "submitChannel";
            this.submitChannel.Size = new System.Drawing.Size(159, 22);
            this.submitChannel.Text = "Submit Channel";
            this.submitChannel.Click += new System.EventHandler(this.submitChannel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sysLabel,
            this.tsPBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 323);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(574, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sysLabel
            // 
            this.sysLabel.Name = "sysLabel";
            this.sysLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // tsPBar
            // 
            this.tsPBar.Name = "tsPBar";
            this.tsPBar.Size = new System.Drawing.Size(100, 16);
            this.tsPBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.tsPBar.Visible = false;
            // 
            // wbApp
            // 
            this.wbApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.wbApp.Location = new System.Drawing.Point(194, 28);
            this.wbApp.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbApp.Name = "wbApp";
            this.wbApp.ScriptErrorsSuppressed = true;
            this.wbApp.Size = new System.Drawing.Size(380, 295);
            this.wbApp.TabIndex = 3;
            this.wbApp.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // txtCommands
            // 
            this.txtCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommands.Location = new System.Drawing.Point(194, 28);
            this.txtCommands.Multiline = true;
            this.txtCommands.Name = "txtCommands";
            this.txtCommands.Size = new System.Drawing.Size(379, 294);
            this.txtCommands.TabIndex = 4;
            // 
            // locateVLC
            // 
            this.locateVLC.Image = global::rtmpGUI.Properties.Resources.application_form_add;
            this.locateVLC.Name = "locateVLC";
            this.locateVLC.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.locateVLC.Size = new System.Drawing.Size(208, 22);
            this.locateVLC.Text = "&Options";
            this.locateVLC.Click += new System.EventHandler(this.optionsMenu_Click);
            // 
            // refreshMenu
            // 
            this.refreshMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remoteXmlLoad,
            this.LocalXMLLoad,
            this.webpageRefresh});
            this.refreshMenu.Image = global::rtmpGUI.Properties.Resources.arrow_refresh;
            this.refreshMenu.Name = "refreshMenu";
            this.refreshMenu.Size = new System.Drawing.Size(208, 22);
            this.refreshMenu.Text = "Refresh";
            // 
            // remoteXmlLoad
            // 
            this.remoteXmlLoad.Image = global::rtmpGUI.Properties.Resources.world;
            this.remoteXmlLoad.Name = "remoteXmlLoad";
            this.remoteXmlLoad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.remoteXmlLoad.Size = new System.Drawing.Size(183, 22);
            this.remoteXmlLoad.Text = "&Remote XML";
            this.remoteXmlLoad.Click += new System.EventHandler(this.remoteXmlLoad_Click);
            // 
            // LocalXMLLoad
            // 
            this.LocalXMLLoad.Image = global::rtmpGUI.Properties.Resources.drive;
            this.LocalXMLLoad.Name = "LocalXMLLoad";
            this.LocalXMLLoad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.LocalXMLLoad.Size = new System.Drawing.Size(183, 22);
            this.LocalXMLLoad.Text = "&Local XML";
            this.LocalXMLLoad.Click += new System.EventHandler(this.LocalXMLLoad_Click);
            // 
            // webpageRefresh
            // 
            this.webpageRefresh.Image = global::rtmpGUI.Properties.Resources.page;
            this.webpageRefresh.Name = "webpageRefresh";
            this.webpageRefresh.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.webpageRefresh.Size = new System.Drawing.Size(183, 22);
            this.webpageRefresh.Text = "&Web Page";
            this.webpageRefresh.Click += new System.EventHandler(this.webpageRefresh_Click);
            // 
            // showCommands
            // 
            this.showCommands.CheckOnClick = true;
            this.showCommands.Image = global::rtmpGUI.Properties.Resources.application_osx_terminal;
            this.showCommands.Name = "showCommands";
            this.showCommands.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.showCommands.Size = new System.Drawing.Size(208, 22);
            this.showCommands.Text = "&Show Commands";
            this.showCommands.Click += new System.EventHandler(this.showCommands_Click);
            // 
            // checkUpdatesMenu
            // 
            this.checkUpdatesMenu.Image = global::rtmpGUI.Properties.Resources.connect;
            this.checkUpdatesMenu.Name = "checkUpdatesMenu";
            this.checkUpdatesMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.checkUpdatesMenu.Size = new System.Drawing.Size(208, 22);
            this.checkUpdatesMenu.Text = "Check &Updates";
            this.checkUpdatesMenu.Click += new System.EventHandler(this.checkUpdatesMenu_Click);
            // 
            // exitMenu
            // 
            this.exitMenu.Image = global::rtmpGUI.Properties.Resources.cross;
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitMenu.Size = new System.Drawing.Size(208, 22);
            this.exitMenu.Text = "E&xit";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // howToMenu
            // 
            this.howToMenu.CheckOnClick = true;
            this.howToMenu.Image = global::rtmpGUI.Properties.Resources.newspaper;
            this.howToMenu.Name = "howToMenu";
            this.howToMenu.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.howToMenu.Size = new System.Drawing.Size(149, 22);
            this.howToMenu.Text = "H&ow To";
            this.howToMenu.Click += new System.EventHandler(this.howToMenu_Click);
            // 
            // aboutMenu
            // 
            this.aboutMenu.Image = global::rtmpGUI.Properties.Resources.book_open;
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutMenu.Size = new System.Drawing.Size(149, 22);
            this.aboutMenu.Text = "&About";
            this.aboutMenu.Click += new System.EventHandler(this.aboutMenu_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 345);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.wbApp);
            this.Controls.Add(this.txtCommands);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "rtmpGUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locateVLC;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.ToolStripMenuItem refreshMenu;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.ColumnHeader channel_name;
        private System.Windows.Forms.ColumnHeader swf_url;
        private System.Windows.Forms.ColumnHeader rtmp_url;
        private System.Windows.Forms.ColumnHeader http_url;
        private System.Windows.Forms.ColumnHeader additional_info;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem recordChannel;
        private System.Windows.Forms.ToolStripMenuItem showCommands;
        private System.Windows.Forms.ToolStripMenuItem addChannel;
        private System.Windows.Forms.ToolStripMenuItem deleteChannel;
        private System.Windows.Forms.TextBox txtCommands;
        private System.Windows.Forms.ToolStripMenuItem editChannel;
        public System.Windows.Forms.WebBrowser wbApp;
        protected internal System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem saveChannels;
        private System.Windows.Forms.ToolStripMenuItem remoteXmlLoad;
        private System.Windows.Forms.ToolStripMenuItem LocalXMLLoad;
        private System.Windows.Forms.ToolStripMenuItem submitChannel;
        private System.Windows.Forms.ToolStripMenuItem checkUpdatesMenu;
        private System.Windows.Forms.ToolStripProgressBar tsPBar;
        public System.Windows.Forms.ToolStripStatusLabel sysLabel;
        private System.Windows.Forms.ColumnHeader channel_language;
        private System.Windows.Forms.ToolStripMenuItem webpageRefresh;
    }
}

