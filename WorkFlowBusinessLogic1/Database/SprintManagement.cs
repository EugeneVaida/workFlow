using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlowBusinessLogic.Database;

namespace WorkFlow.BusinessLogic
{
    public class SprintManagement : DatabaseManagement
    {
        public SprintManagement(WorkFlowDbContext db) : base(db) { }
    }
}
