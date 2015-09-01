namespace CefSharp.WinForms.Support.Schemes
{
    public class LocalFileSchemeHandlerFactory : ISchemeHandlerFactory
    {
        public ISchemeHandler Create()
        {
            return new LocalFileSchemeHandler();
        }

        public static string SchemeName { get { return "localfile"; } }
    }
}