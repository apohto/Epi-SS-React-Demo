using System.Web.Optimization;
using System.Web.Optimization.React;

namespace Epi_SS_React_Demo
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new BabelBundle("~/bundles/main").Include(
                "~/Static/js/PrimaryCallout.jsx"
            ));

            // Force minification/combination even in debug mode
            BundleTable.EnableOptimizations = true;
        }
    }
}