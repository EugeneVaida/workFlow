using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlow.Models;
using WorkFlowBusinessLogic;
using WorkFlowBusinessLogic.Database;

namespace WorkFlow.BusinessLogic
{
    public class ProjectManagement : DatabaseManagement
    {
        public ProjectManagement(WorkFlowDbContext db) : base(db) { }

        public List<Project> GetAllProjects()
        {
            return this.Db.Projects.ToList();
        }

        public List<Project> GetProjectsForUser(int userId)
        {
            return this.Db.Users.Where(x => x.Id == userId).FirstOrDefault().ProjectUsers.Select(x => x.Project).ToList();
        }

        public Project GetProjectById(int id)
        {
            return this.Db.Projects.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
