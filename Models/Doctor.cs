using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MVCAppSQLDemo.Models
{
    public partial class Doctor
    {
        public Doctor()
        {
            Patient = new HashSet<Patient>();
        }

        public int DoctorId { get; set; }
        public string DoctorName { get; set; }

        public virtual ICollection<Patient> Patient { get; set; }
    }
}
