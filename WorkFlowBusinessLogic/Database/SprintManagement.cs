using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlow.Models;
using WorkFlowBusinessLogic.Database;

namespace WorkFlow.BusinessLogic
{
    public class SprintManagement : DatabaseManagement
    {
        public SprintManagement(WorkFlowDbContext db) : base(db) { }

        public List<Sprint> GetAllSprints()
        {
            return this.Db.Sprints.Include(x => x.ProjectSprints).ThenInclude(x => x.Project).ToList();
        }

        public List<Project> GetProjectsForUser(int userId)
        {
            return this.Db.Users.Where(x => x.Id == userId).FirstOrDefault().ProjectUsers.Select(x => x.Project).ToList();
        }

        public Sprint GetSprintById(int id)
        {
            return this.Db.Sprints.Where(x => x.Id == id).FirstOrDefault();
        }

        public Sprint DeleteSprint(int id)
        {
            var sprint = this.Db.Sprints.Where(x => x.Id == id).FirstOrDefault();
            this.Db.Remove(sprint);
            this.Db.SaveChanges();
            return sprint;
        }

        public void CreateSprint(Sprint sprint)
        {
            this.Db.Sprints.Add(sprint);
            this.Db.SaveChanges();
        }

        public void UpdateSprint(int id, Sprint sprint)
        {
            var item = this.Db.Sprints.Where(x => x.Id == id).FirstOrDefault();

            item.Name = sprint.Name;
            item.Description = sprint.Description;
            item.StartDate = sprint.StartDate;
            item.EndDate = sprint.EndDate;
            item.Priority = sprint.Priority;

            this.Db.SaveChanges();
        }


    }
}
