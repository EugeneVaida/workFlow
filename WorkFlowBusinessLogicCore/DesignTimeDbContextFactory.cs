using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WorkFlowBusinessLogicCore.Database;

namespace WorkFlowBusinessLogicCore
{
    class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<WorkFlowDbContext>
    {

        public WorkFlowDbContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            var builder = new DbContextOptionsBuilder<WorkFlowDbContext>();
            builder.UseSqlServer(configuration.GetConnectionString("WorkFlowMySql"));
            return new WorkFlowDbContext(builder.Options);
        }       
        
    }
}
