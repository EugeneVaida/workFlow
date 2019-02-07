using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WorkFlow.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [Authorize]
        [Route("getlogin")]
        public IActionResult GetLogin()
        {
            return Ok($"Ваш логин: {User.Identity.Name}");
        }

        [Authorize(Roles = "admin, user")]
        [Route("getrole")]
        public IActionResult GetRole()
        {
            if (User.IsInRole("admin"))
            {
                return Ok("Ваша роль: администратор");
            }
            else if(User.IsInRole("user"))
            {
                return Ok("Ваша роль: пользователь");
            }
            else
            {
                return Ok("Ваша роль: can`t found");
            }         
           
        }

    }
}