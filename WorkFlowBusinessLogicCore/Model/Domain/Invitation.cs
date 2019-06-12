using System;
using System.Collections.Generic;
using System.Text;

namespace WorkFlow.Models
{
    public class Invitation
    {
        public int Id { get; set; }
        public string GUID { get; set; }

        public virtual ICollection<ProjectInvitation> ProjectInvitations { get; set; }
    }
}
