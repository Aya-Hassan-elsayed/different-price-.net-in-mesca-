using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class District
    {
        public int Id { get; set; }
        public string? Englishname { get; set; }
        public string? Arabicname { get; set; }
        public int? Regionid { get; set; }
        public string? Addeddate { get; set; }
        public string? Modifieddate { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
    }
}
