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
    public partial class HistoryManagerForm : Form
    {
        public HistoryManagerForm()
        {
            InitializeComponent();
        }

        private void HistoryManagerForm_Load(object sender, EventArgs e)
        {

            var items = HistoryManager.GetItems();
            HistoryListBox.Items.Clear();

            foreach(var item in items)
            {
                HistoryListBox.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
            }

        }

        private void historySearchButton_Click(object sender, EventArgs e)
        {
            var items = HistoryManager.GetSearchItems(historySearchTextBox.Text);
            HistoryListBox.Items.Clear();

            foreach (var item in items)
            {
                HistoryListBox.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
            }

        }

        private void deleteHistoryButton_Click(object sender, EventArgs e)
        {

            var selected = HistoryListBox.SelectedItem.ToString();
            var items = HistoryManager.DeleteSelected(selected);

            HistoryListBox.Items.Clear();

            foreach(var item in items)
            {
                HistoryListBox.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
            }


        }

        private void clearHistoryButton_Click(object sender, EventArgs e)
        {

            HistoryManager.ClearHistory();
            HistoryListBox.Items.Clear();
            
        }
    }
}
