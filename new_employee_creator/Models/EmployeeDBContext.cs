using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace new_employee_creator.Models
{
    public class EmployeeDBContext:DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) : base(options)
        {

        }
        public DbSet<ECandidate> ECandidates { get; set; }
    }
}
