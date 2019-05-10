using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkFlow.BusinessLogicCore;
using Microsoft.EntityFrameworkCore;
using WorkFlow.Models;

namespace WorkFlowBusinessLogicCore.Database
{
    public class RoleManagement : DatabaseManagement
    {

        public RoleManagement(WorkFlowDbContext db) : base(db) { }

        public List<string> GetListOfUserRolesNames(int userId)
        {            
            return this.Db.UserRoles.Include(x => x.Role).Where(x => x.UserId == userId).Select(x => x.Role.Name).ToList();
        }

        public List<Role> GetListOfRolesForUser(int userId)
        {
            return this.Db.UserRoles.Include(x => x.Role).Where(x => x.UserId.Equals(userId)).Select(x => x.Role).ToList();
        }

        public List<string> GetListOfAllRolesNames()
        {
            return this.Db.Roles.Select(x => x.Name).ToList();
        }

        public List<Role> GetListOfAllRoles()
        {
            return this.Db.Roles.ToList();
        }

        public void Create(string name)
        {
            Role role = new Role();
            Create(role);
        }

        public void Create(Role role)
        {
            this.Db.Roles.Add(role);
            this.Db.SaveChanges();
        }

        
    }
}
