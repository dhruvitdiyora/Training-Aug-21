using System;
using System.Collections.Generic;

#nullable disable

namespace Day11.AssignModels
{
    public partial class Medicine
    {
        public Medicine()
        {
            MedicineTimes = new HashSet<MedicineTime>();
        }

        public int MedicineId { get; set; }
        public string MedicineName { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<MedicineTime> MedicineTimes { get; set; }
    }
}
