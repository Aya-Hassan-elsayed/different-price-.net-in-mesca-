using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class Gpicklisttable
    {
        public string Featurename { get; set; } = null!;
        public string Fieldname { get; set; } = null!;
        public string? Picklisttablename { get; set; }
        public string? Valuefieldname { get; set; }
        public string? Descriptionfieldname { get; set; }
        public string? Filterclause { get; set; }
    }
}
