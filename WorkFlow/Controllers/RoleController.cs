using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorkFlow.Models;

namespace WorkFlow.Controllers
{
    public class RoleController : Controller
    {
        private Context db;

        public RoleController(Context context)
        {
            db = context;
        }

        [HttpGet]
        [Route("api/GetAllRoles")]
        [AllowAnonymous]
        public JsonResult GetRoles()
        {
            var roles = db.Roles
                .Select(x => new { x.Id, x.Name })
                .ToList();
            return Json(roles);
        }
    }
}