using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class Paymenttrasnsaction
    {
        public int Id { get; set; }
        public string? Merchantrefnum { get; set; }
        public double? Price { get; set; }
        public double? Paymentamount { get; set; }
        public double? Fawryfees { get; set; }
        public int? Paymentmethod { get; set; }
        public int? Orderstatus { get; set; }
        public string? Referencenumber { get; set; }
        public DateTime? Paymenttime { get; set; }
        public string? Statuscode { get; set; }
        public string? Statusdescription { get; set; }
        public int? Requestid { get; set; }
        public string? Userid { get; set; }
        public DateTime? Addeddate { get; set; }
        public DateTime? Modifieddate { get; set; }
        public int? Transactiontype { get; set; }
        public double? Refundedamount { get; set; }
        public DateTime? Deliverydate { get; set; }
        public int? Nquiryrequestid { get; set; }
        public int? Fawryaccounttype { get; set; }
    }
}
