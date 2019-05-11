using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlow.Models;
using WorkFlowBusinessLogicCore;
using WorkFlowBusinessLogicCore.Database;

namespace WorkFlow.BusinessLogicCore
{
    public class ProjectManagement : DatabaseManagement
    {
        public ProjectManagement(WorkFlowDbContext db) : base(db) { }

        public List<Project> GetAllProjects()
        {
            return this.Db.Projects.Include(x => x.ProjectSprints).ThenInclude(y => y.Sprint).Include(x => x.ProjectTags).ThenInclude(x => x.Tag).ToList();
        }

        public List<int> GetAllProjectsIdsByTag(int id)
        {
            return this.Db.ProjectTags.Where(x => x.TagId == id).Select(x => x.Project.Id).ToList();
        }

        public List<Project> GetAllProjectsByIds(List<int> ids)
        {
            List<Project> projects = new List<Project>();
            var allProjects = GetAllProjects();
            foreach (var id in ids)
            {
                projects.AddRange(allProjects.Where(x => x.Id == id));
            }
            return projects;
        }

        public List<Project> GetAllProjectsByTag(int id)
        {
            var ids = GetAllProjectsIdsByTag(id);
            return GetAllProjectsByIds(ids);            
        }

        public List<Project> GetProjectsForUser(int userId)
        {
            return this.Db.Users.Where(x => x.Id == userId).FirstOrDefault().ProjectUsers.Select(x => x.Project).ToList();
        }

        public Project GetProjectById(int id)
        {
            return this.Db.Projects.Include(x => x.ProjectSprints).ThenInclude(y => y.Sprint).Include(x => x.ProjectTags).ThenInclude(x => x.Tag).Where(x => x.Id == id).FirstOrDefault();
        }

        public Project DeleteProject(int id)
        {
            var project = this.Db.Projects.Where(x => x.Id == id).FirstOrDefault();
            this.Db.Remove(project);
            this.Db.SaveChanges();
            return project;
        }

        public void UpdateSprintsToProject(int projectId, List<int?> sprintIds)
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

        public void AddSprintsToProject(int projectId, List<int?> sprintIds)
        {
            List<ProjectSprint> updList = new List<ProjectSprint>();
            foreach (var id in sprintIds)
            {
                var projectSprint = new ProjectSprint()
                {
                    ProjectId = projectId,
                    SprintId = (int)id
                };
                updList.Add(projectSprint);
            }
            this.Db.ProjectSprint.AddRange(updList);
            this.Db.SaveChanges();
        }

        public void UpdateTagsToProject(int projectId, List<int?> tagsIds)
        {
            RemoveTagsToProject(projectId);
            AddTagsToProject(projectId, tagsIds);
        }

        public void RemoveTagsToProject(int projectId)
        {
            var projectTags = this.Db.ProjectTags.Where(x => x.ProjectId == projectId);
            this.Db.ProjectTags.RemoveRange(projectTags);
            this.Db.SaveChanges();
        }

        public void AddTagsToProject(int projectId, List<int?> tagsIds)
        {
            List<ProjectTag> updList = new List<ProjectTag>();
            foreach (var id in tagsIds)
            {
                var projectTag = new ProjectTag()
                {
                    ProjectId = projectId,
                    TagId = (int)id
                };
                updList.Add(projectTag);
            }
            this.Db.ProjectTags.AddRange(updList);
            this.Db.SaveChanges();
        }

        public void CreateProject(Project project)
        {
            this.Db.Projects.Add(project);
            this.Db.SaveChanges();            
        }

        public void CreateProjectSprintsForProject(int projectId, List<int> sprintIds)
        {
            foreach (var id in sprintIds)
            {
                ProjectSprint projectSprint = new ProjectSprint()
                {
                    ProjectId = projectId,
                    SprintId = id
                };
                this.Db.ProjectSprint.Add(projectSprint);
            }
            this.Db.SaveChanges();
        }

        public void CreateProjectTagsForProject(int projectId, List<int> tagsId)
        {
            foreach (var id in tagsId)
            {
                ProjectTag projectSprint = new ProjectTag()
                {
                    ProjectId = projectId,
                    TagId = id
                };
                this.Db.ProjectTags.Add(projectSprint);
            }
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
