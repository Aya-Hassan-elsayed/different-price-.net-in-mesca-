using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class RequestsOverlap
    {
        public int Id { get; set; }
        public string Requestnumber { get; set; } = null!;
        public string? Overlap { get; set; }
        public char? OverlapStatus { get; set; }
        public DateOnly? OverlapDate { get; set; }
        public string? NcpsluOverlap { get; set; }
        public DateOnly? NcpsluDate { get; set; }
        public char? NcpsluStatus { get; set; }
        public char? OverlapSendStatus { get; set; }
        public char? OverlapResponsibility { get; set; }
        public char? Registability { get; set; }
        public string? AttachOverlap { get; set; }
        public string? Notes { get; set; }
        public string? MilOverlap { get; set; }
    }
}
