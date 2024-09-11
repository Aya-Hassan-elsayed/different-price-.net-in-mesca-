using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class AssignmentsRequestsViewDash
    {
        public int? Id { get; set; }
        public string? Requestnumber { get; set; }
        public string? Arabicfullname { get; set; }
        public int? Unittype { get; set; }
        public string? Unitname { get; set; }
        public double? Area { get; set; }
        public double? Price { get; set; }
        public double? PriceComp { get; set; }
        public double? PriceEdge { get; set; }
        public double? PriceMsd { get; set; }
        public DateTime? Addeddate { get; set; }
        public string? Sec { get; set; }
        public string? Ssec { get; set; }
        public string? Gov { get; set; }
        public int? GovCode { get; set; }
        public string? PropertyNumber { get; set; }
        public string? FloorNumber { get; set; }
        public string? Streetname { get; set; }
        public string? ApartmentNumber { get; set; }
        public string? UniqueMark { get; set; }
        public string? Telephonenumber { get; set; }
        public DateOnly? DueDate { get; set; }
        public int? CompanyId { get; set; }
        public int? Collected { get; set; }
        public int? Confirmed { get; set; }
        public string? Companyname { get; set; }
        public int? Cert { get; set; }
        public string? AreaMCategory { get; set; }
        public string? AreaSCategory { get; set; }
        public double? PriceEstimated { get; set; }
        public string? AreaFCategory { get; set; }
        public string? AssignStatus { get; set; }
    }
}
