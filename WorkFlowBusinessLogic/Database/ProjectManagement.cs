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

        public Project DeleteProject(int id)
        {
            var project = this.Db.Projects.Where(x => x.Id == id).FirstOrDefault();
            this.Db.Remove(project);
            this.Db.SaveChanges();
            return project;
        }

        public void CreateProject(Project project)
        {
            this.Db.Projects.Add(project);
            this.Db.SaveChanges();
        }

        public void UpdateProject(int id, Project project)
        {
            var item = this.Db.Projects.Where(x => x.Id == id).FirstOrDefault();

            item.Name = project.Name;
            item.Describtion = project.Describtion;
            item.StartDate = project.StartDate;
            item.EndDate = project.EndDate;

            this.Db.SaveChanges();
        }
    }
}
