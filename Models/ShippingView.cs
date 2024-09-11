using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class ShippingView
    {
        public int? Id { get; set; }
        public string? Requestnumber { get; set; }
        public string? Arabicfullname { get; set; }
        public int? Unittype { get; set; }
        public string? Unitname { get; set; }
        public double? Area { get; set; }
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
        public string? Description { get; set; }
        public string? Governorate { get; set; }
        public string? Region { get; set; }
        public string? District { get; set; }
        public string? Shipaddr { get; set; }
        public string? Telephonenumber { get; set; }
        public DateTime? AssignmentDateTime { get; set; }
        public DateOnly? DueDate { get; set; }
        public int? CompanyId { get; set; }
        public int? Collected { get; set; }
        public DateOnly? Tofedex { get; set; }
        public DateOnly? CretRecievedMsd { get; set; }
        public int? SurveyReview { get; set; }
        public string? Companyname { get; set; }
        public string? Cert { get; set; }
        public string? SurveyReviewStatus { get; set; }
        public int? RequestsAreatype { get; set; }
        public string? Areatype { get; set; }
    }
}
