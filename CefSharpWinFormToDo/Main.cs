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

        public ChromiumWebBrowser Browser { get; private set; }
    
        private void InitBrowser()
        {
            Browser = CefBootstrapper.GetStandardBrowser();
            Browser.Dock = DockStyle.Fill;
            splitContainer1.Panel1.Controls.Add(Browser);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Browser.Dispose();
            Cef.Shutdown();
        }

    }
}
