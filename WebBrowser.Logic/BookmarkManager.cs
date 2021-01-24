using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.DataSet1TableAdapters;

namespace WebBrowser.Logic
{
    public class BookmarkManager
    {

        public static void AddItem(BookmarkItem item)
        {

            var adapter = new BookamrksTableAdapter();
            adapter.Insert(item.URL, item.Title);
        }

        public static List<BookmarkItem> GetItems()
        {
            var adapter = new BookamrksTableAdapter();
            var results = new List<BookmarkItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new BookmarkItem();
                item.URL = row.URL;
                item.Title = row.Title;

                results.Add(item);
            }

            return results;
        }

        public static List<BookmarkItem> GetSearchItems(string search)
        {
            var adapter = new BookamrksTableAdapter();
            var results = new List<BookmarkItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new BookmarkItem();
                item.URL = row.URL;
                item.Title = row.Title;
                

                if (row.Title.Contains(search))

                    results.Add(item);

            }

            return results;
        }


        public static List<BookmarkItem> DeleteSelected(string selected)
        {
            var adapter = new BookamrksTableAdapter();
            var results = new List<BookmarkItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new BookmarkItem();
                item.URL = row.URL;
                item.Title = row.Title;
                results.Add(item);

                if (selected.Contains(row.Title))
                {
                    adapter.DeleteQuery(item.Title);
                    results.Remove(item);
                }

            }

            return results;
        }

    }

}
