using WorkFlowBusinessLogicCore;
using WorkFlowBusinessLogicCore.Database;

namespace WorkFlow.BusinessLogicCore
{
    public class DatabaseManagement
    {
        public DatabaseManagement(WorkFlowDbContext db)
        {
            this.Db = db;
        }
        public WorkFlowDbContext Db { get; set; }        
    }
}
