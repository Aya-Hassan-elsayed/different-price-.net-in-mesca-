using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class RequestsExtrainfo
    {
        public long Id { get; set; }
        public string Requestnumber { get; set; } = null!;
        public string? Fullname { get; set; }
        public string? Phone { get; set; }
        public DateOnly? DateTasgel { get; set; }
        public DateOnly? DateShahr { get; set; }
        public string? RequestNo { get; set; }
        public string? RegistrationNo { get; set; }
        public string? Images { get; set; }
        public string? Validuser { get; set; }
        public DateTime? Validdate { get; set; }
    }
}
