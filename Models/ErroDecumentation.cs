using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class ErroDecumentation
    {
        public int Id { get; set; }
        public string? IssueTitle { get; set; }
        public string? IssueDescription { get; set; }
        public int? IssueType { get; set; }
        public DateOnly? IssueDate { get; set; }
        public string? IssueSolve { get; set; }
        public int? IssueLocation { get; set; }
        public string? Createby { get; set; }
    }
}
