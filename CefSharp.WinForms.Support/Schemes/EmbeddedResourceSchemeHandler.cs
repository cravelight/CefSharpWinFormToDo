using System;
using System.IO;
using System.Reflection;

namespace CefSharp.WinForms.Support.Schemes
{
    // HT: http://thechriskent.com/2014/05/12/use-embedded-resources-in-cefsharp/
    public class EmbeddedResourceSchemeHandler : ISchemeHandler
    {
        public bool ProcessRequestAsync(IRequest request, ISchemeHandlerResponse response, OnRequestCompletedHandler requestCompletedCallback)
        {
            var u = new Uri(request.Url);
            var file = u.Authority + u.AbsolutePath;

            var assembly = Assembly.GetExecutingAssembly();
            var resourcePath = assembly.GetName().Name + "." + file.Replace("/", ".");

            if (assembly.GetManifestResourceInfo(resourcePath) == null) return false;

            response.ResponseStream = assembly.GetManifestResourceStream(resourcePath);
            switch (Path.GetExtension(file))
            {
                case ".html":
                    response.MimeType = "text/html";
                    break;
                case ".js":
                    response.MimeType = "text/javascript";
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
    }
}
