using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class Complain
    {
        public long? NewComplainId { get; set; }
        public string? Requestnumber { get; set; }
        public DateOnly? NewComplainAddeddate { get; set; }
        public string? NewComplainPhone { get; set; }
        public string? NewComplainType { get; set; }
        public string? NewComplain { get; set; }
        public long? ReplayId { get; set; }
        public string? ReplayText { get; set; }
        public DateOnly? ReplayDate { get; set; }
        public long? ReplayUserId { get; set; }
    }
}
