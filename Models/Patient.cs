using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MVCAppSQLDemo.Models
{
    public partial class Patient
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public int? DoctorId { get; set; }

        public virtual Doctor Doctor { get; set; }
    }
}
