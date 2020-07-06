using My_Second_Umbraco_7_Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Mvc;

namespace My_Second_Umbraco_7_Site.Controllers
{
    public class BlogController : SurfaceController
    {
        private string PartialViewPath(string partialViewName)
        {
            return $"~/Views/Partials/Blog/{partialViewName}.cshtml";
        }

        public ActionResult RenderPostList(int numberOfItems, bool horizontalLayout = false)
        {
            List<BlogItem> blogItems = new List<BlogItem>();
            IPublishedContent homePage = Umbraco.TypedContentAtRoot().First();
            IPublishedContent blogPage = homePage.Children.FirstOrDefault(x => x.DocumentTypeAlias == "blog");
           
            foreach (IPublishedContent page in blogPage.Children.Where(x => x.DocumentTypeAlias == "blogPost").OrderByDescending(x => x.UpdateDate).Take(numberOfItems))
            {
                blogItems.Add(new BlogItem(page.GetPropertyValue<string>("largeHeading"), page.GetPropertyValue<string>("articleCategory"), page.GetPropertyValue<string>("articleIntro"), page.GetPropertyValue<DateTime>("atriclePublishDate"), page.Url));
            }

            BlogPreview model = new BlogPreview(blogItems, horizontalLayout);
            return PartialView(PartialViewPath("_PostList"), model);
        }
    }
}