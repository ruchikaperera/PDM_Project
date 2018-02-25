using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HospitalManagement.Modules.Staffmanagement.Models;
using HospitalManagement.Modules.PatientManagement.Models;

namespace HospitalManagement.Models
{
    public class HospitalManagementContext : DbContext
    {
        public HospitalManagementContext (DbContextOptions<HospitalManagementContext> options)
            : base(options)
        {
        }

        public DbSet<HospitalManagement.Modules.Staffmanagement.Models.Users> Users { get; set; }

        public DbSet<HospitalManagement.Modules.PatientManagement.Models.Patient> Patient { get; set; }
    }
}
