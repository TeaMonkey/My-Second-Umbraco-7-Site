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

        public ActionResult RenderHero()
        {
            return PartialView($"{PartialViewDir}_Hero.cshtml");
        }

        public ActionResult RenderPopular()
        {
            return PartialView($"{PartialViewDir}_Popular.cshtml");
        }

        public ActionResult RenderInstagram()
        {
            return PartialView($"{PartialViewDir}_Instagram.cshtml");
        }
    }
}