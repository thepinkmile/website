namespace GBT.Web.Core.Bases
{
    public abstract class Identity
    {
        public long Id { get; set; }

        public bool Enabled { get; set; }

        public byte[] Timestamp { get; set; }
    }
}
