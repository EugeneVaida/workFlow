using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkFlow.BusinessLogic;
using WorkFlow.Models;
using WorkFlow.Models.Dtos;
using WorkFlowBusinessLogic;
using WorkFlowBusinessLogic.Database;

namespace WorkFlow.Controllers
{    
    public class ProjectsController : Controller
    {
        private readonly ProjectManagement pm;
        private Converter converter;
        public ProjectsController(WorkFlowDbContext context)
        {
            pm = new ProjectManagement(context);
            converter = new Converter();
        }

        [HttpGet]
        [Route("api/GetAllProjects")]
        [AllowAnonymous]
        public JsonResult GetProjects()
        {
            var projects = pm.GetAllProjects().Select(x => converter.ToProjectDto(x));
            return Json(projects);
        }

        [HttpPost]
        [Route("api/CreateProject")]
        [AllowAnonymous]
        public IActionResult CreateProject([FromBody] ProjectDto projectD)
        {
            var project = converter.ToProject(projectD);
            pm.CreateProject(project);

            return Ok(project);
        }

        [HttpDelete]
        [Route("api/DeleteProject/{id}")]
        [AllowAnonymous]
        public IActionResult DeleteProject(int Id)
        {
            var result = pm.DeleteProject(Id);
            return Ok(result);
        }

        [HttpPut]
        [Route("api/UpdateProject/{id}")]
        [AllowAnonymous]
        public IActionResult UpdateProject(int id, [FromBody] ProjectDto projectD)
        {
            var project = converter.ToProject(projectD);
            pm.UpdateProject(id, project);
            return Ok(project);
        }

    }
}