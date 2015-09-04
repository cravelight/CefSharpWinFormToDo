using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CefSharpWinFormToDo
{
    public class ToDoStoreProxy
    {
        public List<ToDoItem> ToDoItems { get; private set; }

        public ToDoStoreProxy()
        {
            ToDoItems = new List<ToDoItem>();
        }

        public void WriteToStore(string jsonItems)
        {
            ToDoItems = JsonConvert.DeserializeObject<List<ToDoItem>>(jsonItems);
            if (StoreUpdated != null)
            {
                StoreUpdated(this, EventArgs.Empty);
            }
        }

        public event EventHandler StoreUpdated;
    }

    public class ToDoItem
    {
        public Guid id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }
    }
}
