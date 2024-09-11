using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class SurveyteamViewCollected
    {
        public int? Id { get; set; }
        public int? Companyid { get; set; }
        public string? MappuserId { get; set; }
        public long? EmployeeCount { get; set; }
        public long? Done { get; set; }
        public long? NotDone { get; set; }
        public long? Unable { get; set; }
    }
}
