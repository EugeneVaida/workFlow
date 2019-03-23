using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkFlow.BusinessLogic;
using WorkFlow.Models;
using WorkFlowBusinessLogic;
using WorkFlowBusinessLogic.Database;

namespace WorkFlow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly ProjectManagement pm;

        public ProjectsController(WorkFlowDbContext context)
        {
            pm = new ProjectManagement(context);
        }

        // GET: api/Projects
        [HttpGet]
        public List<Project> GetProjects()
        {
            return pm.GetAllProjects();
        }

        // GET: api/Projects/5
        [HttpGet("{id}")]
        public IActionResult GetProject([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var project = pm.GetProjectById(id);

            if (project == null)
            {
                return NotFound();
            }

            return Ok(project);
        }


    }
}