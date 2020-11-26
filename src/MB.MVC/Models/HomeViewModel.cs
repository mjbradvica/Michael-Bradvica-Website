using System;
using System.Collections.Generic;

namespace MB.MVC.Models
{
    public class HomeViewModel
    {
        public HomeViewModel(IEnumerable<Tuple<string, string>> blogArticles)
        {
            BlogArticles = blogArticles;
        }

        public IEnumerable<Tuple<string, string>> BlogArticles { get; }
    }
}
