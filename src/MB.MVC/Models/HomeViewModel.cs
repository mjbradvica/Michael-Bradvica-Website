using System.Collections.Generic;

namespace MB.MVC.Models
{
    public class HomeViewModel
    {
        public HomeViewModel(IEnumerable<string> postPartials)
        {
            PostPartials = postPartials;
        }

        public IEnumerable<string> PostPartials { get; }
    }
}
