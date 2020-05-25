using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace My_Second_Umbraco_7_Site.Models
{
    public class NavigationLink
    {
        public string Text { get; set; }
        public string Url { get; set; }
        public bool NewWindow { get; set; }
        public string Target { get { return NewWindow ? "_blank" : null; } }
        public string Title { get; set; }

        public NavigationLink()
        { }

        public NavigationLink(string url, string text = null, bool newWindow = false, string title = null)
        {
            Url = url;
            Text = text;
            NewWindow = newWindow;
            Title = title;
        }
    }
}