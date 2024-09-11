using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class CollectingView
    {
        public int? Id { get; set; }
        public string? Requestnumber { get; set; }
        public string? Arabicfullname { get; set; }
        public int? Unittype { get; set; }
        public int? Subunittype { get; set; }
        public double? Subunittypearea { get; set; }
        public string? Unitname { get; set; }
        public double? Area { get; set; }
        public long? Totaaaaaaaaaaaaaaaal { get; set; }
        public double? Price { get; set; }
        public int? Cert { get; set; }
        public long? DeleveringCert { get; set; }
        public int? ComType { get; set; }
        public double? PriceComp { get; set; }
        public double? PriceEdge { get; set; }
        public double? PriceMsd { get; set; }
        public double? PriceCompReceivable { get; set; }
        public double? PriceEdgeReceivable { get; set; }
        public double? PriceMsdReceivable { get; set; }
        public double? PriceReceivable { get; set; }
        public DateTime? Addeddate { get; set; }
        public string? Gov { get; set; }
        public int? SurveyTeamId { get; set; }
        public DateOnly? DueDate { get; set; }
        public int? CompanyId { get; set; }
        public int? Collected { get; set; }
        public int? SurveyReview { get; set; }
        public long? AcceptedRequest { get; set; }
        public long? ReviewRequest { get; set; }
        public long? UploadedCert { get; set; }
        public long? NotUploadedCert { get; set; }
        public long? CannotUploadedCert { get; set; }
        public DateOnly? Tofedex { get; set; }
        public string? Companyname { get; set; }
    }
}
