﻿using System;
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
                Describtion = projectD.Describtion,
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

        public Sprint ToSprint(SprintDto sprintD)
        {
            Sprint sprint = new Sprint()
            {
                Name = sprintD.Name,
                Description = sprintD.Description,
                StartDate = sprintD.StartDate,
                EndDate = sprintD.EndDate,
                Priority = sprintD.Priority
            };
            return sprint;
        }

        public SprintDto ToSprintDto(Sprint sprint, List<Project> projects)
        {
            SprintDto sprintDto = new SprintDto()
            {
                Id = sprint.Id,
                Name = sprint.Name,
                Description = sprint.Description,
                StartDate = sprint.StartDate,
                EndDate = sprint.EndDate,
                Priority = sprint.Priority,
                Projects = projects.Select(x => ToProjectDto(x)).ToList()
            };
            return sprintDto;
        }

        public ProjectDto ToProjectDto(Project project)
        {
            ProjectDto projectDto = new ProjectDto()
            {
                Id = project.Id,
                Name = project.Name,
                Describtion = project.Describtion,
                StartDate = project.StartDate,
                EndDate = project.EndDate
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
    }
}
