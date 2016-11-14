namespace GBT.Web.Core.Bases
{
    public abstract class Relationship<TParent, TChild>
        where TParent : Identity
        where TChild : Identity
    {
        public TParent Parent { get; set; }
        public long ParentId { get; set; }

        public TChild Child { get; set; }
        public long ChildId { get; set; }
    }
}
