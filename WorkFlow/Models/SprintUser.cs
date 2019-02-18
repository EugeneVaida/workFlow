using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkFlow.Models
{
    public class SprintUser
    {
        public virtual int SprintId { get; set; }
        public Sprint Sprint { get; set; }

        public virtual int UserId { get; set; }
        public User User { get; set; }
    }
}
