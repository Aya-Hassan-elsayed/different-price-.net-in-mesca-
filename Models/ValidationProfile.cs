using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class ValidationProfile
    {
        public ValidationProfile()
        {
            ComplainsNews = new HashSet<ComplainsNew>();
            ComplainsReplays = new HashSet<ComplainsReplay>();
        }

        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? OrganizationAddress { get; set; }
        public string? UserJob { get; set; }
        public string? Image { get; set; }
        public long? OrganizationNameId { get; set; }
        public long? RoleIdId { get; set; }
        public int? UserId { get; set; }

        public virtual ValidationGehat? OrganizationName { get; set; }
        public virtual ValidationRole? RoleId { get; set; }
        public virtual AuthUser? User { get; set; }
        public virtual ICollection<ComplainsNew> ComplainsNews { get; set; }
        public virtual ICollection<ComplainsReplay> ComplainsReplays { get; set; }
    }
}
