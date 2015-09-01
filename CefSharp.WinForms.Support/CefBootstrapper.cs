using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp.WinForms.Support.Schemes;

namespace CefSharp.WinForms.Support
{
    public static class CefBootstrapper
    {
        public static void Initialize()
        {
            var settings = new CefSettings();
            settings.CefCommandLineArgs.Add("disable-gpu-vsync", "1");//https://github.com/cefsharp/CefSharp/wiki/Trouble-Shooting
            settings.CefCommandLineArgs.Add("disable-gpu", "1");//https://github.com/cefsharp/CefSharp/wiki/Trouble-Shooting
            settings.CachePath = "cache";


            // Register localfile scheme
            settings.RegisterScheme(new CefCustomScheme()
            {
                SchemeName = LocalFileSchemeHandlerFactory.SchemeName,
                SchemeHandlerFactory = new LocalFileSchemeHandlerFactory()
            });

            // Register resouce scheme
            settings.RegisterScheme(new CefCustomScheme()
            {
                SchemeName = EmbeddedResourceSchemeHandlerFactory.SchemeName,
                SchemeHandlerFactory = new EmbeddedResourceSchemeHandlerFactory()
            });

            Cef.Initialize(settings);
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

    }
}
