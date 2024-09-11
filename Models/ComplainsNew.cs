using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class ComplainsNew
    {
        public ComplainsNew()
        {
            ComplainsReplays = new HashSet<ComplainsReplay>();
        }

        public long Id { get; set; }
        public string? Requestnumber { get; set; }
        public DateOnly? Addeddate { get; set; }
        public string? Phone { get; set; }
        public string? Complainttype { get; set; }
        public string? Complaint { get; set; }
        public long? ProblemUser { get; set; }

        public virtual ValidationProfile? ProblemUserNavigation { get; set; }
        public virtual ICollection<ComplainsReplay> ComplainsReplays { get; set; }
    }
}
