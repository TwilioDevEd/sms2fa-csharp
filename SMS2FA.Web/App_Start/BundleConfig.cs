using System.Web.Optimization;

namespace SMS2FA.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                      "~/Scripts/lib/dist/bootstrap.js",
                      "~/Scripts/lib/dist/jquery.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Scripts/lib/dist/css/fontawesome.css",
                      "~/Scripts/lib/dist/css/bootstrap.css",
                      "~/Content/Site.css"));
        }
    }
}
