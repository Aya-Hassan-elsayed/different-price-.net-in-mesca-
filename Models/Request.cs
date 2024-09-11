using System;
using System.Collections.Generic;
using System.Collections;

namespace Zezoprice.Models
{
    public partial class Request
    {
        public int Id { get; set; }
        public int? Unittype { get; set; }
        public int? Requeststatus { get; set; }
        public double? Area { get; set; }
        public double? Price { get; set; }
        public string Requestnumber { get; set; } = null!;
        public string? Userid { get; set; }
        public DateTime? Addeddate { get; set; }
        public DateTime? Modifieddate { get; set; }
        public int? Areatype { get; set; }
        public bool? Haspricedifference { get; set; }
        public bool? Ispaid { get; set; }
        public bool? Isarchived { get; set; }
        public int? Subunittype { get; set; }
        public double? Subunittypearea { get; set; }
        public double? Crewtransfercost { get; set; }
        public string? Statusdescription { get; set; }
        public DateTime? Deliverydate { get; set; }
        public string? Buildingarea { get; set; }
        public string? Landarea { get; set; }
        public BitArray? Hasinquiryrequest { get; set; }
        public int? Assigned { get; set; }
        public double? Paymentdifferenceamount { get; set; }
        public int Paymentstatus { get; set; }
    }
}
