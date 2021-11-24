using System;
using System.Collections.Generic;

#nullable disable

namespace Day11.AssignModels
{
    public partial class Prescribed
    {
        public int PrescribedId { get; set; }
        public string MedicineTimeId { get; set; }
        public DateTime PrescibedDate { get; set; }
        public int TreatmentId { get; set; }
        public bool? IsActive { get; set; }

        public virtual Treatment Treatment { get; set; }
    }
}
