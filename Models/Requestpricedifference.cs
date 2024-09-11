using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class Requestpricedifference
    {
        public int Id { get; set; }
        public double? Price { get; set; }
        public int? Requestid { get; set; }
        public DateTime? Addeddate { get; set; }
        public DateTime? Modifieddate { get; set; }
        public int? Orderstatus { get; set; }
        public double? Areadifference { get; set; }
        public string? Description { get; set; }
        public int? Requestareadifferencestatus { get; set; }
        public double? Subunitareadifference { get; set; }
    }
}
