using System.Web;
using System.Web.Optimization;

namespace WatchShop
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Content/js/popper.min.js",
                        "~/Content/js/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                         "~/Content/js/jquery.superslides.min.js",
                         "~/Content/js/bootstrap-select.js",
                         "~/Content/js/inewsticker.js",
                         "~/Content/js/bootsnav.js",
                         "~/Content/js/images-loded.min.js",
                         "~/Content/js/isotope.min.js",
                         "~/Content/js/owl.carousel.min.js",
                         "~/Content/js/baguetteBox.min.js",
                         "~/Content/js/form-validator.min.js",
                         "~/Content/js/contact-form-script.js",
                         "~/Content/js/custom.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                       "~/Content/css/bootstrap.min.css",
                       "~/Content/css/style.css",
                       "~/Content/css/responsive.css"));
        }
    }
}
