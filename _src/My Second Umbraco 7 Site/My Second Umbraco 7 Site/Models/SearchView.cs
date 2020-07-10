using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace My_Second_Umbraco_7_Site.Models
{
    public class SearchView
    {
        public string SearchTerm { get; set; }
        public string DocTypeAliases { get; set; }
        public string FieldPropertyAliases { get; set; }
        public int PageSize { get; set; }
        public int PagingGroupSize { get; set; }
        public List<SearchGroup> SearchGroups { get; set; }
        public SearchResults SearchResultsModel { get; set; }

    }
}