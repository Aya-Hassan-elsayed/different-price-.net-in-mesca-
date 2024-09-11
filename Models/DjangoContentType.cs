using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class DjangoContentType
    {
        public DjangoContentType()
        {
            AuthPermissions = new HashSet<AuthPermission>();
            DjangoAdminLogs = new HashSet<DjangoAdminLog>();
        }

        public int Id { get; set; }
        public string AppLabel { get; set; } = null!;
        public string Model { get; set; } = null!;

        public virtual ICollection<AuthPermission> AuthPermissions { get; set; }
        public virtual ICollection<DjangoAdminLog> DjangoAdminLogs { get; set; }
    }
}
