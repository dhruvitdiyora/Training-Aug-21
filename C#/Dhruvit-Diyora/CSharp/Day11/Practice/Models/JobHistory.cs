using System;
using System.Collections.Generic;

#nullable disable

namespace Day11.Models
{
    public partial class JobHistory
    {
        public int EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int JobId { get; set; }
        public int? DepartmentId { get; set; }
    }
}
