using System.Web;
using System.Web.Optimization;

namespace AircraftCheckout
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                       "~/Scripts/Angular/angular.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Styles/Bootstrap/bootstrap.css",
                      "~/Content/Styles/site.css"));
        }
    }
}
