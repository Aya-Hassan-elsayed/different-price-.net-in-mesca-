using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class Gfeaturesbase
    {
        public string Featurename { get; set; } = null!;
        public int? Geometrytype { get; set; }
        public string? Primarygeometryfieldname { get; set; }
        public string? Featuredescription { get; set; }
    }
}
