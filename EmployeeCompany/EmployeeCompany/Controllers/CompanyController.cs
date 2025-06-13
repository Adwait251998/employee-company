using EmployeeCompany.Core.DTOs;
using EmployeeCompany.Core.Entities;
using EmployeeCompany.Infastructure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCompany.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : Controller
    {
        private readonly CompanyActions _company;
        public CompanyController(CompanyActions company) { 
        _company = company;
        }

        [HttpPost("AddCompany")]
        public async Task<IActionResult> AddCompany([FromBody] CompanyDTO company)
        {
            await _company.AddCompanyToList(company);
            return Ok(company);
        }

    }
}
