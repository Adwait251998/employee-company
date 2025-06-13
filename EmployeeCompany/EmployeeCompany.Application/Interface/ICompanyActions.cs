using EmployeeCompany.Core.DTOs;
using EmployeeCompany.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCompany.Application.Interface
{
    public interface ICompanyActions
    {
        public Task<Company> AddCompanyToList(CompanyDTO company);

       // public Task<CompanyDTO> FetchCompanyList();
    }
}
