﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Day11.AssignModels
{
    public partial class Department
    {
        public Department()
        {
            Assistants = new HashSet<Assistant>();
            Doctors = new HashSet<Doctor>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Assistant> Assistants { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}
