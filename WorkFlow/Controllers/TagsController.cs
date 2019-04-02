using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkFlow.BusinessLogicCore;
using WorkFlow.Models;
using WorkFlow.Models.Dtos;
using WorkFlowBusinessLogicCore.Database;

namespace WorkFlow.Controllers
{
    public class TagsController : Controller
    {
        private readonly TagManagement tm;
        private Converter converter;
        public TagsController(WorkFlowDbContext context)
        {
            tm = new TagManagement(context);
            converter = new Converter();
        }

        [HttpGet]
        [Route("api/GetAllTags")]
        [AllowAnonymous]
        public JsonResult GetTags()
        {
            var tags = tm.GetAllTags();
            return Json(tags);
        }

        [HttpGet]
        [Route("api/GetTag/{id}")]
        [AllowAnonymous]
        public JsonResult GetTag(int id)
        {
            var tag = tm.GetAllTags().Where(x => x.Id == id).FirstOrDefault();
            return Json(tag);
        }

        [HttpPost]
        [Route("api/CreateTag")]
        [AllowAnonymous]
        public IActionResult CreateTag([FromBody] TagDto tagD)
        {
            var tag = converter.ToTag(tagD);
            tm.CreateTag(tag);

            return Ok(tag);
        }

        [HttpDelete]
        [Route("api/DeleteTag/{id}")]
        [AllowAnonymous]
        public IActionResult DeleteTag(int Id)
        {
            var result = tm.DeleteTag(Id);
            return Ok(result);
        }

        [HttpPut]
        [Route("api/UpdateTag/{id}")]
        [AllowAnonymous]
        public IActionResult UpdateTag(int id, [FromBody] TagDto tagD)
        {
            var tag = converter.ToTag(tagD);
            tm.UpdateTag(id, tag);
            return Ok(tag);
        }
    }
}