using System;
using System.Collections.Generic;

#nullable disable

namespace Day11.AssignModels
{
    public partial class Treatment
    {
        public Treatment()
        {
            Prescribeds = new HashSet<Prescribed>();
        }

        public int TreatmentId { get; set; }
        public string DiseaseName { get; set; }
        public DateTime AdmitDate { get; set; }
        public DateTime? DischargeDate { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public string AssistantId { get; set; }
        public bool? IsActive { get; set; }

        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual ICollection<Prescribed> Prescribeds { get; set; }
    }
}
