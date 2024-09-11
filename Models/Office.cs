using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class Office
    {
        public int Id { get; set; }
        public string? Longitude { get; set; }
        public string? Latitude { get; set; }
        public string? Arabicaddress { get; set; }
        public DateTime? Addeddate { get; set; }
        public DateTime? Modifieddate { get; set; }
        public string? Englishaddress { get; set; }
        public int? Regionid { get; set; }
        public string? Gpslocation { get; set; }
    }
}
