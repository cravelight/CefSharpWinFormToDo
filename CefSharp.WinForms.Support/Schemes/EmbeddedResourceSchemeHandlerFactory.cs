namespace CefSharp.WinForms.Support.Schemes
{
    public class EmbeddedResourceSchemeHandlerFactory : ISchemeHandlerFactory
    {
        public ISchemeHandler Create()
        {
            return new EmbeddedResourceSchemeHandler();
        }

        public static string SchemeName { get { return "resource"; } }
    }
}