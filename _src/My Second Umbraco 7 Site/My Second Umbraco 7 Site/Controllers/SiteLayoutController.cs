using My_Second_Umbraco_7_Site.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace My_Second_Umbraco_7_Site.Controllers
{
    public class SiteLayoutController : SurfaceController
    {
        private string PartialViewPath(string partialViewName)
        {
            return $"~/Views/Partials/SiteLayout/{partialViewName}.cshtml";
        }

        public ActionResult RenderHeader()
        {
            List<NavigationListItem> nav = Helper.GetObjectFromCache("headerNav", 20, GetNavigationModelFromUmbraco);
            return PartialView(PartialViewPath("_Header"), nav);
        }

        public ActionResult RenderFooter()
        {
            return PartialView(PartialViewPath("_Footer"));
        }

        public ActionResult RenderSignup()
        {
            return PartialView(PartialViewPath("_Signup"));
        }

        public ActionResult RenderExpandedHeader()
        {
            return PartialView(PartialViewPath("_ExpandedHeader"));
        }

        public ActionResult RenderLargeHeadingControl()
        {
            return PartialView(PartialViewPath("_LargeHeaderControl"));
        }

        private List<NavigationListItem> GetNavigationModelFromUmbraco()
        {
            IPublishedContent homePage = Umbraco.TypedContentAtRoot().First();

            List<NavigationListItem> nav = new List<NavigationListItem>();
            nav.Add(new NavigationListItem(new NavigationLink(homePage.Url, homePage.Name)));
            nav.AddRange(GetChildNavigationList(homePage));

            return nav;
        }

        private List<NavigationListItem> GetChildNavigationList(IPublishedContent page)
        {
            List<NavigationListItem> listItems = new List<NavigationListItem>();

            var childPages = page.Children.Where(x => (x.HasValue("excludeFromTopNavigation") && x.GetPropertyValue<bool>("excludeFromTopNavigation") != true) || !x.HasValue("excludeFromTopNavigation"));// & x.Level <= 2);  //todo: Change so that only outputs blog categores in the blog sub menu and not the blog posts

            if (childPages != null && childPages.Count() > 0)
            {
                foreach (var childPage in childPages)
                {
                    NavigationListItem listItem = new NavigationListItem(new NavigationLink(childPage.Url, childPage.Name));
                    listItem.Items = GetChildNavigationList(childPage);
                    listItems.Add(listItem);
                }
            }

            return listItems;
        }

        public ActionResult RenderStaffControl()
        {
            //TODO - Add support for when the content has not been set

            try
            {
                Staff staffModel = new Staff(CurrentPage.GetPropertyValue<string>("staffName"), CurrentPage.GetPropertyValue<IPublishedContent>("staffImage").Url, CurrentPage.GetPropertyValue<string>("staffRole"), CurrentPage.GetPropertyValue<string>("staffInformaiton"), CurrentPage.GetPropertyValue<Link>("staffFacebook").Url, CurrentPage.GetPropertyValue<Link>("staffTwitter").Url, CurrentPage.GetPropertyValue<Link>("staffDribbble").Url, CurrentPage.GetPropertyValue<Link>("staffGithub").Url);

                return PartialView(PartialViewPath("_Staff"), staffModel);
            }
            catch (System.Exception)
            {
                return new EmptyResult();
            }
        }
    }
}