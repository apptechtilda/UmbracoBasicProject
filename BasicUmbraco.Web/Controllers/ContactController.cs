using BasicUmbraco.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Umbraco.Web;
using umbraco.MacroEngines;
using Umbraco.Web.Models;
//using Umbraco.Web.Macros.PartialViewMacroPage;
namespace BasicUmbraco.Web.Controllers
{
    public class ContactController : SurfaceController
    {

        [HttpPost]
        public ActionResult Submit(UmbracoContactModel model)
        {
            //var paramCategories = PartialViewMacroModelExtensions.GetParameterValue<string>(model.Subject, "Subject", "test").ToString();
            if (!ModelState.IsValid)
                return CurrentUmbracoPage();

            /// Work with form data here

            return RedirectToCurrentUmbracoPage();
        }
    }

}