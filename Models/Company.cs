using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class Company
    {
        public int Id { get; set; }
        public string Companyname { get; set; } = null!;
        public string Phonenumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int? UsernameId { get; set; }
        public string? Fax { get; set; }
        public string? BankAcc { get; set; }
        public string? CommercialRecord { get; set; }
        public string? PmName { get; set; }
        public string? Address { get; set; }
        public int? ComType { get; set; }
        public string? Userid { get; set; }
    }
}
