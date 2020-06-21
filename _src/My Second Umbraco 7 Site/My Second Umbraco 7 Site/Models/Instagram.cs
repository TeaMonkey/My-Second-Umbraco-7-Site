using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace My_Second_Umbraco_7_Site.Models
{
    public class Instagram
    {
        public string Title { get; set; }

        public Instagram(string title)
        {
            Title = title;
        }
    }
}