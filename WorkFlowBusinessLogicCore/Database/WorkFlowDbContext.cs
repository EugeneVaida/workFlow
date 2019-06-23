using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkFlow.Models;

namespace WorkFlowBusinessLogicCore.Database
{
    public class WorkFlowDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<LogHistory> LogHistories { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectSprint> ProjectSprint { get; set; }
        public DbSet<ProjectTag> ProjectTags { get; set; }
        public DbSet<SearchHistory> SearchHistories { get; set; }
        public DbSet<Invitation> Invitations { get; set; }
        public DbSet<ProjectInvitation> ProjectInvitations { get; set; }
        public DbSet<Sprint> Sprints { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public string ConnectionString { get; set; }

        public WorkFlowDbContext(DbContextOptions<WorkFlowDbContext> options)
        : base(options)
        { }


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

            modelBuilder.Entity<ProjectInvitation>()
                .HasKey(bc => new { bc.ProjectId, bc.InvitationId });
            modelBuilder.Entity<ProjectInvitation>()
                .HasOne(bc => bc.Project)
                .WithMany(b => b.ProjectInvitations)
                .HasForeignKey(bc => bc.ProjectId);
            modelBuilder.Entity<ProjectInvitation>()
                .HasOne(bc => bc.Invitation)
                .WithMany(c => c.ProjectInvitations)
                .HasForeignKey(bc => bc.InvitationId);

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

            modelBuilder.Entity<UserRole>()
                .HasKey(bc => new { bc.RoleId, bc.UserId });
            modelBuilder.Entity<UserRole>()
                .HasOne(bc => bc.Role)
                .WithMany(b => b.UserRoles)
                .HasForeignKey(bc => bc.RoleId);
            modelBuilder.Entity<UserRole>()
                .HasOne(bc => bc.User)
                .WithMany(c => c.UserRoles)
                .HasForeignKey(bc => bc.UserId);
                       

            modelBuilder.Entity<Company>().HasData(
                new  { Id = 1, Name = "Макдоналдс", Adress = "Чонгарский бульвар дом 402", Telephone = "+8 587 475 350" },
                new  { Id = 2, Name = "РесоГарантия", Adress = "Ленинградский проспект", Telephone = "+8 555 35 35" },
                new  { Id = 3, Name = "HolyDev", Adress = "Ул. Пушкина дом 32", Telephone = "+7 456 7899 00" },
                new  { Id = 4, Name = "ФранчайзКомпани", Adress = "Ул. Ялтинская дом 68", Telephone = "+8 909 807 654" },
                new  { Id = 5, Name = "WorkFlow", Adress = "Ул. Солнечная дом 2", Telephone = "+8 999 807 699" },
                new  { Id = 6, Name = "ПаркВысокихТехнологий", Adress = "Ул. Цветочная дом 84", Telephone = "+8 678 897 699" },
                new  { Id = 7, Name = "SprintSolutions", Adress = "Ул. Якуба Колоса дом 5", Telephone = "+8 999 837 699" },
                new  { Id = 8, Name = "MediaStars", Adress = "Проспект Рокоссовского дом 132", Telephone = "+8 678 807 549" },
                new  { Id = 9, Name = "StarClub", Adress = "Ул. Лазурная дом 4", Telephone = "+8 999 374 400" },
                new  { Id = 10, Name = "PineApple", Adress = "Кутузовский проспект дом 1", Telephone = "+8 688 807 471" }
            );

            modelBuilder.Entity<User>().HasData(
                new  { Id = 1, Username = "User", PasswordHash = "202CB962AC59075B964B07152D234B70", FirstName = "Eugene", LastName = "Vajda" }
            );

            modelBuilder.Entity<Role>().HasData(
              new  { Id = 1, Name = "Admin" },
              new  { Id = 2, Name = "User" },
              new  { Id = 3, Name = "Manager" }
            );

            modelBuilder.Entity<Tag>().HasData(
                new  { Id = 1, Name = "Строительство" },
                new  { Id = 2, Name = "ПО" },
                new  { Id = 3, Name = "Арт" },
                new  { Id = 4, Name = "Срочно" },
                new  { Id = 5, Name = "Задержка" },
                new  { Id = 6, Name = "Авто" },
                new  { Id = 7, Name = "Нейросети" },
                new  { Id = 8, Name = "Здоровье" },
                new  { Id = 9, Name = "Пиво" },
                new  { Id = 10, Name = "Социальные сети" }
            );

            modelBuilder.Entity<Project>().HasData(
                new  { Id = 1, Name = "Проект 1", Describtion = "Describtion", StartDate = DateTime.Now.AddDays(-30), EndDate = DateTime.Now.AddDays(4) },
                new  { Id = 2, Name = "Проект по строительству", Describtion = "Describtion", StartDate = DateTime.Now.AddDays(-10), EndDate = DateTime.Now.AddDays(2) },
                new  { Id = 3, Name = "Проект по искусству", Describtion = "Describtion", StartDate = DateTime.Now.AddDays(-20), EndDate = DateTime.Now.AddDays(4) },
                new  { Id = 4, Name = "Открываю пивко", Describtion = "Describtion", StartDate = DateTime.Now.AddDays(-31), EndDate = DateTime.Now.AddDays(5) },
                new  { Id = 5, Name = "Наливаю в бокал", Describtion = "Describtion", StartDate = DateTime.Now.AddDays(-33), EndDate = DateTime.Now.AddDays(6) },
                new  { Id = 6, Name = "Щас мне будет легко", Describtion = "Describtion", StartDate = DateTime.Now.AddDays(-35), EndDate = DateTime.Now.AddDays(7) },
                new  { Id = 7, Name = "Аеееее", Describtion = "Describtion", StartDate = DateTime.Now.AddDays(-37), EndDate = DateTime.Now.AddDays(8) },
                new  { Id = 8, Name = "Здоровье", Describtion = "Describtion", StartDate = DateTime.Now.AddDays(-38), EndDate = DateTime.Now.AddDays(9) },
                new  { Id = 9, Name = "Проект оздоровления нации", Describtion = "Describtion", StartDate = DateTime.Now.AddDays(-34), EndDate = DateTime.Now.AddDays(34) },
                new  { Id = 10, Name = "Пкция за спасение медвежат", Describtion = "Describtion", StartDate = DateTime.Now.AddDays(-39), EndDate = DateTime.Now.AddDays(14) }
            );

            modelBuilder.Entity<Sprint>().HasData(
                new  { Id = 1, isDone = false, Name = "Спринт по Проект 1", Description = "Describtion for sprint 1", StartDate = DateTime.Now.AddDays(-25), EndDate = DateTime.Now.AddDays(4), Priority = 1 },
                new  { Id = 2, isDone = false, Name = "Спринт по Проект по строительству", Description = "Describtion for sprint 2", StartDate = DateTime.Now.AddDays(-9), EndDate = DateTime.Now.AddDays(2), Priority = 2 },
                new  { Id = 3, isDone = false, Name = "Спринт по Проект по искусству", Description = "Describtion for sprint 3", StartDate = DateTime.Now.AddDays(-19), EndDate = DateTime.Now.AddDays(4), Priority = 3 },
                new  { Id = 4, isDone = false, Name = "Спринт по Открываю пивко", Description = "Describtion for sprint 4", StartDate = DateTime.Now.AddDays(-29), EndDate = DateTime.Now.AddDays(5), Priority = 4 },
                new  { Id = 5, isDone = false, Name = "Спринт по Наливаю в бокал", Description = "Describtion for sprint 5", StartDate = DateTime.Now.AddDays(-31), EndDate = DateTime.Now.AddDays(6), Priority = 5 },
                new  { Id = 6, isDone = false, Name = "Спринт по Щас мне будет легко", Description = "Describtion  for sprint 6", StartDate = DateTime.Now.AddDays(-31), EndDate = DateTime.Now.AddDays(7), Priority = 2 },
                new  { Id = 7, isDone = false, Name = "Спринт по Аеееее", Description = "Describtion  for sprint 7 ", StartDate = DateTime.Now.AddDays(-34), EndDate = DateTime.Now.AddDays(8), Priority = 3 },
                new  { Id = 8, isDone = false, Name = "Спринт по Здоровье", Description = "Describtion for sprint 8", StartDate = DateTime.Now.AddDays(-30), EndDate = DateTime.Now.AddDays(9), Priority = 2 },
                new  { Id = 9, isDone = false, Name = "Спринт по Проект оздоровления нации", Description = "Describtion for sprint 9", StartDate = DateTime.Now.AddDays(-32), EndDate = DateTime.Now.AddDays(34), Priority = 2 },
                new  { Id = 10, isDone = false,  Name = "Спринт по Пкция за спасение медвежат", Description = "Describtion for sprint 10", StartDate = DateTime.Now.AddDays(-31), EndDate = DateTime.Now.AddDays(14), Priority = 2 }
            );


            modelBuilder.Entity<ProjectTag>().HasData(
                new  { ProjectId = 1, TagId = 1 },
                new  { ProjectId = 2, TagId = 2 },
                new  { ProjectId = 3, TagId = 3 },
                new  { ProjectId = 4, TagId = 4 },
                new  { ProjectId = 5, TagId = 5 },
                new  { ProjectId = 6, TagId = 6 },
                new  { ProjectId = 7, TagId = 7 },
                new  { ProjectId = 8, TagId = 8 },
                new  { ProjectId = 9, TagId = 9 },
                new  { ProjectId = 10, TagId = 10 }
            );


            modelBuilder.Entity<ProjectUser>().HasData(
                new  { ProjectId = 1, UserId = 1 },
                new  { ProjectId = 2, UserId = 1 },
                new  { ProjectId = 3, UserId = 1 },
                new  { ProjectId = 4, UserId = 1 },
                new  { ProjectId = 5, UserId = 1 },
                new  { ProjectId = 6, UserId = 1 },
                new  { ProjectId = 7, UserId = 1 },
                new  { ProjectId = 8, UserId = 1 },
                new  { ProjectId = 9, UserId = 1 },
                new  { ProjectId = 10, UserId = 1 }
            );


            modelBuilder.Entity<ProjectSprint>().HasData(
                new  { ProjectId = 1, SprintId = 1 },
                new  { ProjectId = 2, SprintId = 1 },
                new  { ProjectId = 3, SprintId = 1 },
                new  { ProjectId = 4, SprintId = 1 },
                new  { ProjectId = 5, SprintId = 1 },
                new  { ProjectId = 6, SprintId = 1 },
                new  { ProjectId = 7, SprintId = 1 },
                new  { ProjectId = 8, SprintId = 1 },
                new  { ProjectId = 9, SprintId = 1 },
                new  { ProjectId = 10, SprintId = 1 }
            );

            modelBuilder.Entity<SprintUser>().HasData(
                new  { UserId = 1, SprintId = 1 },
                new  { UserId = 1, SprintId = 2 },
                new  { UserId = 1, SprintId = 3 },
                new  { UserId = 1, SprintId = 4 },
                new  { UserId = 1, SprintId = 5 },
                new  { UserId = 1, SprintId = 6 },
                new  { UserId = 1, SprintId = 7 },
                new  { UserId = 1, SprintId = 8 },
                new  { UserId = 1, SprintId = 9 },
                new  { UserId = 1, SprintId = 10 }
            );

            modelBuilder.Entity<UserRole>().HasData(
                new  { UserId = 1, RoleId = 1 }
            );
        }
    }
}
