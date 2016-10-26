using System.Web;
using System.Web.Optimization;

namespace Citus.Education.WebApp.Sample.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.unobtrusive-ajax.js"));
          

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));
            //datatables
            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
         "~/Scripts/dataTables/jquery.dataTables.js",
         "~/Scripts/dataTables/dataTables*"));

            bundles.Add(new ScriptBundle("~/bundles/views").Include(
                  "~/Scripts/Views/CvCompetenceList.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                 "~/Content/DataTables/css/jquery.dataTables.css",
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
