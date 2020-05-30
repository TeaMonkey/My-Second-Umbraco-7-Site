using My_Second_Umbraco_7_Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web.Mvc;

namespace My_Second_Umbraco_7_Site.Controllers
{
    public class SiteLayoutController : SurfaceController
    {
        private const string PartialViewDir = "~/Views/Partials/SiteLayout/";

        public ActionResult RenderHeader()
        {
            List<NavigationListItem> nav = Helper.GetObjectFromCache("headerNav", 20, GetNavigationModelFromUmbraco);
            return PartialView($"{PartialViewDir}_Header.cshtml", nav);
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

        public ActionResult RenderLargeHeadingControl()
        {
            return PartialView($"{PartialViewDir}_LargeHeaderControl.cshtml");
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

            var childPages = page.Children;

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
    }
}