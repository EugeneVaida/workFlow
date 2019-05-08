using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkFlow.BusinessLogicCore;
using WorkFlow.Models;
using WorkFlow.Models.Dtos;
using WorkFlowBusinessLogicCore;
using WorkFlowBusinessLogicCore.Database;

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
            var projects = pm.GetAllProjects().
                Select(x => converter.ToProjectDto(x, x.ProjectSprints.Select(y => y.Sprint).ToList(),
                x.ProjectTags.Select(t => t.Tag).ToList()));
            return Json(projects);
        }

        [HttpGet]
        [Route("api/GetProjectsByTag/{id}")]
        [AllowAnonymous]
        public JsonResult GetProjectsByTag(int id)
        {
            var projects = pm.GetAllProjectsByTag(id).Select(x => converter.ToProjectDto(x, x.ProjectSprints.Select(y => y.Sprint).ToList(),
                x.ProjectTags.Select(t => t.Tag).ToList()));            

            return Json(projects);
        }

        [HttpGet]
        [Route("api/GetProjectById/{id}")]
        [AllowAnonymous]
        public JsonResult GetProjectById(int id)
        {
            var project = pm.GetProjectById(id);
            return Json(project);
        }



        [HttpPost]
        [Route("api/CreateProject")]
        [AllowAnonymous]
        public IActionResult CreateProject([FromBody] ProjectDto projectD)
        {
            var project = converter.ToProject(projectD);
            pm.CreateProject(project);
            pm.CreateProjectSprintsForProject(project.Id, projectD.Sprints.Select(x => (int)x.Id).ToList());
            pm.CreateProjectTagsForProject(project.Id, projectD.Tags.Select(x => (int)x.Id).ToList());

            return Ok(projectD);
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
            pm.UpdateSprintsToProject(id, projectD.Sprints.Select(x => x.Id).ToList());
            pm.UpdateTagsToProject(id, projectD.Tags.Select(x => x.Id).ToList());
            return Ok(project);
        }

    }
}