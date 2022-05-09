using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpProject.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Dob { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
    }
}
