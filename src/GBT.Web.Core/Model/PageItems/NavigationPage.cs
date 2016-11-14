using GBT.Web.Core.Bases;

namespace GBT.Web.Core.Model.PageItems
{
    public class NavigationPage : Page
    {
        public Page NavigateToPage { get; set; }
        public long NavigateToPageId { get; set; }

        public new string Description => null;

        public new string FullText => null;
    }
}
