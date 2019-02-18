using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkFlow.Models
{
    public class ProjectTag
    {
        public virtual int TagId { get; set; }
        public Tag Tag { get; set; }

        public virtual int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
