using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace My_Second_Umbraco_7_Site.Models
{
    public class InstagramPost
    {
        public string Image { get; set; }

        public InstagramPost(string image)
        {
            Image = image;
        }
    }
}