using My_Second_Umbraco_7_Site.Models;
using System.Collections.Generic;
using System.Configuration;
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
            List<InstagramPost> posts = new List<InstagramPost>();

            IEnumerable<IPublishedContent> items = homePage.GetPropertyValue<IEnumerable<IPublishedContent>>("instagramPostList");
            if (items != null)
            {
                foreach (var item in items)
                {
                    string imageUrl = item.GetPropertyValue<IPublishedContent>("instagramImage").Url;
                    posts.Add(new InstagramPost(imageUrl));
                }
            }

            Instagram model = new Instagram(title, posts);
            return PartialView($"{PartialViewDir}_Instagram.cshtml", model);
        }
    }
}
