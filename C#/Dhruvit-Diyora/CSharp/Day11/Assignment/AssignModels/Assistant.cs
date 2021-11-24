using System;
using System.Collections.Generic;

#nullable disable

namespace Day11.AssignModels
{
    public partial class Assistant
    {
        public int AssistantId { get; set; }
        public string AssistantFirstName { get; set; }
        public string AssistantLastName { get; set; }
        public int? AssistDoctorId { get; set; }
        public int? AssistDepartmentId { get; set; }
        public bool? IsActive { get; set; }

        public virtual Department AssistDepartment { get; set; }
        public virtual Doctor AssistDoctor { get; set; }
    }
}
