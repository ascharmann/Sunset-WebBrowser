using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.DataSet1TableAdapters;

namespace WebBrowser.Logic
{
    public class HistoryManager
    {
        public static void AddItem(HistoryItem item)
        {
            var adapter = new HistoryTableAdapter();
            adapter.Insert(item.URL, item.Title, item.Date);
        }

        public static List<HistoryItem> GetItems()
        {
            var adapter = new HistoryTableAdapter();
            var results = new List<HistoryItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new HistoryItem();
                item.URL = row.URL;
                item.Title = row.Title;
                item.Date = row.Date;

                results.Add(item);
            }

            return results;

        }

        public static List<HistoryItem> GetSearchItems(string search)
        {
            var adapter = new HistoryTableAdapter();
            var results = new List<HistoryItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new HistoryItem();
                item.URL = row.URL;
                item.Title = row.Title;
                item.Date = row.Date;

                if (item.Title.Contains(search))
                {

                    results.Add(item);
                }
                    
            }

            return results;
        }


        public static void ClearHistory()
        {
            var adapter = new HistoryTableAdapter();
            adapter.ClearHistory();
           
        }

        public static List<HistoryItem> DeleteSelected(string selected)
        {

            var adapter = new HistoryTableAdapter();
            var results = new List<HistoryItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new HistoryItem();
                item.URL = row.URL;
                item.Title = row.Title;
                item.Date = row.Date;
                results.Add(item);

                if (selected.Contains(row.Date.ToString()))
                {
                    adapter.DeleteQuery(item.Date);
                    results.Remove(item);
                }
                    
                
            }

            return results;

        }

    }
}
