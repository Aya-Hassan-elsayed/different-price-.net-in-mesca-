using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class Statistic
    {
        public decimal? Total { get; set; }
        public decimal? Collected { get; set; }
        public decimal? Notcollected { get; set; }
        public decimal? Taazer { get; set; }
        public decimal? Accept { get; set; }
        public decimal? Reviewsrequest { get; set; }
        public decimal? Office { get; set; }
        public decimal? Shipped { get; set; }
        public decimal? Notshipped { get; set; }
        public decimal? Print { get; set; }
        public decimal? Countrequestpricedifferences { get; set; }
        public decimal? Countshippingorders { get; set; }
    }
}
