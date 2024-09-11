using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class ZshippingordersCountSum
    {
        public decimal? Total { get; set; }
        public decimal? Sent { get; set; }
        public decimal? ReviewDone { get; set; }
        public decimal? ReviewAccept { get; set; }
        public decimal? Layout { get; set; }
        public decimal? NoImg { get; set; }
        public decimal? NotSend { get; set; }
        public decimal? Extra { get; set; }
        public decimal? Edits { get; set; }
    }
}
