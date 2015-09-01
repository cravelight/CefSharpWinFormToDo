using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp.WinForms.Support.Controls;

namespace CefSharp.WinForms.Support
{
    public class EnhancedChromiumWebBrowser : ChromiumWebBrowser
    {
        public EnhancedChromiumWebBrowser(string address) : base(address)
        {
            SetupUiThreadSafeEvents();
        }


        #region UI Thread Safe Events Support

        private void SetupUiThreadSafeEvents()
        {
            this.NavStateChanged += OnNavStateChanged;
            this.ConsoleMessage += OnConsoleMessage;
            this.StatusMessage += OnStatusMessage;
            this.TitleChanged += OnTitleChanged;
            this.AddressChanged += OnAddressChanged;
        }


        /// <summary>
        /// Invokes the event handler on the UI thread if it needs to.
        /// </summary>
        public event EventHandler<ConsoleMessageEventArgs> ConsoleMessageUiThreadSafe;
        private void OnConsoleMessage(object sender, ConsoleMessageEventArgs args)
        {
            if (ConsoleMessageUiThreadSafe != null)
            {
                this.InvokeOnUiThreadIfRequired(() => ConsoleMessageUiThreadSafe(sender, args));
            }
        }


        /// <summary>
        /// Invokes the event handler on the UI thread if it needs to.
        /// </summary>
        public event EventHandler<StatusMessageEventArgs> StatusMessageUiThreadSafe;
        private void OnStatusMessage(object sender, StatusMessageEventArgs args)
        {
            if (StatusMessageUiThreadSafe != null)
            {
                this.InvokeOnUiThreadIfRequired(() => StatusMessageUiThreadSafe(sender, args));
            }
        }


        /// <summary>
        /// Invokes the event handler on the UI thread if it needs to.
        /// </summary>
        public event EventHandler<NavStateChangedEventArgs> NavStateChangedUiThreadSafe;
        private void OnNavStateChanged(object sender, NavStateChangedEventArgs args)
        {
            if (NavStateChangedUiThreadSafe != null)
            {
                this.InvokeOnUiThreadIfRequired(() => NavStateChangedUiThreadSafe(sender, args));
            }
        }


        /// <summary>
        /// Invokes the event handler on the UI thread if it needs to.
        /// </summary>
        public event EventHandler<TitleChangedEventArgs> TitleChangedUiThreadSafe;
        private void OnTitleChanged(object sender, TitleChangedEventArgs args)
        {
            if (TitleChangedUiThreadSafe != null)
            {
                this.InvokeOnUiThreadIfRequired(() => TitleChangedUiThreadSafe(sender, args));
            }
        }


        /// <summary>
        /// Invokes the event handler on the UI thread if it needs to.
        /// </summary>
        public event EventHandler<AddressChangedEventArgs> AddressChangedUiThreadSafe;
        private void OnAddressChanged(object sender, AddressChangedEventArgs args)
        {
            if (AddressChangedUiThreadSafe != null)
            {
                this.InvokeOnUiThreadIfRequired(() => AddressChangedUiThreadSafe(sender, args));
            }
        }

        #endregion // UI Thread Safe Events Support


        public string Version
        {
            get
            {
                var bitness = Environment.Is64BitProcess ? "x64" : "x86";
                return String.Format("Chromium: {0}, CEF: {1}, CefSharp: {2}, Environment: {3}", Cef.ChromiumVersion, Cef.CefVersion, Cef.CefSharpVersion, bitness);
            }
        }



    }
}
