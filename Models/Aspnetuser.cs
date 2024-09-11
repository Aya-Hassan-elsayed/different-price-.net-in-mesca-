using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class Aspnetuser
    {
        public string Id { get; set; } = null!;
        public string Arabicfullname { get; set; } = null!;
        public DateTime Addeddate { get; set; }
        public DateTime? Modifieddate { get; set; }
        public int? Addressid { get; set; }
        public string? Phonenumber { get; set; }
    }
}
