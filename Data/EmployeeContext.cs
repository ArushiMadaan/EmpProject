using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmpProject.Models;


namespace EmpProject.Data
{
    public class EmployeeContext : DbContext
    {
        public  EmployeeContext (DbContextOptions<EmployeeContext> options)
            : base(options) { }
        public DbSet<Employee> Employee { get; set; }
    }
}
