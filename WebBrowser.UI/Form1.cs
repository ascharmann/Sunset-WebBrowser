using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
    public partial class VoyageForm : Form
    {
        public VoyageForm()
        {
            InitializeComponent();
        }


        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the Sunset Web Browser." + Environment.NewLine + "Developed by: Ashlie Scharmann" + Environment.NewLine +
            "Software Construction Fundamentals" + Environment.NewLine + "Fall 2020 - Term A" + Environment.NewLine + "Auburn University");
        }

        public void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage newTab = new TabPage();
            voyageTabControl.Controls.Add(newTab);
            newTab.BringToFront();
            newTab.Dock = DockStyle.Fill;
            TabUC newTabUC = new TabUC(newTab);
            newTab.Controls.Add(newTabUC);
            newTabUC.Dock = DockStyle.Fill;
         
        }


        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            voyageTabControl.TabPages.Remove(voyageTabControl.SelectedTab);
        }

        private void manageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var historyform = new HistoryManagerForm();
            historyform.ShowDialog();
        }

        private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bookmarkform = new BookmarkManagerForm();
            bookmarkform.ShowDialog();
        }

        private void VoyageForm_Load(object sender, EventArgs e)
        {
            tabUserControl1.webBrowser1.Navigate("www.auburn.edu");
           // voyageTabControl.SelectedTab.Text = (tabUserControl1.webBrowser1.DocumentTitle);
        }

        private void savePageAsHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabUserControl1.webBrowser1.ShowSaveAsDialog();
        }

        private void printPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabUserControl1.webBrowser1.ShowPrintDialog();
        }

        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryManager.ClearHistory();
            
            
        }
    }
}
