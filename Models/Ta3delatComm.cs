using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class Ta3delatComm
    {
        public int Id { get; set; }
        public int? IdShippingorder { get; set; }
        public string? Requestnumber { get; set; }
        public string? Commant { get; set; }
        public DateTime? CmmantTime { get; set; }
        public string? Commpany { get; set; }
        public string? UserName { get; set; }
    }
}
