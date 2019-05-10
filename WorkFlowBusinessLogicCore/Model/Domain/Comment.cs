using System;
using System.Collections.Generic;
using System.Text;
using WorkFlow.Models;

namespace WorkFlowBusinessLogicCore.Model.Domain
{
    public class Comment
    {
        public int Id { get; set; }
        public int Rate { get; set; }
        public string Text { get; set; }

        public int? UserId { get; set; }
        public virtual User User { get; set; }
    }
}
