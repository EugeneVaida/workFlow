using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WorkFlow.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<LogHistory> LogHistories { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<SearchHistory> SearchHistories { get; set; }
        public DbSet<Sprint> Sprints { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectSprint>()
                .HasKey(bc => new { bc.ProjectId, bc.SprintId });
            modelBuilder.Entity<ProjectSprint>()
                .HasOne(bc => bc.Project)
                .WithMany(b => b.ProjectSprints)
                .HasForeignKey(bc => bc.ProjectId);
            modelBuilder.Entity<ProjectSprint>()
                .HasOne(bc => bc.Sprint)
                .WithMany(c => c.ProjectSprints)
                .HasForeignKey(bc => bc.SprintId);

            modelBuilder.Entity<ProjectTag>()
                .HasKey(bc => new { bc.ProjectId, bc.TagId });
            modelBuilder.Entity<ProjectTag>()
                .HasOne(bc => bc.Project)
                .WithMany(b => b.ProjectTags)
                .HasForeignKey(bc => bc.ProjectId);
            modelBuilder.Entity<ProjectTag>()
                .HasOne(bc => bc.Tag)
                .WithMany(c => c.ProjectTags)
                .HasForeignKey(bc => bc.TagId);

            modelBuilder.Entity<ProjectUser>()
                .HasKey(bc => new { bc.ProjectId, bc.UserId });
            modelBuilder.Entity<ProjectUser>()
                .HasOne(bc => bc.Project)
                .WithMany(b => b.ProjectUsers)
                .HasForeignKey(bc => bc.ProjectId);
            modelBuilder.Entity<ProjectUser>()
                .HasOne(bc => bc.User)
                .WithMany(c => c.ProjectUsers)
                .HasForeignKey(bc => bc.UserId);

            modelBuilder.Entity<SprintUser>()
                .HasKey(bc => new { bc.SprintId, bc.UserId });
            modelBuilder.Entity<SprintUser>()
                .HasOne(bc => bc.Sprint)
                .WithMany(b => b.SprintUsers)
                .HasForeignKey(bc => bc.SprintId);
            modelBuilder.Entity<SprintUser>()
                .HasOne(bc => bc.User)
                .WithMany(c => c.SprintUsers)
                .HasForeignKey(bc => bc.UserId);
        }
    }
}
