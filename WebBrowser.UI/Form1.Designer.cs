namespace WebBrowser.UI
{
    public partial class VoyageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.voyageTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeCurrentTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePageAsHTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitWebBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabUserControl1 = new WebBrowser.UI.TabUC(tabPage1);
            this.enableDarkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voyageTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // voyageTabControl
            // 
            this.voyageTabControl.Controls.Add(this.tabPage1);
            this.voyageTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.voyageTabControl.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voyageTabControl.Location = new System.Drawing.Point(0, 28);
            this.voyageTabControl.Name = "voyageTabControl";
            this.voyageTabControl.SelectedIndex = 0;
            this.voyageTabControl.Size = new System.Drawing.Size(1590, 852);
            this.voyageTabControl.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabUserControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1582, 818);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1590, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabToolStripMenuItem,
            this.closeCurrentTabToolStripMenuItem,
            this.savePageAsHTMLToolStripMenuItem,
            this.printPageToolStripMenuItem,
            this.enableDarkModeToolStripMenuItem,
            this.exitWebBrowserToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newTabToolStripMenuItem
            // 
            this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            this.newTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.newTabToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.newTabToolStripMenuItem.Text = "New Tab";
            this.newTabToolStripMenuItem.Click += new System.EventHandler(this.newTabToolStripMenuItem_Click);
            // 
            // closeCurrentTabToolStripMenuItem
            // 
            this.closeCurrentTabToolStripMenuItem.Name = "closeCurrentTabToolStripMenuItem";
            this.closeCurrentTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeCurrentTabToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.closeCurrentTabToolStripMenuItem.Text = "Close Current Tab";
            this.closeCurrentTabToolStripMenuItem.Click += new System.EventHandler(this.closeCurrentTabToolStripMenuItem_Click);
            // 
            // savePageAsHTMLToolStripMenuItem
            // 
            this.savePageAsHTMLToolStripMenuItem.Name = "savePageAsHTMLToolStripMenuItem";
            this.savePageAsHTMLToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.savePageAsHTMLToolStripMenuItem.Text = "Save Page as HTML";
            this.savePageAsHTMLToolStripMenuItem.Click += new System.EventHandler(this.savePageAsHTMLToolStripMenuItem_Click);
            // 
            // printPageToolStripMenuItem
            // 
            this.printPageToolStripMenuItem.Name = "printPageToolStripMenuItem";
            this.printPageToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.printPageToolStripMenuItem.Text = "Print Page";
            this.printPageToolStripMenuItem.Click += new System.EventHandler(this.printPageToolStripMenuItem_Click);
            // 
            // exitWebBrowserToolStripMenuItem
            // 
            this.exitWebBrowserToolStripMenuItem.Name = "exitWebBrowserToolStripMenuItem";
            this.exitWebBrowserToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.exitWebBrowserToolStripMenuItem.Text = "E&xit Web Browser";
            this.exitWebBrowserToolStripMenuItem.Click += new System.EventHandler(this.exitWebBrowserToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageHistoryToolStripMenuItem,
            this.manageBookmarksToolStripMenuItem,
            this.clearHistoryToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // manageHistoryToolStripMenuItem
            // 
            this.manageHistoryToolStripMenuItem.Name = "manageHistoryToolStripMenuItem";
            this.manageHistoryToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manageHistoryToolStripMenuItem.Text = "Manage History";
            this.manageHistoryToolStripMenuItem.Click += new System.EventHandler(this.manageHistoryToolStripMenuItem_Click);
            // 
            // manageBookmarksToolStripMenuItem
            // 
            this.manageBookmarksToolStripMenuItem.Name = "manageBookmarksToolStripMenuItem";
            this.manageBookmarksToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manageBookmarksToolStripMenuItem.Text = "Manage Bookmarks";
            this.manageBookmarksToolStripMenuItem.Click += new System.EventHandler(this.manageBookmarksToolStripMenuItem_Click);
            // 
            // clearHistoryToolStripMenuItem
            // 
            this.clearHistoryToolStripMenuItem.Name = "clearHistoryToolStripMenuItem";
            this.clearHistoryToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clearHistoryToolStripMenuItem.Text = "Clear History";
            this.clearHistoryToolStripMenuItem.Click += new System.EventHandler(this.clearHistoryToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabUserControl1
            // 
            this.tabUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabUserControl1.Location = new System.Drawing.Point(0, 0);
            this.tabUserControl1.Name = "tabUserControl1";
            this.tabUserControl1.Size = new System.Drawing.Size(1582, 818);
            this.tabUserControl1.TabIndex = 0;
            // 
            // enableDarkModeToolStripMenuItem
            // 
            this.enableDarkModeToolStripMenuItem.Name = "enableDarkModeToolStripMenuItem";
            this.enableDarkModeToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.enableDarkModeToolStripMenuItem.Text = "Enable Dark Mode";
            // 
            // VoyageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1590, 880);
            this.Controls.Add(this.voyageTabControl);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "VoyageForm";
            this.Text = "Sunset";
            this.Load += new System.EventHandler(this.VoyageForm_Load);
            this.voyageTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TabControl voyageTabControl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeCurrentTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePageAsHTMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitWebBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBookmarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.TabPage tabPage1;
        private TabUC tabUserControl1;
        private System.Windows.Forms.ToolStripMenuItem clearHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableDarkModeToolStripMenuItem;
    }
}

