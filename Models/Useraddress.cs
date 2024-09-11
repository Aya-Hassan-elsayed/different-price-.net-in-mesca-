using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class Useraddress
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public int? Districtid { get; set; }
        public int? Userprofileid { get; set; }
        public DateTime? Addeddate { get; set; }
        public DateTime? Modifieddate { get; set; }
        public int? Regionid { get; set; }
    }
}
