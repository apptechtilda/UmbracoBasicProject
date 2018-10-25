using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace BasicUmbraco.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/site.js").Include(
            "~/Scripts/jquery-3.0.0.js",
            "~/Scripts/bootstrap.js",
             "~/Scripts/jquery.cookiebar.js",
               "~/Scripts/global.js"
            ));
            bundles.Add(new ScriptBundle("~/bundles/maps.js").Include(
              "~/Scripts/maps.js"
              ));

            bundles.Add(new ScriptBundle("~/bundles/knockout.js").Include(
            "~/Scripts/knockout-3.4.2.js",
            "~/Scripts/knockout.validation.js"
            ));
            bundles.Add(new StyleBundle("~/bundles/site.css").Include(
             "~/Content/bootstrap.css",
             "~/Content/font-awesome.css",
              "~/Content/jquery.cookiebar.css",
                     "~/Css/hamburger-navbar.css",
               "~/Css/elements.css",
                "~/Css/navbar.css"

             ));


        }
    }
}