using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp.WinForms;
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

        public void WriteToWinFormStoreFromJavaScript(string jsonItems)
        {
            ToDoItems = JsonConvert.DeserializeObject<List<ToDoItem>>(jsonItems);
            if (StoreUpdated != null)
            {
                StoreUpdated(this, EventArgs.Empty);
            }
        }

        public event EventHandler StoreUpdated;

        public void AddToDoItemFromWinForm(ChromiumWebBrowser browser, string title)
        {
            var js = "App.todos.push({" +
                     "id: '" + Guid.NewGuid() + "'," +
                     "title: '" + title + "'," +
                     "completed: false" +
                     "});";

            browser.ExecuteScriptAsync(js);
            browser.ExecuteScriptAsync("App.render();");
        }

    }

    public class ToDoItem
    {
        public Guid id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }
    }
}
