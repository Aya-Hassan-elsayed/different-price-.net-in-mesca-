using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class FinancialViewList
    {
        public string? Requestnumber { get; set; }
        public int? Id { get; set; }
        public string? Arabicfullname { get; set; }
        public int? Unittype { get; set; }
        public int? Subunittype { get; set; }
        public double? Subunittypearea { get; set; }
        public string? Unitname { get; set; }
        public double? DiffrenePrice { get; set; }
        public int? DiffreneOrderstatus { get; set; }
        public double? Area { get; set; }
        public double? Price { get; set; }
        public double? NetPrice { get; set; }
        public int? Cert { get; set; }
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
        public DateTime? AssignmentDateTime { get; set; }
        public DateOnly? DueDate { get; set; }
        public int? CompanyId { get; set; }
        public int? Collected { get; set; }
        public int? SurveyReview { get; set; }
        public int? Confirmed { get; set; }
        public DateOnly? Tofedex { get; set; }
        public DateOnly? CretRecievedMsd { get; set; }
        public string? Companyname { get; set; }
        public string? PrintStatus { get; set; }
        public double? ContractRatio { get; set; }
        public string? AreaMCategory { get; set; }
        public string? AreaSCategory { get; set; }
        public double? PriceEstimated { get; set; }
        public string? AreaFCategory { get; set; }
        public int? RequestsAreatype { get; set; }
        public string? Areatype { get; set; }
        public string? AssignStatus { get; set; }
        public string? Slide { get; set; }
        public string? Sections { get; set; }
        public double? MainComp { get; set; }
        public double? SecondComp { get; set; }
        public string? Company42 { get; set; }
        public string? Company26 { get; set; }
    }
}
