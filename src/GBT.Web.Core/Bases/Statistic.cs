namespace GBT.Web.Core.Bases
{
    public abstract class Statistic
    {
        public long ParentId { get; set; }

        public long ChildId { get; set; }
    }
}
