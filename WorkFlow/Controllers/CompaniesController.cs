using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkFlow.BusinessLogic;
using WorkFlow.Models;
using WorkFlowBusinessLogic.Database;

namespace WorkFlow.Controllers
{    
    public class CompaniesController : Controller
    {
        private Converter converter;
        private readonly CompanyManagement cm;
        public CompaniesController(WorkFlowDbContext context)
        {
            converter = new Converter();
            cm = new CompanyManagement(context);
        }

        [HttpGet]
        [Route("api/GetAllCompanies")]
        [AllowAnonymous]
        public JsonResult GetCompanies()
        {
            var companies = cm.GetAllCompanies();
            return Json(companies);
        }

        [HttpPost]
        [Route("api/CreateCompany")]
        [AllowAnonymous]
        public IActionResult CreateCompany([FromBody]CompanyDto companyD)
        {
            var company = converter.ToCompany(companyD);
            cm.CreateCompany(company);
            
            return Ok(company);
        }

        [HttpDelete]
        [Route("api/DeleteCompany/{id}")]
        [AllowAnonymous]
        public IActionResult DeleteCompany( int Id)
        {            
            var result = cm.DeleteCompany(Id);
            return Ok(result);
        }

        [HttpPut]
        [Route("api/UpdateCompany/{id}")]
        [AllowAnonymous]
        public IActionResult UpdateCompany(int id, [FromBody]CompanyDto companyD)
        {
            var company = converter.ToCompany(companyD);
            cm.UpdateCompany(id,company);
            return Ok(company);
        }
    }
}