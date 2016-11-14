using System.ComponentModel;
using GBT.Web.Core.Bases;
using GBT.Web.Core.TypeAnnotation;

namespace GBT.Web.Core.Model.PageItems
{
    [DisplayName("Standard Page"), Navigation(Controller = "Pages", Action = "Index")]
    public class StandardPage : Page
    {
    }
}
