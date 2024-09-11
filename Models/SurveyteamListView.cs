using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class SurveyteamListView
    {
        public int? SurveyteamsId { get; set; }
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Companyname { get; set; }
        public long? EmployeeCount { get; set; }
        public long? AssignmentsDone { get; set; }
        public long? AssignmentsRemain { get; set; }
        public long? AssignmentsNotDone { get; set; }
    }
}
