using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlowBusinessLogic;

namespace WorkFlow.BusinessLogic
{
    public class DatabaseManagement
    {
        public string ConnectionString { get; set; }
        public WorkFlowDbDataContext Db { get; set; }

        public DatabaseManagement(string connection)
        {
            this.Db = new WorkFlowDbDataContext(connection);
            this.ConnectionString = connection;
        }

        public void ReInit()
        {
            this.Db = new WorkFlowDbDataContext(this.ConnectionString);
        }
    }
}
