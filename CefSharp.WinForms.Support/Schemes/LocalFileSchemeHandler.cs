using System;
using System.Collections.Specialized;
using System.IO;

namespace CefSharp.WinForms.Support.Schemes
{
    // HT: http://thechriskent.com/2014/04/21/use-local-files-in-cefsharp/
    public class LocalFileSchemeHandler : ISchemeHandler
    {
        public bool ProcessRequestAsync(IRequest request, ISchemeHandlerResponse response, OnRequestCompletedHandler requestCompletedCallback)
        {
            try
            {
                var u = new Uri(request.Url);
                var file = u.Authority + u.AbsolutePath;

                if (!File.Exists(file)) return false;

                var bytes = File.ReadAllBytes(file);
                response.ResponseStream = new MemoryStream(bytes);

                switch (Path.GetExtension(file))
                {
                    case ".html":
                        response.MimeType = "text/html";
                        break;
                    case ".js":
                        response.MimeType = "text/javascript";
                        break;
                    case ".css":
                        response.MimeType = "text/css";
                        break;
                    case ".png":
                        response.MimeType = "image/png";
                        break;
                    case ".appcache":
                    case ".manifest":
                        response.MimeType = "text/cache-manifest";
                        break;
                    default:
                        response.MimeType = "application/octet-stream";
                        break;
                }
                requestCompletedCallback();
                return true;
            }
            catch (Exception e)
            {
                var foo = e;
                throw;
            }
        }
    }
}
