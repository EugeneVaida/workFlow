using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkFlow.Models
{
    public class LogHistory
    {
        public int Id { get; set; }
        public DateTime LogDate { get; set; }
        public string Platform { get; set; }
        
        public int? UserId { get; set; }
        public virtual User User { get; set; }
    }
}
