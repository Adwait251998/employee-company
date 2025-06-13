using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCompany.Core.Entities
{
    public class Employee
    {
    
        public Guid EmployeeId { get; set; }
        public string Name { get; set; } = string .Empty;
        public string  Email { get; set; }= string .Empty;

        public string Phone { get; set; } = string.Empty;
    }
}
