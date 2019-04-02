using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlow.Models.Dtos;

namespace WorkFlow.Models
{
    public class Converter
    {
        public Company ToCompany(CompanyDto companyD)
        {
            Company company = new Company()
            {
                Name = companyD.Name,
                Adress = companyD.Adress,
                Telephone = companyD.Telephone
            };

            return company;
        }

        public Project ToProject(ProjectDto projectD)
        {
            Project project = new Project()
            {
                Name = projectD.Name,
                Description = projectD.Description,
                StartDate = projectD.StartDate,
                EndDate = projectD.EndDate
            };
            return project;
        }

        public Tag ToTag(TagDto tagD)
        {
            Tag tag = new Tag()
            {
                Name = tagD.Name,               
            };
            return tag;
        }

        public TagDto ToTagDto(Tag tag)
        {
            TagDto tagD = new TagDto() {
                Id = tag.Id,
                Name = tag.Name
            };

            return tagD;
        }

        

        public Sprint ToSprint(SprintDto sprintD)
        {
            Sprint sprint = new Sprint()
            {
                Name = sprintD.Name,
                Description = sprintD.Description,
                StartDate = sprintD.StartDate,
                EndDate = sprintD.EndDate,
                Priority = sprintD.Priority,
                isDone = sprintD.isDone
            };
            return sprint;
        }

        public SprintDto ToSprintDto(Sprint sprint, List<Project> projects = null)
        {
            SprintDto sprintDto = new SprintDto()
            {
                Id = sprint.Id,
                Name = sprint.Name,
                Description = sprint.Description,
                StartDate = sprint.StartDate,
                EndDate = sprint.EndDate,
                Priority = sprint.Priority,
                isDone = sprint.isDone,
                Percent = GetPercents(sprint.StartDate, sprint.EndDate),
                Projects = projects == null ? new List<ProjectDto>() : projects.Select(x => ToProjectDto(x)).ToList()
            };
            return sprintDto;
        }

        public ProjectDto ToProjectDto(Project project, List<Sprint> sprints = null, List<Tag> tags = null)
        {
            ProjectDto projectDto = new ProjectDto()
            {
                Id = project.Id,
                Name = project.Name,
                Description = project.Description,
                StartDate = project.StartDate,
                EndDate = project.EndDate,
                Sprints = sprints == null ? new List<SprintDto>() : sprints.Select(x => ToSprintDto(x)).ToList(),
                Tags = tags == null ? new List<TagDto>() : tags.Select(x => ToTagDto(x)).ToList()
            };
            return projectDto;
        }

        public User ToUser(UserDto userD)
        {
            User user = new User()
            {
                FirstName = userD.FirstName,
                LastName = userD.LastName,
                Username = userD.Username,
                PasswordHash = userD.Password           
            };
            return user;
        }

        public int GetPercents(DateTime start, DateTime end)
        {
            int allDays = (end - start).Days;
            int daysFromStart = (DateTime.Now - start).Days;
            var per = Math.Round(((double)daysFromStart / allDays) * 100, 0);
            return (int)per;
        }
    }
}
