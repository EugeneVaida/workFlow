using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorkFlow.Models;

namespace WorkFlow.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private Context db;

        public ValuesController(Context context)
        {
            db = context;
        }
                

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
            var roleNames = db.Roles.Select(x => x.Name);

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