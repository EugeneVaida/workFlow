using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkFlow.Models.Dtos
{
    public class SprintDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Percent { get; set; }
        public int Priority { get; set; }
        public bool isDone { get; set; }

        public List<ProjectDto> Projects { get; set; }
    }
}
