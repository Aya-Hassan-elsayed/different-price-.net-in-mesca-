using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class EditAddressesUpdated
    {
        public int? Id { get; set; }
        public string? Requestnumber { get; set; }
        public int? Requestid { get; set; }
        public int? Regionid { get; set; }
        public string? Sec { get; set; }
        public int? Districtid { get; set; }
        public string? Ssec { get; set; }
        public string? Gov { get; set; }
        public string? FloorNumber { get; set; }
        public string? ApartmentNumber { get; set; }
        public string? Streetname { get; set; }
        public int? Governorateid { get; set; }
        public int? SurveyReview { get; set; }
        public int? ReviewAfterExtraction { get; set; }
        public int? CompanyId { get; set; }
        public string? AfterExtraction { get; set; }
        public string? SurveyReviewStatus { get; set; }
        public string? Companyname { get; set; }
        public DateOnly? DueDate { get; set; }
        public DateTime? Addeddate { get; set; }
    }
}
