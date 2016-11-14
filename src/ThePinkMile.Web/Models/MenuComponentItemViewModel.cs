namespace ThePinkMile.Web.Models
{
    public class MenuComponentItemViewModel
    {
        public string DisplayName { get; set; }

        public string Link { get; set; }

        public bool IsActive { get; set; } = false;

        public string ChildNavigation { get; set; }
    }
}
