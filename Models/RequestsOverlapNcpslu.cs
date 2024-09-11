using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class RequestsOverlapNcpslu
    {
        public int? Id { get; set; }
        public string? Requestnumber { get; set; }
        public string? Overlap { get; set; }
        public char? OverlapStatus { get; set; }
        public string? OverlapStatuss { get; set; }
        public DateOnly? OverlapDate { get; set; }
        public string? NcpsluOverlap { get; set; }
        public DateOnly? NcpsluDate { get; set; }
        public char? NcpsluStatus { get; set; }
        public string? NcpsluStatuss { get; set; }
        public string? Fullname { get; set; }
        public string? Phone { get; set; }
        public string? Sec { get; set; }
        public string? Ssec { get; set; }
        public string? Gov { get; set; }
        public int? SurveyReview { get; set; }
        public char? OverlapSendStatus { get; set; }
        public string? OverlapSendStatuss { get; set; }
        public char? OverlapResponsibility { get; set; }
        public string? OverlapResponsibilityy { get; set; }
        public string? Registabilityy { get; set; }
        public string? Attach3aqd { get; set; }
        public char? Registability { get; set; }
        public string? AttachOverlap { get; set; }
    }
}
