using System;
using GBT.Web.Core.Model.LibraryItems;

namespace GBT.Web.Core.Bases
{
    public abstract class User : Identity
    {
        public string Firstname { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public Image Avatar { get; set; }
        public long AvatarId { get; set; }
    }
}
