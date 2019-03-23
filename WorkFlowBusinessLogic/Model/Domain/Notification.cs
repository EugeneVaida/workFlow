using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkFlow.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string Messsage { get; set; }
        public bool IsRead { get; set; }

        public int? UserId { get; set; }
        public virtual User User { get; set; }
    }
}
