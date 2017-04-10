using System.Web.Optimization;

namespace MyOwnSite
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
   "~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
   "~/Scripts/jquery-ui-{version}.js",
   "~/Scripts/jquery-ui-{version}.min.js"
   ));
            


        }

    }
}