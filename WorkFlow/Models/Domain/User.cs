using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkFlow.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public int? CompanyId { get; set; }
        public virtual Company Company { get; set; }


        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<SprintUser> SprintUsers { get; set; }
        public ICollection<ProjectUser> ProjectUsers { get; set; }
        public ICollection<Notification> Notofications { get; set; }
        public ICollection<LogHistory> LogHistories { get; set; }
        public ICollection<SearchHistory> SearchHistories { get; set; }

    }
}
