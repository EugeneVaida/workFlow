using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkFlow.BusinessLogicCore;
using WorkFlow.Models;
using WorkFlow.Models.Dtos;
using WorkFlowBusinessLogicCore.Database;

namespace WorkFlow.Controllers
{
    
    public class UserController : Controller
    {
        private Converter converter;
        private readonly UserManagement um;
        public UserController(WorkFlowDbContext context)
        {
            converter = new Converter();
            um = new UserManagement(context);
        }

        [HttpGet]
        [Route("api/GetAllUsers")]
        [AllowAnonymous]
        public JsonResult GetCompanies()
        {
            var users = um.GetAllUsers();
            return Json(users);
        }

        [HttpPost]
        [Route("api/CreateUser")]
        [AllowAnonymous]
        public IActionResult CreateUser([FromBody]UserDto userDto)
        {
            var user = converter.ToUser(userDto);
            um.CreateUser(user);

            return Ok(user);
        }

        [HttpDelete]
        [Route("api/DeleteUser/{id}")]
        [AllowAnonymous]
        public IActionResult DeleteUser(int Id)
        {
            var result = um.DeleteUser(Id);
            return Ok(result);
        }

        [HttpPut]
        [Route("api/DeleteUser/{id}")]
        [AllowAnonymous]
        public IActionResult UpdateCompany(int id, [FromBody]UserDto userD)
        {
            var user = converter.ToUser(userD);
            um.UpdateUser(id, user);
            return Ok(user);
        }
    }
}