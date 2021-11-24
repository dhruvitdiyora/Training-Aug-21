using System;
using System.Collections.Generic;

#nullable disable

namespace Day11.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Sales = new HashSet<Sale>();
        }

        public int EmployeeId { get; set; }
        public string EmpName { get; set; }
        public string EmpLastName { get; set; }
        public string EmpType { get; set; }
        public decimal CommisionPer { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
