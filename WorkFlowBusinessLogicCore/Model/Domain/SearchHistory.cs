using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkFlow.Models
{
    public class SearchHistory
    {
        public int Id { get; set; }
        public string SearchQuary { get; set; }

        public int? UserId { get; set; }
        public virtual User User { get; set; }
    }
}
