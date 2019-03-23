using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlow.Models;
using WorkFlowBusinessLogic;
using WorkFlowBusinessLogic.Database;

namespace WorkFlow.BusinessLogic
{
    public class TagManagement : DatabaseManagement
    {
        public TagManagement(WorkFlowDbContext db) : base(db) { }

        public List<Tag> GetAllTags()
        {
            return this.Db.Tags.ToList();
        }

        public List<Tag> GetTagsForProject(int projectId)
        {
            return this.Db.ProjectTags.Where(x => x.ProjectId == projectId).Select(x => x.Tag).ToList();
        }
    }
}
