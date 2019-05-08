using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WorkFlow.Models;
using WorkFlowBusinessLogicCore.Database;

namespace WorkFlow.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManagement rm;

        private Converter converter;

        public RoleController(WorkFlowDbContext context)
        {
            rm = new RoleManagement(context);
            converter = new Converter();
        } 

        [HttpGet]
        [Route("api/GetAllRoles")]
        [AllowAnonymous]
        public JsonResult GetRoles()
        {
            var roles = rm.GetListOfAllRoles().Select(x => converter.ToRoleDto(x));
            return Json(roles);
        }


    }
}