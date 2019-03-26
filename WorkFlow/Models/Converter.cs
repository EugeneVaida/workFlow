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
                Describtion = sprintD.Describtion,
                StartDate = sprintD.StartDate,
                EndDate = sprintD.EndDate,
                Priority = sprintD.Priority
            };
            return sprint;
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
