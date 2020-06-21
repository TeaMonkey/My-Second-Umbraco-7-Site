using System;

namespace My_Second_Umbraco_7_Site.Models
{
    public class BlogItem
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Intro { get; set; }
        public DateTime PostDate { get; set; }
        public string LinkUrl { get; set; }

        public BlogItem(string name, string category, string intro, DateTime postDate, string linkUrl)
        {
            Name = name;
            Category = category;
            Intro = intro;
            PostDate = postDate;
            LinkUrl = linkUrl;
        }
    }
}