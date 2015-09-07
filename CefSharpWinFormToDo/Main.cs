using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using CefSharp.WinForms.Support;
using CefSharp.WinForms.Support.Controls;

namespace CefSharpWinFormToDo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            InitBrowser(); // browser does not have design time support so init it here
            InitializeHttpServer();
            try
            {
                Browser.Load("chrome://version/");
            }
            catch (Exception e)
            {
                var foo = e;
                throw;
            }
        }

        public EnhancedChromiumWebBrowser Browser { get; private set; }
    
        private void InitBrowser()
        {
            Browser = new EnhancedChromiumWebBrowser(string.Empty)
            {
                BrowserSettings = CefBootstrapper.GetStandardBrowserSettings(),
                Dock = DockStyle.Fill,
            };
            Browser.ConsoleMessageUiThreadSafe += Browser_ConsoleMessageUiThreadSafe;
            Browser.AddressChangedUiThreadSafe += Browser_AddressChangedUiThreadSafe;

            // register objects for JavaScript
            _toDoStoreProxy = new ToDoStoreProxy();
            _toDoStoreProxy.StoreUpdated += _toDoStoreProxy_StoreUpdated;
            Browser.RegisterJsObject("todoStoreProxy", _toDoStoreProxy);

            splitTodos.Panel1.Controls.Add(Browser);

        }

        private ToDoStoreProxy _toDoStoreProxy;
        void _toDoStoreProxy_StoreUpdated(object sender, EventArgs e)
        {
            this.InvokeOnUiThreadIfRequired(UpdateTodoListDataSource);
        }

        private void UpdateTodoListDataSource()
        {
            this.SuspendLayout();
            TodoList.DataSource = _toDoStoreProxy.ToDoItems;
            this.ResumeLayout();

        }


        private void Browser_ConsoleMessageUiThreadSafe(object sender, ConsoleMessageEventArgs args)
        {
            BrowserConsole.AppendText(string.Format(
                "Line: {0} | Source: {1} | Message: {2}{3}",
                args.Line,
                args.Source,
                args.Message,
                Environment.NewLine
                ));
        }

        private void Browser_AddressChangedUiThreadSafe(object sender, AddressChangedEventArgs args)
        {
            BrowserAddressLog.AppendText(string.Format(
                "{0}{1}",
                args.Address,
                Environment.NewLine
                ));
        }



        private void Main_Load(object sender, EventArgs e)
        {
            StatusBarMessage.Text = Browser.Version;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            _simpleHttpServer.Stop();
            Browser.Dispose();
            Cef.Shutdown();
        }



        private void btnShowChromeVersionInfo_Click(object sender, EventArgs e)
        {
            Browser.Load("chrome://version/");
        }

        private void btnDevToolsShow_Click(object sender, EventArgs e)
        {
            Browser.ShowDevTools();
        }

        private void btnDevToolsHide_Click(object sender, EventArgs e)
        {
            Browser.CloseDevTools();
        }

        private void btnVanillaJs_Click(object sender, EventArgs e)
        {
            var path = string.Format(
                "http://localhost:{0}/vanillajs/index.html", 
                _simpleHttpServer.Port
                );
            Browser.Load(path);
        }

        private void btnJQuery_Click(object sender, EventArgs e)
        {
            var path = string.Format(
                "http://localhost:{0}/jquery/index.html",
                _simpleHttpServer.Port
                );
            Browser.Load(path);
        }

        private void InitializeHttpServer()
        {
            var executingDir = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            if (executingDir == null)
            {
                throw new Exception("Unable to discover path to executing directory");
            }
            var pathToTodoMvc = Path.Combine(executingDir, "todomvc");
            _simpleHttpServer = new SimpleHttpServer(pathToTodoMvc);
        }

        private SimpleHttpServer _simpleHttpServer;

        private void txtNewTodoTitle_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter
                && !string.IsNullOrEmpty(txtNewTodoTitle.Text))
            {
                _toDoStoreProxy.AddToDoItemFromWinForm(Browser, txtNewTodoTitle.Text);
                txtNewTodoTitle.Text = string.Empty;
            }
        }


    }
}
