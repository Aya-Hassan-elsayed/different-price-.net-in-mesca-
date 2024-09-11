using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class SurveyteamRegion
    {
        public int Id { get; set; }
        public int? TeamId { get; set; }
        public int? RegionId { get; set; }
        public int? GovId { get; set; }
    }
}
