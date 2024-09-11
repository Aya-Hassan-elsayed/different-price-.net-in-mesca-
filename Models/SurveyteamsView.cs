using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class SurveyteamsView
    {
        public int? Id { get; set; }
        public int? Companyid { get; set; }
        public string? Companyname { get; set; }
        public string? Region { get; set; }
        public long? Completed { get; set; }
        public long? Remain { get; set; }
    }
}
