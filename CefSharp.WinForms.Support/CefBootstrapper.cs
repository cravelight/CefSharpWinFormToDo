using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CefSharp.WinForms.Support
{
    public static class CefBootstrapper
    {
        public static void Initialize()
        {
            Cef.Initialize(new CefSettings());

        }

        public static BrowserSettings GetStandardBrowserSettings()
        {
            var browserSettings = new BrowserSettings
            {
                FileAccessFromFileUrlsAllowed = true, // cross domain http://stackoverflow.com/a/18013586/121466
                UniversalAccessFromFileUrlsAllowed = true, // cross domain http://stackoverflow.com/a/18013586/121466
                WebSecurityDisabled = false, //false is default
                TextAreaResizeDisabled = true
            };
            return browserSettings;
        }

        public static ChromiumWebBrowser GetStandardBrowser(string url = "")
        {
            return new ChromiumWebBrowser(url)
            {
                BrowserSettings = GetStandardBrowserSettings()
            };

        }

    }
}
