using System;
using System.Collections.Generic;

#nullable disable

namespace Day11.AssignModels
{
    public partial class Patient
    {
        public Patient()
        {
            Treatments = new HashSet<Treatment>();
        }

        public int PatientId { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public DateTime Dob { get; set; }
        public int MobileNo { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Treatment> Treatments { get; set; }
    }
}
