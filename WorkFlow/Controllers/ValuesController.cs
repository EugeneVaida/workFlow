using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorkFlow.Models;
using WorkFlowBusinessLogic.Database;

namespace WorkFlow.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        RoleManagement rm = new RoleManagement(ConfigurationManager.ConnectionStrings["WorkFlowConnection"].ToString());

        [Authorize]
        [Route("getlogin")]
        public IActionResult GetLogin()
        {
            return Ok($"Ваш логин: {User.Identity.Name}");
        }

        [Authorize(Roles = "Admin, User, Manager")]
        [Route("getrole")]
        public IActionResult GetRole()
        {
            string result = "";
            var roleNames = ;

            foreach (string name in roleNames)
            {
                if (User.IsInRole(name))
                {
                    result += " " + name;
                }
            }

            return Ok(result);

        }

    }
}