using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class Inquiryrequest
    {
        public int Id { get; set; }
        public int Orderstatus { get; set; }
        public int Inquiryrequeststatus { get; set; }
        public int Requestid { get; set; }
        public DateTime Addeddate { get; set; }
        public DateTime? Modifieddate { get; set; }
        public float? Price { get; set; }
    }
}
