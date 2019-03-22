using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkFlow.Models
{
    public class ProjectUser
    {
        public virtual int ProjectId { get; set; }
        public Project Project { get; set; }

        public virtual int UserId { get; set; }
        public User User { get; set; }
    }
}
