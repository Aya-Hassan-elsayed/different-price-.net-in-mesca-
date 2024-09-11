using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class Surveygi
    {
        public long Ids { get; set; }
        public string Seragid { get; set; } = null!;
        public DateTime? Date { get; set; }
        public string? XValidation { get; set; }
        public string? YValidation { get; set; }
        public long? Districtid { get; set; }
    }
}
