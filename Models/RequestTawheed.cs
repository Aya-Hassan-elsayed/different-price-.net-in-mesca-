using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class RequestTawheed
    {
        public string? Requestnumber { get; set; }
        public string? SurveyReviewStatus { get; set; }
        public string? TawheedStatus { get; set; }
        public short? Tawheed { get; set; }
        public string? Serag { get; set; }
        public int? Collected { get; set; }
        public int? Id { get; set; }
        public int? Requestid { get; set; }
        public string? NorthBorderName { get; set; }
        public string? SouthBorderName { get; set; }
        public string? EastBorderName { get; set; }
        public string? WestBorderName { get; set; }
        public float? NorthBorderLength { get; set; }
        public float? SouthBorderLength { get; set; }
        public float? EastBorderLength { get; set; }
        public float? WestBorderLength { get; set; }
        public string? Description { get; set; }
        public decimal? TotalAreaBuilding { get; set; }
        public decimal? AreaBuildings { get; set; }
        public float? AreaMnawer { get; set; }
        public float? AreaBerElselm { get; set; }
        public float? ElevatorArea { get; set; }
        public float? CorridorArea { get; set; }
        public string? Streetname { get; set; }
        public string? PropertyNumber { get; set; }
    }
}
