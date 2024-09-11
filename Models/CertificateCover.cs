using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class CertificateCover
    {
        public long? Id { get; set; }
        public string? Requestnumber { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Shippingtype { get; set; }
        public string? Addr { get; set; }
        public string? Ssec { get; set; }
        public string? Sec { get; set; }
        public string? Gov { get; set; }
        public string? Typebefore { get; set; }
        public double? Areabefore { get; set; }
        public int? Subunittypebefore { get; set; }
        public string? Typeafter { get; set; }
        public float? Areaafter { get; set; }
        public float? Garden { get; set; }
        public decimal? MaintypeCsv { get; set; }
        public decimal? SubtypeCsv { get; set; }
        public string? Comment { get; set; }
    }
}
