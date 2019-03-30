using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlow.Models;
using WorkFlowBusinessLogicCore.Database;

namespace WorkFlow.BusinessLogicCore
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

        public void CreateTag(Tag tag)
        {
            this.Db.Tags.Add(tag);
            this.Db.SaveChanges();
        }

        public Tag DeleteTag(int id)
        {
            var tag = this.Db.Tags.Where(x => x.Id == id).FirstOrDefault();
            this.Db.Tags.Remove(tag);
            this.Db.SaveChanges();
            return tag;
        }

        public void UpdateTag(int id, Tag tag)
        {
            var item = this.Db.Tags.Where(x => x.Id == id).FirstOrDefault();

            item.Name = tag.Name;
            this.Db.SaveChanges();
        }
    }
}
