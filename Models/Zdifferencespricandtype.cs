using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class Zdifferencespricandtype
    {
        public int? Id { get; set; }
        public string? Requestnumber { get; set; }
        public string? Arabicfullname { get; set; }
        public string? Telephonenumber { get; set; }
        public int? Unittype { get; set; }
        public int? Subunittype { get; set; }
        public double? Area { get; set; }
        public double? Subunittypearea { get; set; }
        public double? Price { get; set; }
        public DateOnly? Tofedex { get; set; }
        public string? Cert { get; set; }
        public string? Orderstatuss { get; set; }
        public int? Orderstatus { get; set; }
        public string? Referencenumber { get; set; }
        public DateOnly? Date { get; set; }
    }
}
