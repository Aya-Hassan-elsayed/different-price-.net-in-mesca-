using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class ValidationGehat
    {
        public ValidationGehat()
        {
            ValidationProfiles = new HashSet<ValidationProfile>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<ValidationProfile> ValidationProfiles { get; set; }
    }
}
