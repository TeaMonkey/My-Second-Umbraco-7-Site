using System.Collections.Generic;

namespace My_Second_Umbraco_7_Site.Models
{
    public class BlogPreview
    {
        public List<BlogItem> Item { get; set; } = new List<BlogItem>();
        public bool HorizontalLayout { get; set; } = false;

        public BlogPreview(List<BlogItem> item, bool horizontalLayout)
        {
            Item = item;
            HorizontalLayout = horizontalLayout;
        }
    }
}