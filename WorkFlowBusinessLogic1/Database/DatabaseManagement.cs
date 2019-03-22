using WorkFlowBusinessLogic;
using WorkFlowBusinessLogic.Database;

namespace WorkFlow.BusinessLogic
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
