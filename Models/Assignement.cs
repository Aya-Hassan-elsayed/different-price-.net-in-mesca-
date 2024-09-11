using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class Assignement
    {
        public int Id { get; set; }
        public int? RequestId { get; set; }
        public int? SurveyTeamId { get; set; }
        public DateTime? AssignmentDateTime { get; set; }
        public DateOnly? DueDate { get; set; }
        public int? Collected { get; set; }
        public string Requestnumber { get; set; } = null!;
        public string? Session { get; set; }
        public int? Done { get; set; }
        public int? Assigned { get; set; }
        public int? Confirmed { get; set; }
        public int? CompanyId { get; set; }
        public DateTime? CallcenterConfirmTime { get; set; }
        public string? LogUser { get; set; }
        public DateTime? LogTime { get; set; }
        public string? LogProc { get; set; }
        public int? SurveyReview { get; set; }
        public int? Cert { get; set; }
        public DateOnly? Tofedex { get; set; }
        public DateOnly? CretRecievedMsd { get; set; }
        public int? SurveyReviewMsd { get; set; }
        public int? RefuseReason { get; set; }
        public int? DifferenceAreaStatus { get; set; }
        public int? ReviewAfterExtraction { get; set; }
        public DateOnly? AcceptedDate { get; set; }
        public DateOnly? PrintDate { get; set; }
        public int? Oldunittype { get; set; }
        public int? IdShippingorder { get; set; }
        public int? Oldsubunit { get; set; }
        public int? Finabstract { get; set; }
        public DateOnly? FinDate { get; set; }
        public int? Featuretype { get; set; }
        public int? Processtype { get; set; }
        public string? Serag { get; set; }
        public short? Tawheed { get; set; }
        public short? PrintStatus { get; set; }
        public short? Repeatrefuse { get; set; }
        public char? SeragLetters { get; set; }
        public string? Com { get; set; }
    }
}
