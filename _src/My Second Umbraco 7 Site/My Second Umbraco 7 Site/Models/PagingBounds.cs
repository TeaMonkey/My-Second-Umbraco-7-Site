using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace My_Second_Umbraco_7_Site.Models
{
    public class PagingBounds
    {
        public int StartPage { get; set; }
        public int EndPage { get; set; }
        public bool ShowFirstButton { get; set; }
        public bool ShowLastButton { get; set; }

        public PagingBounds(int startPage, int endPage, bool showFirstButton, bool showLastButton)
        {
            StartPage = startPage;
            EndPage = endPage;
            ShowFirstButton = showFirstButton;
            ShowLastButton = showLastButton;
        }

    }
}