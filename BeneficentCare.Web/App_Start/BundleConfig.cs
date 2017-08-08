using System.Web;
using System.Web.Optimization;

namespace BeneficentCare.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-ui-1.12.1.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/materialize").Include(
                      "~/Scripts/materialize.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/lodash").Include(
                      "~/Scripts/lodash.min.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
                      "~/Scripts/angular.min.js",
                      "~/Scripts/angular-animate.min.js",
                      "~/Scripts/angular-route.min.js",
                      "~/Scripts/restangular.min.js"
                      ));

            bundles.Add(new ScriptBundle("~/siteJS").Include(
                    "~/Scripts/app.js",
                    "~/Scripts/site.js"));

            bundles.Add(new ScriptBundle("~/controllers").Include(
                    "~/Scripts/controllers/CustomerController.js",
                    "~/Scripts/controllers/SiteController.js",
                    "~/Scripts/controllers/ServicesController.js"));

            bundles.Add(new ScriptBundle("~/services").Include(
                    "~/Scripts/services/CustomerService.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/materialize.css",
                      "~/Content/site.css"));
        }
    }
}
