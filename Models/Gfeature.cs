using System;
using System.Collections.Generic;
using NpgsqlTypes;

namespace Zezoprice.Models
{
    public partial class Gfeature
    {
        public NpgsqlTid? Ctid { get; set; }
        public string? Featurename { get; set; }
        public int? Geometrytype { get; set; }
        public string? Primarygeometryfieldname { get; set; }
        public string? Featuredescription { get; set; }
    }
}
