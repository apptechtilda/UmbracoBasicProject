using System;
using System.Web.Mvc;
using System.Web.Optimization;
using BasicUmbraco.Web.App_Start;


namespace BasicUmbraco.Web
{
    public class MvcApplication : Umbraco.Web.UmbracoApplication
    {

        protected override void OnApplicationStarted(object sender, EventArgs e)
        {
            base.OnApplicationStarted(sender, e);

            AreaRegistration.RegisterAllAreas();
            BundleConfig.RegisterBundles(BundleTable.Bundles);

        }
    }
}
