using Microsoft.EntityFrameworkCore;
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
            return this.Db.Projects.Include(x => x.ProjectSprints).ThenInclude(y => y.Sprint).ToList();
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

        public void UpdateSprintsToProject(int projectId, List<int> sprintIds)
        {
            RemoveSprintsToProject(projectId);
            AddSprintsToProject(projectId, sprintIds);
        }

        public void RemoveSprintsToProject(int projectId)
        {
            var projectSprints = this.Db.ProjectSprint.Where(x => x.ProjectId == projectId);
            this.Db.ProjectSprint.RemoveRange(projectSprints);
            this.Db.SaveChanges();
        }

        public void AddSprintsToProject(int projectId, List<int> sprintIds)
        {
            List<ProjectSprint> updList = new List<ProjectSprint>();
            foreach (var id in sprintIds)
            {
                var projectSprint = new ProjectSprint()
                {
                    ProjectId = projectId,
                    SprintId = id
                };
                updList.Add(projectSprint);
            }
            this.Db.AddRange(updList);
            this.Db.SaveChanges();
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
            item.Description = project.Description;
            item.StartDate = project.StartDate;
            item.EndDate = project.EndDate;

            this.Db.SaveChanges();
        }
    }
}
