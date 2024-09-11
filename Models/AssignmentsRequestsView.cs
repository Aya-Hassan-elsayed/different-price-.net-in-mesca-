using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class AssignmentsRequestsView
    {
        public int? Id { get; set; }
        public string? Requestnumber { get; set; }
        public string? Arabicfullname { get; set; }
        public int? Unittype { get; set; }
        public string? Unitname { get; set; }
        public double? Area { get; set; }
        public int? Areatype { get; set; }
        public double? Price { get; set; }
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
        public int? SurveyTeamId { get; set; }
        public DateTime? AssignmentDateTime { get; set; }
        public DateOnly? DueDate { get; set; }
        public int? CompanyId { get; set; }
        public int? Collected { get; set; }
        public int? SurveyReview { get; set; }
        public string? Confirmed { get; set; }
        public string? Companyname { get; set; }
        public string? AreaMCategory { get; set; }
        public string? AreaSCategory { get; set; }
        public double? PriceEstimated { get; set; }
        public string? AreaFCategory { get; set; }
        public string? AssignStatus { get; set; }
        public string? AssignTeamStatus { get; set; }
        public string? Cert { get; set; }
        public string? SurveyReviewStatus { get; set; }
        public int? Subunittype { get; set; }
        public string? SubunittypeArabicname { get; set; }
        public string? RefuseReason { get; set; }
        public short? PrintStatus { get; set; }
        public int? Certt { get; set; }
        public int? SendReview { get; set; }
        public string? AttachLayout { get; set; }
        public string? Certtt { get; set; }
        public DateOnly? Tofedex { get; set; }
        public DateOnly? AcceptedDate { get; set; }
        public string? Areatypetext { get; set; }
        public string? CollectStatus { get; set; }
        public int? Secid { get; set; }
    }
}
