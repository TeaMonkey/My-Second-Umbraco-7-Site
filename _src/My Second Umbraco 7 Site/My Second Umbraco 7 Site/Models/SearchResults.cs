using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;

namespace My_Second_Umbraco_7_Site.Models
{
    public class SearchResults
    {
        public string SearchTerm { get; set; }
        public IEnumerable<IPublishedContent> Results { get; set; }
        public bool HasResults { get { return Results != null && Results.Any(); } }
        public int PageNumber { get; set; }
        public int PageCount { get; set; }
        public int TotalItemCount { get; set; }
        public PagingBounds PagingBoundsModel { get; set; }
    }
}