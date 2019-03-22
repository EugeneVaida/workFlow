using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkFlow.BusinessLogic;

namespace WorkFlowBusinessLogic.Database
{
    public class RoleManagement : DatabaseManagement
    {

        public RoleManagement(string connection) : base(connection) { }

        public List<string> GetListOfUserRolesNames(int userId)
        {
            //var userRolesId = this.Db.UserRoles.Where(x => x.UserId == userId).Select(x => x.RoleId);
            //List<string> userRolesNames = new List<string>();
            //foreach (int roleId in userRolesId)
            //{
            //    var roleName = this.Db.Roles.Where(x => x.Id.Equals(roleId)).FirstOrDefault().Name;
            //    userRolesNames.Add(roleName);
            //}           

            return this.Db.Users.Where(x => x.Id == userId).FirstOrDefault().UserRoles.Select(x => x.Role.Name).ToList();
        }

        public List<string> GetListOfAllRolesNames()
        {
            return this.Db.Roles.Select(x => x.Name).ToList();
        }
    }
}
