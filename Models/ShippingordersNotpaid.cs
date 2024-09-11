using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class ShippingordersNotpaid
    {
        public long Id { get; set; }
        public string? Requestnumber { get; set; }
        public string? Createdby { get; set; }
        public DateOnly? Createddate { get; set; }
        public string? Creatednotes { get; set; }
        public int? PrintStatus { get; set; }
        public DateOnly? PrintDate { get; set; }
        public string? Editcertificateinformation { get; set; }
        public int? PhoneNotPaid { get; set; }
        public string? StatusNotPaid { get; set; }
        public string? SubStautsNotPaid { get; set; }
        public string? Con1 { get; set; }
        public string? RecertNotPaid { get; set; }
        public DateOnly? TofidexNotPaid { get; set; }
    }
}
