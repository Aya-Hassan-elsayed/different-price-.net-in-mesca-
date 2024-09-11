using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class Surveyteam
    {
        public int Id { get; set; }
        public int? Companyid { get; set; }
        public int? Regionid { get; set; }
        public int? GovId { get; set; }
        public string? MappuserId { get; set; }
    }
}
