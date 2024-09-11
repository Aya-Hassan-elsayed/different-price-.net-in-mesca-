using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class Issue
    {
        public int Id { get; set; }
        public string? Requestnumber { get; set; }
        public string? Comment { get; set; }
        public DateTime? Time { get; set; }
    }
}
