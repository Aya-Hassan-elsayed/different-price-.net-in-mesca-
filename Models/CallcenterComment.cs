using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class CallcenterComment
    {
        public int Id { get; set; }
        public string? Comment { get; set; }
        public DateTime? CommentTime { get; set; }
        public string? Requestnumber { get; set; }
    }
}
