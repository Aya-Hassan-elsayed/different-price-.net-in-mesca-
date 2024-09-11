using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class InquiryreqeustsUpdated
    {
        public int Id { get; set; }
        public string? Requestnumber { get; set; }
        public string? LandNo { get; set; }
        public string? TankNo { get; set; }
        public string? Attachment { get; set; }
        public string? UserCreated { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UserUpdated { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? Status { get; set; }
        public string? Notes { get; set; }
        public string? AcceptanceStatus { get; set; }
        public string? EstmaraNo { get; set; }
        public string? SegalType { get; set; }
        public string? Note { get; set; }
    }
}
