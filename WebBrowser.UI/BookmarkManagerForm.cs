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
    public partial class BookmarkManagerForm : Form
    {
        public BookmarkManagerForm()
        {
            InitializeComponent();
        }

        private void BookmarkManagerForm_Load(object sender, EventArgs e)
        {

            var items = BookmarkManager.GetItems();
            BookmarkManagerlistBox.Items.Clear();

            foreach (var item in items)
            {
                
                {
                    BookmarkManagerlistBox.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));
                }
            }

        }

        private void BookmarkSearchButton_Click(object sender, EventArgs e)
        {
            BookmarkManagerlistBox.Items.Clear();
            var items = BookmarkManager.GetSearchItems(BookmarktextBox.Text);
            
            foreach (var item in items)
            {
                
                BookmarkManagerlistBox.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));
            }
        }

        private void deleteBookmarkButton_Click(object sender, EventArgs e)
        {
            string selected = BookmarkManagerlistBox.SelectedItem.ToString();
            var items = BookmarkManager.DeleteSelected(selected);

            BookmarkManagerlistBox.Items.Clear();

            foreach (var item in items)
            {
                BookmarkManagerlistBox.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));
            }

        }
    }
}
