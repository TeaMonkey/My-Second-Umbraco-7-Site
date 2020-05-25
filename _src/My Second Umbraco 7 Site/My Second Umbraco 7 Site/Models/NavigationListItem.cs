using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace My_Second_Umbraco_7_Site.Models
{
    public class NavigationListItem
    {
        public string Text { get; set; }
        public NavigationLink Link { get; set; }
        public List<NavigationListItem> Items { get; set; }
        public bool HasKids { get { return Items != null && Items.Any(); } }

        public NavigationListItem()
        {
        }

        public NavigationListItem(NavigationLink link)
        {
            Link = link;
        }

        public NavigationListItem(string text)
        {
            Text = text;
        }
    }
}