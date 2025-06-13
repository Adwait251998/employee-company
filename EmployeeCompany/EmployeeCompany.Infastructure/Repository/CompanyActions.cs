using EmployeeCompany.Application.Interface;
using EmployeeCompany.Core.DTOs;
using EmployeeCompany.Core.Entities;
using EmployeeCompany.Infastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCompany.Infastructure.Repository
{
   
    public class CompanyActions:ICompanyActions
    {
        private readonly ApplicationDbContext _context;
        public CompanyActions(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<Company> AddCompanyToList(CompanyDTO company)
        {
            var companyId = Guid.NewGuid();
            Company company1 = new Company();
            company1.Id = companyId;
            company1.EmployeeId = null;
            company1.CompanyName = company.CompanyName;
            company1.City = company.City;
            try
            {

                await _context.Companies.AddAsync(company1);
                await _context.SaveChangesAsync();
                return company1;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
    }
}
