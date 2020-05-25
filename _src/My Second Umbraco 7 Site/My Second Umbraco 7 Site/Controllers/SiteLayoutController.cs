using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace My_Second_Umbraco_7_Site.Controllers
{
    public class SiteLayoutController : SurfaceController
    {
        private const string PartialViewDir = "~/Views/Partials/SiteLayout/";

        public ActionResult RenderHeader()
        {
            return PartialView($"{PartialViewDir}_Header.cshtml");
        }

        public ActionResult RenderFooter()
        {
            return PartialView($"{PartialViewDir}_Footer.cshtml");
        }

        public ActionResult RenderSignup()
        {
            return PartialView($"{PartialViewDir}_Signup.cshtml");
        }

        public ActionResult RenderExpandedHeader()
        {
            return PartialView($"{PartialViewDir}_ExpandedHeader.cshtml");
        }
    }
}