using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using CefSharp.WinForms.Support;

namespace CefSharpWinFormToDo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            InitBrowser(); // browser does not have design time support so init it here
            Browser.Load("maps.google.com");
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

            splitContainer1.Panel1.Controls.Add(Browser);

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


    }
}
