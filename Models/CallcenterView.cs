using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class CallcenterView
    {
        public int? Id { get; set; }
        public int? RequestId { get; set; }
        public string? Requestnumber { get; set; }
        public int? Confirmed { get; set; }
        public string? RequestStatus { get; set; }
        public DateOnly? Shippingdate { get; set; }
        public DateTime? CallcenterConfirmTime { get; set; }
        public string? LogUser { get; set; }
        public DateTime? LogTime { get; set; }
        public string? Arabicfullname { get; set; }
        public string? Telephonenumber { get; set; }
        public int? Unittype { get; set; }
        public string? Unitname { get; set; }
        public double? Area { get; set; }
        public string? Sec { get; set; }
        public string? Ssec { get; set; }
        public string? Gov { get; set; }
        public string? PropertyNumber { get; set; }
        public string? FloorNumber { get; set; }
        public string? Streetname { get; set; }
        public string? ApartmentNumber { get; set; }
        public string? UniqueMark { get; set; }
        public DateOnly? DueDate { get; set; }
        public string? Session { get; set; }
        public int? SurveyTeamId { get; set; }
        public int? Regionid { get; set; }
        public int? Companyid { get; set; }
        public string? Companyname { get; set; }
        public string? Adress { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public DateTime? CommentTime { get; set; }
        public string? Comment { get; set; }
        public DateTime? ComplaintTime { get; set; }
        public string? Complaint { get; set; }
        public string? ComplaintType { get; set; }
        public string? RefuseReason { get; set; }
    }
}
