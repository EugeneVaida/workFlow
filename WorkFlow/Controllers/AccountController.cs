using System;
using System.Collections.Generic;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using WorkFlow.BusinessLogicCore;
using WorkFlow.Models;
using WorkFlowBusinessLogicCore.Database;

namespace WorkFlow.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManagement um;
        private readonly RoleManagement rm;
        public AccountController(WorkFlowDbContext context)
        {
            um = new UserManagement(context);
            rm = new RoleManagement(context);
        }

        [HttpPost("/token")]
        public async Task Token()
        {
            var username = Request.Form["username"];
            var password = Request.Form["password"];

            var identity = GetIdentity(username, password);
            if (identity == null)
            {
                Response.StatusCode = 400;
                await Response.WriteAsync("Invalid username or password.");
                return;
            }

            var now = DateTime.UtcNow;

            var jwt = new JwtSecurityToken(
                    issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
                    notBefore: now,
                    claims: identity.Claims,
                    expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            var userId = um.GetUserIdByUsername(identity.Name);
            var userRolesNames = rm.GetListOfUserRolesNames(userId);
            var response = new
            {
                access_token = encodedJwt,
                role = userRolesNames.ToArray(),
                username = identity.Name
            };

            Response.ContentType = "application/json";
            await Response.WriteAsync(JsonConvert.SerializeObject(response, new JsonSerializerSettings { Formatting = Formatting.Indented }));
        }


        private ClaimsIdentity GetIdentity(string username, string password)
        {
            return um.GetIdentity(username, password);
        }
    }
}