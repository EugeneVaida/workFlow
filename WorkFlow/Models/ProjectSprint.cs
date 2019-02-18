using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorkFlow.Models
{
    public class ProjectSprint
    {
        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        [ForeignKey("Sprint")]
        public int SprintId { get; set; }
        public Sprint Sprint { get; set; }
    }
}
