using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class ZpayShahin
    {
        public long? Referencenumb { get; set; }
        public string? Typetext { get; set; }
        public string? Unittype { get; set; }
        public double? Price { get; set; }
        public string? Requestnumber { get; set; }
        public string? Paytime { get; set; }
        public DateOnly? Tofedex { get; set; }
        public int? Cert { get; set; }
        public int? Fin { get; set; }
        public DateOnly? FinDate { get; set; }
    }
}
