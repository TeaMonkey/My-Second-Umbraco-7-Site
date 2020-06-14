using My_Second_Umbraco_7_Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Mvc;

namespace My_Second_Umbraco_7_Site.Controllers
{
    public class BlogController : SurfaceController
    {
        private const string PartialViewDir = "~/Views/Partials/Blog/";

        public ActionResult RenderPostList()
        {
            List<BlogPreview> model = new List<BlogPreview>();
            IPublishedContent blogPage = CurrentPage.AncestorOrSelf(1).DescendantsOrSelf().Where(x => x.DocumentTypeAlias == "blog").FirstOrDefault();
           
            foreach (IPublishedContent page in blogPage.Children.Where(x => x.DocumentTypeAlias == "blogPost").OrderByDescending(x => x.UpdateDate))
            {
                model.Add(new BlogPreview(page.GetPropertyValue<string>("largeHeading"), page.GetPropertyValue<string>("articleCategory"), page.GetPropertyValue<string>("articleIntro"), page.GetPropertyValue<DateTime>("atriclePublishDate"), page.Url));
            }

            return PartialView($"{PartialViewDir}_PostList.cshtml", model);
        }
    }
}