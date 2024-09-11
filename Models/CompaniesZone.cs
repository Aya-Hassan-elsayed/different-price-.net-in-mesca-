using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class CompaniesZone
    {
        public int? Id { get; set; }
        public int? GovId { get; set; }
        public int? CompanyId { get; set; }
        public int? Regionid { get; set; }
        public string? Sec { get; set; }
        public string? Gov { get; set; }
        public string? Name { get; set; }
    }
}
