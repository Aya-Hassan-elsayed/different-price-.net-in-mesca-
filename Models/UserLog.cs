using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class UserLog
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? AppName { get; set; }
        public string? Process { get; set; }
        public DateTime? Time { get; set; }
        public string? ProcessId { get; set; }
        public int? IdShippingorder { get; set; }
    }
}
