using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkFlow.BusinessLogic;
using WorkFlow.Models;
using WorkFlow.Models.Dtos;
using WorkFlowBusinessLogic.Database;
using Newtonsoft.Json;

namespace WorkFlow.Controllers
{    
    public class SprintsController : Controller
    {
        private readonly SprintManagement sm;
        private Converter converter;
        public SprintsController(WorkFlowDbContext context)
        {
            sm = new SprintManagement(context);
            converter = new Converter();
        }

        [HttpGet]
        [Route("api/GetAllSprints")]
        [AllowAnonymous]
        public JsonResult GetSprints()
        {
            var sprints = sm.GetAllSprints().Select(x => converter.ToSprintDto(x, x.ProjectSprints.Select(y => y.Project).ToList()));

            return Json(sprints);
        }

        [HttpPost]
        [Route("api/CreateSprint")]
        [AllowAnonymous]
        public IActionResult CreateSprint([FromBody] SprintDto sprintD)
        {
            var sprint = converter.ToSprint(sprintD);
            sm.CreateSprint(sprint);

            return Ok(sprint);
        }

        [HttpDelete]
        [Route("api/DeleteSprint/{id}")]
        [AllowAnonymous]
        public IActionResult DeleteSprint(int Id)
        {
            var result = sm.DeleteSprint(Id);
            return Ok(result);
        }

        [HttpPut]
        [Route("api/UpdateSprint/{id}")]
        [AllowAnonymous]
        public IActionResult UpdateSprint(int id, [FromBody] SprintDto sprintD)
        {
            var sprint = converter.ToSprint(sprintD);
            sm.UpdateSprint(id, sprint);
            return Ok(sprint);
        }
    }
}