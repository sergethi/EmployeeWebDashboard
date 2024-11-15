using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeWebDashboard.Models;

namespace EmployeeWebDashboard.Data
{
    public class EmployeeWebDashboardContext : DbContext
    {
        public EmployeeWebDashboardContext (DbContextOptions<EmployeeWebDashboardContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeWebDashboard.Models.Employee> Employee { get; set; } = default!;
    }
}
