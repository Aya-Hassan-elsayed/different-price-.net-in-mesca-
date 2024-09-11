using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class Modificationlog
    {
        public int Modificationnumber { get; set; }
        public short? Type { get; set; }
        public int? Modifiedtableid { get; set; }
        public string? Keyvalue1 { get; set; }
        public string? Keyvalue2 { get; set; }
        public string? Keyvalue3 { get; set; }
        public string? Keyvalue4 { get; set; }
        public string? Keyvalue5 { get; set; }
        public string? Keyvalue6 { get; set; }
        public string? Keyvalue7 { get; set; }
        public string? Keyvalue8 { get; set; }
        public string? Keyvalue9 { get; set; }
        public string? Keyvalue10 { get; set; }
        public int Sessionid { get; set; }
        public DateTime Modifieddate { get; set; }
    }
}
