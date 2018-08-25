using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EmployeeBackend.Models
{
    public class EmployeeBackendContext : DbContext
    {
        public EmployeeBackendContext (DbContextOptions<EmployeeBackendContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeBackend.Models.Employee> Employee { get; set; }
    }
}
