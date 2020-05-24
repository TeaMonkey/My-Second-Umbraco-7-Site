using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web.Mvc;
using System.Web.Mvc;

namespace My_Second_Umbraco_7_Site.Controllers
{
    public class HomeController : SurfaceController
    {
        private const string PartialViewDir = "~/Views/Partials/Home/";

        public ActionResult RenderFeatured()
        {
            return PartialView($"{PartialViewDir}_Featured.cshtml");
        }

        public ActionResult RenderServices()
        {
            return PartialView($"{PartialViewDir}_Services.cshtml");
        }
    }
}