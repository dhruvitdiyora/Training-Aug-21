using System;
using System.Collections.Generic;

#nullable disable

namespace Day11.AssignModels
{
    public partial class MedicineTime
    {
        public int MedicineTimeId { get; set; }
        public int MedicineId { get; set; }
        public string MedicineTake { get; set; }
        public bool? InMorning { get; set; }
        public bool? InNoon { get; set; }
        public bool? InNight { get; set; }

        public virtual Medicine Medicine { get; set; }
    }
}
