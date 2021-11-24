using System;
using System.Collections.Generic;

#nullable disable

namespace Day11.Models
{
    public partial class Job
    {
        public int JobId { get; set; }
        public string JobTitle { get; set; }
        public decimal? MinSalary { get; set; }
        public decimal? MaxSalary { get; set; }
    }
}
