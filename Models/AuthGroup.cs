using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class AuthGroup
    {
        public AuthGroup()
        {
            AuthGroupPermissions = new HashSet<AuthGroupPermission>();
            AuthUserGroups = new HashSet<AuthUserGroup>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<AuthGroupPermission> AuthGroupPermissions { get; set; }
        public virtual ICollection<AuthUserGroup> AuthUserGroups { get; set; }
    }
}
