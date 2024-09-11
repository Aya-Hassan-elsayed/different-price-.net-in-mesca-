using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class MappUser
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Fullname { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string Languagecode { get; set; } = null!;
        public short Isactivated { get; set; }
        public short Isstudioaccount { get; set; }
        public short Isactivedirectory { get; set; }
        public string? Twofactorsecret { get; set; }
        public short Istwofactorrequired { get; set; }
    }
}
