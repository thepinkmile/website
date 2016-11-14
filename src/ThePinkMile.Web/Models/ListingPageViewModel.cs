using System.Collections.Generic;

namespace ThePinkMile.Web.Models
{
    public class ListingPageViewModel<T> : StandardPageViewModel
        where T : class
    {
        public ICollection<T> Items { get; set; }

        public T SelectedItem { get; set; }

        public int CurrentPage { get; set; }

        public int CurrentMonthFilter { get; set; }

        public int CurrentYearFilter { get; set; }
    }
}
