using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkFlow.BusinessLogicCore;
using WorkFlow.Models.Dtos;
using WorkFlowBusinessLogicCore.Database;

namespace WorkFlow.Controllers
{
    public class SearchController : Controller
    {
        private readonly UserManagement um;
        private readonly RoleManagement rm;
        private readonly TagManagement tm;
        private readonly ProjectManagement pm;
        private readonly SprintManagement sm;
        private readonly CompanyManagement cm;
        public SearchController(WorkFlowDbContext context)
        {
            um = new UserManagement(context);
            rm = new RoleManagement(context);
        }

        [HttpPost]
        [Route("api/Search")]
        public IActionResult CreateSprint([FromBody] string quary)
        {
            // search projects

            //search sprints

            //search companies

            //search tags           



            return Ok(quary);
        }
    }
}