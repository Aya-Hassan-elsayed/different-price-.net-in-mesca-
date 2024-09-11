using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class RequestTrip
    {
        public int? Id { get; set; }
        public string? Requestnumber { get; set; }
        public string? Name { get; set; }
        public string? Companyname { get; set; }
        public DateTime? Addeddate { get; set; }
        public DateTime? Modifieddate { get; set; }
        public DateTime? Paymenttime { get; set; }
        public DateTime? AssignmentDateTime { get; set; }
        public DateOnly? DueDate { get; set; }
        public DateOnly? VisitDate { get; set; }
        public DateOnly? AcceptedDate { get; set; }
        public DateOnly? PrintDate { get; set; }
        public DateOnly? Tofedex { get; set; }
        public string? Shippstatus { get; set; }
    }
}
