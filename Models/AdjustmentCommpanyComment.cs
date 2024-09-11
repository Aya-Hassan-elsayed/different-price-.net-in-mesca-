using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class AdjustmentCommpanyComment
    {
        public int Id { get; set; }
        public string? Comment { get; set; }
        public DateTime? CommentTime { get; set; }
        public string? Requestnumber { get; set; }
        public string? Sender { get; set; }
        public int? IdShippingorder { get; set; }
        public string? UserName { get; set; }
    }
}
