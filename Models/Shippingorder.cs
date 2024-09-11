using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class Shippingorder
    {
        public int Id { get; set; }
        public int? Requestid { get; set; }
        public int? Shippingtype { get; set; }
        public double? Shippingprice { get; set; }
        public int? Officeid { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public int? Districtid { get; set; }
        public int? Shippingorderstatus { get; set; }
        public DateTime? Addeddate { get; set; }
        public DateTime? Modifieddate { get; set; }
        public int? Numberofcopies { get; set; }
        public int? Apartmentnumber { get; set; }
        public string? Description { get; set; }
        public int? Floornumber { get; set; }
        public int? Propertynumber { get; set; }
        public int? Regionid { get; set; }
        public string? Streetname { get; set; }
        public string? Uniquemark { get; set; }
        public double? Extracopiesprice { get; set; }
        public int? Orderstatus { get; set; }
        public string? Editcertificateinformation { get; set; }
    }
}
