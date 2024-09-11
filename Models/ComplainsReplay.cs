using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class ComplainsReplay
    {
        public long Id { get; set; }
        public string? Complaintreply { get; set; }
        public DateOnly Datereply { get; set; }
        public long? ReplayUser { get; set; }
        public long? ComplainsId { get; set; }

        public virtual ComplainsNew? Complains { get; set; }
        public virtual ValidationProfile? ReplayUserNavigation { get; set; }
    }
}
