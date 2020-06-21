using My_Second_Umbraco_7_Site.Models;
using System.Linq;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Mvc;

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
            IPublishedContent homePage = Umbraco.TypedContentAtRoot().First();

            string title = homePage.GetPropertyValue<string>("instagramTitle");

            Instagram model = new Instagram(title);
            return PartialView($"{PartialViewDir}_Instagram.cshtml", model);
        }
    }
}