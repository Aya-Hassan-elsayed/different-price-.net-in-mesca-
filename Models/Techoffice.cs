using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class Techoffice
    {
        public int? CompanyId { get; set; }
        public string? Companyname { get; set; }
        public long? Total { get; set; }
        public long? Collected { get; set; }
        public long? Notcollected { get; set; }
        public long? Taazer { get; set; }
        public long? Accept { get; set; }
        public decimal? Refused { get; set; }
        public long? Acceptandnotprint { get; set; }
        public long? Print { get; set; }
        public long? Shipped { get; set; }
        public long? Notshipped { get; set; }
        public long? Reviewsrequest { get; set; }
        public decimal? Office { get; set; }
        public decimal? Precentage { get; set; }
        public decimal? OfficeRefused { get; set; }
        public long? Countrequestpricedifferences { get; set; }
        public long? Countshippingorders { get; set; }
        public string? Status { get; set; }
    }
}
