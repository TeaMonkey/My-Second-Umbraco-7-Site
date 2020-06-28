using System.Collections.Generic;
using System.Linq;
using Umbraco.ModelsBuilder;

namespace My_Second_Umbraco_7_Site.Models
{
    public class Instagram
    {
        public string Title { get; set; }
        public List<InstagramPost> Posts { get; set; }
        public bool HasPosts { get { return Posts != null && Posts.Any(); } }
        public string ColumnClass
        {
            get
            {
                switch (Posts.Count)
                {
                    case 1:
                        return "col-md-12";
                    case 2:
                        return "col-md-6";
                    case 3:
                        return "col-md-4";
                    case 4:
                        return "col-md-3";
                    default:
                        return "col-md-12";
                }
            }
        }

        public Instagram(string title, List<InstagramPost> posts)
        {
            Title = title;
            Posts = posts;
        }
    }
}