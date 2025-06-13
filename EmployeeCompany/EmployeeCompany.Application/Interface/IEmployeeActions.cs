using EmployeeCompany.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCompany.Application.Interface
{
    public interface IEmployeeActions
    {
        public Task<CompanyDTO> AddemployeeToList();

        public Task<CompanyDTO> FetchEmployeeList();
    }
}
