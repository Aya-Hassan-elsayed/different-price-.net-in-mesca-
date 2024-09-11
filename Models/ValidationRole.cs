using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class ValidationRole
    {
        public ValidationRole()
        {
            ValidationProfiles = new HashSet<ValidationProfile>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public int Code { get; set; }
        public string Description { get; set; } = null!;

        public virtual ICollection<ValidationProfile> ValidationProfiles { get; set; }
    }
}
