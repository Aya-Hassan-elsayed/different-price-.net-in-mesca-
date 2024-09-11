using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class Nsdi
    {
        public int? Id { get; set; }
        public int? RequestId { get; set; }
        public int? SurveyTeamId { get; set; }
        public DateTime? AssignmentDateTime { get; set; }
        public DateOnly? DueDate { get; set; }
        public int? SurveyReview { get; set; }
        public int? CollectedRequest { get; set; }
        public DateTime? SurveyTime { get; set; }
        public string? SurveyReviewStatus { get; set; }
        public string? Requestnumber { get; set; }
        public double? Area { get; set; }
        public DateOnly? Addeddate { get; set; }
        public string? Unittype { get; set; }
        public int? Subunittype { get; set; }
        public double? Subunittypearea { get; set; }
        public string? Unitname { get; set; }
        public string? Collected { get; set; }
        public string? Phonenumber { get; set; }
        public string? Arabicfullname { get; set; }
        public string? FullnameOwner { get; set; }
        public string? PhoneOwner { get; set; }
        public string? Streetname { get; set; }
        public string? AddressDescription { get; set; }
        public string? Address { get; set; }
        public string? MappuserId { get; set; }
        public string? SurveyDate { get; set; }
        public string? ApartmentNo { get; set; }
        public string? LevelNo { get; set; }
        public string? NorthBorderName { get; set; }
        public string? SouthBorderName { get; set; }
        public string? EastBorderName { get; set; }
        public string? WestBorderName { get; set; }
        public float? NorthBorderLength { get; set; }
        public float? SouthBorderLength { get; set; }
        public float? EastBorderLength { get; set; }
        public float? WestBorderLength { get; set; }
        public string? Description { get; set; }
        public string? Usage { get; set; }
        public string? AttachSelimManwarName { get; set; }
        public string? AttachLandName { get; set; }
        public string? AttachMa7darName { get; set; }
        public decimal? TotalAreaBuilding { get; set; }
        public decimal? AreaBuildings { get; set; }
        public float? AreaMnawer { get; set; }
        public float? AreaBerElselm { get; set; }
        public float? AreaApartment { get; set; }
        public string? Ket3aNo { get; set; }
        public string? HodNo { get; set; }
        public int? SendReview { get; set; }
        public string? Companyname { get; set; }
        public int? CompanyId { get; set; }
        public string? AttachLayout { get; set; }
        public string? Mar { get; set; }
        public string? AfterExtraction { get; set; }
        public int? SuvSubtype { get; set; }
        public string? Subtype { get; set; }
        public int? Governorateid { get; set; }
        public int? Regionid { get; set; }
        public int? Districtid { get; set; }
        public short? PrintStatus { get; set; }
        public short? Repeatrefuse { get; set; }
        public string? Serag { get; set; }
    }
}
