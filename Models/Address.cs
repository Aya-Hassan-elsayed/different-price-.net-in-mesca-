using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class Address
    {
        public int Id { get; set; }
        public int? FloorNumber { get; set; }
        public string? ApartmentNumber { get; set; }
        public string? Streetname { get; set; }
        public string? UniqueMark { get; set; }
        public string? Description { get; set; }
        public int? Districtid { get; set; }
        public int? Requestid { get; set; }
        public DateTime? Addeddate { get; set; }
        public DateTime? Modifieddate { get; set; }
        public int? Regionid { get; set; }
        public string? PropertyNumber { get; set; }
        public string? Floornumbertext { get; set; }
        public string? Partnumber { get; set; }
        public string? Sinknumber { get; set; }
        public string? Easternborder { get; set; }
        public string? Easternborderlength { get; set; }
        public string? Maritimeborder { get; set; }
        public string? Maritimeborderlength { get; set; }
        public string? Tribalborder { get; set; }
        public string? Tribalborderlength { get; set; }
        public string? Westernborder { get; set; }
        public string? Westernborderlength { get; set; }
    }
}
