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
        private readonly RoleManagement rm;
        public UserController(WorkFlowDbContext context)
        {
            converter = new Converter();
            um = new UserManagement(context);
            rm = new RoleManagement(context);
        }

        [HttpGet]
        [Route("api/GetAllUsers")]
        [AllowAnonymous]
        public JsonResult GetAllUsers()
        {
            var users = um.GetAllUsers().Select(x => converter.ToUserDto(x, rm.GetListOfRolesForUser(x.Id)));
            return Json(users);
        }

        [HttpPost]
        [Route("api/CreateUser")]
        [AllowAnonymous]
        public IActionResult CreateUser([FromBody]UserDto userDto)
        {
            var user = converter.ToUser(userDto);
            int userId = um.CreateUser(user);
            um.AddRolesToUser(userId, userDto.Roles.Select(x => x.Id).ToList());          

            return Ok(userDto);
        }

        [HttpDelete]
        [Route("api/DeleteUser/{id}")]
        [AllowAnonymous]
        public IActionResult DeleteUser(int Id)
        {
            var result = um.DeleteUser(Id);
            //ToDo deleting userRoles to deleted user
            return Ok(result);
        }

        [HttpPut]
        [Route("api/UpdateUser/{id}")]
        [AllowAnonymous]
        public IActionResult UpdateUser(int id, [FromBody]UserDto userD)
        {
            var user = converter.ToUser(userD);
            um.UpdateRolesToUser(id, userD.Roles.Select(x => x.Id).ToList());
            um.UpdateUser(id, user);
            return Ok(user);
        }
    }
}