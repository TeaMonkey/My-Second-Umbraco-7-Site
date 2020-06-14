using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace My_Second_Umbraco_7_Site.Models
{
    public class BlogPreview
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Intro { get; set; }
        public DateTime PostDate { get; set; }
        public string LinkUrl { get; set; }

        public BlogPreview(string name, string category, string intro, DateTime postDate, string linkUrl)
        {
            Name = name;
            Category = category;
            Intro = intro;
            PostDate = postDate;
            LinkUrl = linkUrl;
        }
    }
}