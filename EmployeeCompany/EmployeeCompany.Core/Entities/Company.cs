using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCompany.Core.Entities
{
    public class Company
    {
        public Guid Id { get; set; }
        public Guid? EmployeeId { get; set; }
        public string CompanyName { get; set; }= string.Empty;

        
        public string City { get; set; } = string.Empty;


        public Employee Employee { get; set; }

    }
}
