using System;
using System.Collections.Generic;

#nullable disable

namespace Day11.AssignModels
{
    public partial class Doctor
    {
        public Doctor()
        {
            Assistants = new HashSet<Assistant>();
            Treatments = new HashSet<Treatment>();
        }

        public int DoctorId { get; set; }
        public string DoctorFirstName { get; set; }
        public string DoctorLastName { get; set; }
        public int? DocDepartmentId { get; set; }
        public bool? IsActive { get; set; }

        public virtual Department DocDepartment { get; set; }
        public virtual ICollection<Assistant> Assistants { get; set; }
        public virtual ICollection<Treatment> Treatments { get; set; }
    }
}
