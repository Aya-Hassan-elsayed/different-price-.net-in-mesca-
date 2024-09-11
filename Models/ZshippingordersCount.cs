using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class ZshippingordersCount
    {
        public int? CompanyId { get; set; }
        public string? Companyname { get; set; }
        public long? Count { get; set; }
        public long? Sent { get; set; }
        public long? ReviewDone { get; set; }
        public long? ReviewAccept { get; set; }
        public long? Layout { get; set; }
        public long? NoImg { get; set; }
        public long? NotSend { get; set; }
        public long? Extra { get; set; }
        public long? Edits { get; set; }
    }
}
