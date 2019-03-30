using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkFlow.Models
{
    public class Sprint
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Priority { get; set; }
        public bool isDone { get; set; }
        
        public ICollection<SprintUser> SprintUsers { get; set; }
        public virtual ICollection<ProjectSprint> ProjectSprints { get; set; }
    }
}
