using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkFlow.Models
{
    public class UserRole
    {
        public virtual int UserId { get; set; }
        public User User { get; set; }

        public virtual int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
