using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class CompanyGov
    {
        public int Id { get; set; }
        public int? GovId { get; set; }
        public int? CompanyId { get; set; }
        public int Regionid { get; set; }
    }
}
