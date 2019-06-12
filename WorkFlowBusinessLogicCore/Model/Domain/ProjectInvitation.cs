using System;
using System.Collections.Generic;
using System.Text;
using WorkFlow.Models;

namespace WorkFlow.Models
{
    public class ProjectInvitation
    {
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public int InvitationId { get; set; }
        public Invitation Invitation { get; set; }
    }
}
