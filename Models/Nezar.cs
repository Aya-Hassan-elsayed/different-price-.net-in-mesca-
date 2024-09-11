using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class Nezar
    {
        public int? IdShippingorder { get; set; }
        public int? Requestid { get; set; }
        public string? Requestnumber { get; set; }
        public string? Name { get; set; }
        public int? CompanyId { get; set; }
        public DateTime? Addeddate { get; set; }
        public string? Paidstatus { get; set; }
        public double? Numberofcopies { get; set; }
        public double? Extracopiesprice { get; set; }
        public int? Orderstatus { get; set; }
        public string? Editcertificateinformation { get; set; }
        public string? EditStatus { get; set; }
        public string? Companyname { get; set; }
        public string? Comment { get; set; }
        public DateTime? CommentTime { get; set; }
        public int? Status { get; set; }
        public string? Statuss { get; set; }
        public DateOnly? StatusDate { get; set; }
        public long? PrintStatus { get; set; }
        public string? PrintStatuss { get; set; }
        public DateOnly? PrintDate { get; set; }
        public long? Recert { get; set; }
        public string? Recertt { get; set; }
        public DateOnly? Tofedex { get; set; }
        public string? Unittype { get; set; }
        public char? OverlapStatus { get; set; }
        public string? OverlapStatuss { get; set; }
        public long? RequestCount { get; set; }
    }
}
