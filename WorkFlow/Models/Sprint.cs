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
        public string Describtion { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Priority { get; set; }

        //public ICollection<Project> Projects { get; set; }
        //public ICollection<User> Users { get; set; }
    }
}
