using System.Collections.Generic;

namespace ThePinkMile.Web.Models
{
    public class MenuComponentViewModel
    {
        public MenuComponentViewModel()
        {
            Items = new HashSet<MenuComponentItemViewModel>();
        }

        public ICollection<MenuComponentItemViewModel> Items { get; set; }
    }
}
