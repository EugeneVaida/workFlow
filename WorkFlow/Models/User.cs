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

        public int? RoleId { get; set; }
        public virtual Role Role { get; set; }

        public int? CompanyId { get; set; }
        public virtual Company Company { get; set; }

        //public ICollection<Project> Projects { get; set; }
        //public ICollection<Sprint> Sprints { get; set; }
        public ICollection<Notification> Notofications { get; set; }
        public ICollection<LogHistory> LogHistories { get; set; }
        public ICollection<SearchHistory> SearchHistories { get; set; }

    }
}
