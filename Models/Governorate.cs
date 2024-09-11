using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class Governorate
    {
        public int Id { get; set; }
        public string? Englishname { get; set; }
        public string? Arabicname { get; set; }
        public string? Addeddate { get; set; }
        public string? Modifieddate { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public int? Crewtransfercost { get; set; }
    }
}
