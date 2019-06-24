﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorkFlowBusinessLogicCore.Database;

namespace WorkFlowBusinessLogicCore.Migrations
{
    [DbContext(typeof(WorkFlowDbContext))]
    partial class WorkFlowDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WorkFlow.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adress");

                    b.Property<string>("Name");

                    b.Property<string>("Telephone");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new { Id = 1, Adress = "Чонгарский бульвар дом 402", Name = "Макдоналдс", Telephone = "+8 587 475 350" },
                        new { Id = 2, Adress = "Ленинградский проспект", Name = "РесоГарантия", Telephone = "+8 555 35 35" },
                        new { Id = 3, Adress = "Ул. Пушкина дом 32", Name = "HolyDev", Telephone = "+7 456 7899 00" },
                        new { Id = 4, Adress = "Ул. Ялтинская дом 68", Name = "ФранчайзКомпани", Telephone = "+8 909 807 654" },
                        new { Id = 5, Adress = "Ул. Солнечная дом 2", Name = "WorkFlow", Telephone = "+8 999 807 699" },
                        new { Id = 6, Adress = "Ул. Цветочная дом 84", Name = "ПаркВысокихТехнологий", Telephone = "+8 678 897 699" },
                        new { Id = 7, Adress = "Ул. Якуба Колоса дом 5", Name = "SprintSolutions", Telephone = "+8 999 837 699" },
                        new { Id = 8, Adress = "Проспект Рокоссовского дом 132", Name = "MediaStars", Telephone = "+8 678 807 549" },
                        new { Id = 9, Adress = "Ул. Лазурная дом 4", Name = "StarClub", Telephone = "+8 999 374 400" },
                        new { Id = 10, Adress = "Кутузовский проспект дом 1", Name = "PineApple", Telephone = "+8 688 807 471" }
                    );
                });

            modelBuilder.Entity("WorkFlow.Models.Invitation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GUID");

                    b.HasKey("Id");

                    b.ToTable("Invitations");
                });

            modelBuilder.Entity("WorkFlow.Models.LogHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("LogDate");

                    b.Property<string>("Platform");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("LogHistories");
                });

            modelBuilder.Entity("WorkFlow.Models.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsRead");

                    b.Property<string>("Messsage");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("WorkFlow.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new { Id = 1, EndDate = new DateTime(2019, 6, 28, 11, 9, 39, 237, DateTimeKind.Local), Name = "Проект 1", StartDate = new DateTime(2019, 5, 25, 11, 9, 39, 236, DateTimeKind.Local) },
                        new { Id = 2, EndDate = new DateTime(2019, 6, 26, 11, 9, 39, 237, DateTimeKind.Local), Name = "Проект по строительству", StartDate = new DateTime(2019, 6, 14, 11, 9, 39, 237, DateTimeKind.Local) },
                        new { Id = 3, EndDate = new DateTime(2019, 6, 28, 11, 9, 39, 237, DateTimeKind.Local), Name = "Проект по искусству", StartDate = new DateTime(2019, 6, 4, 11, 9, 39, 237, DateTimeKind.Local) },
                        new { Id = 4, EndDate = new DateTime(2019, 6, 29, 11, 9, 39, 237, DateTimeKind.Local), Name = "Открываю пивко", StartDate = new DateTime(2019, 5, 24, 11, 9, 39, 237, DateTimeKind.Local) },
                        new { Id = 5, EndDate = new DateTime(2019, 6, 30, 11, 9, 39, 237, DateTimeKind.Local), Name = "Наливаю в бокал", StartDate = new DateTime(2019, 5, 22, 11, 9, 39, 237, DateTimeKind.Local) },
                        new { Id = 6, EndDate = new DateTime(2019, 7, 1, 11, 9, 39, 237, DateTimeKind.Local), Name = "Щас мне будет легко", StartDate = new DateTime(2019, 5, 20, 11, 9, 39, 237, DateTimeKind.Local) },
                        new { Id = 7, EndDate = new DateTime(2019, 7, 2, 11, 9, 39, 237, DateTimeKind.Local), Name = "Аеееее", StartDate = new DateTime(2019, 5, 18, 11, 9, 39, 237, DateTimeKind.Local) },
                        new { Id = 8, EndDate = new DateTime(2019, 7, 3, 11, 9, 39, 237, DateTimeKind.Local), Name = "Здоровье", StartDate = new DateTime(2019, 5, 17, 11, 9, 39, 237, DateTimeKind.Local) },
                        new { Id = 9, EndDate = new DateTime(2019, 7, 28, 11, 9, 39, 237, DateTimeKind.Local), Name = "Проект оздоровления нации", StartDate = new DateTime(2019, 5, 21, 11, 9, 39, 237, DateTimeKind.Local) },
                        new { Id = 10, EndDate = new DateTime(2019, 7, 8, 11, 9, 39, 237, DateTimeKind.Local), Name = "Пкция за спасение медвежат", StartDate = new DateTime(2019, 5, 16, 11, 9, 39, 237, DateTimeKind.Local) }
                    );
                });

            modelBuilder.Entity("WorkFlow.Models.ProjectInvitation", b =>
                {
                    b.Property<int>("ProjectId");

                    b.Property<int>("InvitationId");

                    b.HasKey("ProjectId", "InvitationId");

                    b.HasIndex("InvitationId");

                    b.ToTable("ProjectInvitations");
                });

            modelBuilder.Entity("WorkFlow.Models.ProjectSprint", b =>
                {
                    b.Property<int>("ProjectId");

                    b.Property<int>("SprintId");

                    b.HasKey("ProjectId", "SprintId");

                    b.HasIndex("SprintId");

                    b.ToTable("ProjectSprint");

                    b.HasData(
                        new { ProjectId = 1, SprintId = 1 },
                        new { ProjectId = 2, SprintId = 1 },
                        new { ProjectId = 3, SprintId = 1 },
                        new { ProjectId = 4, SprintId = 1 },
                        new { ProjectId = 5, SprintId = 1 },
                        new { ProjectId = 6, SprintId = 1 },
                        new { ProjectId = 7, SprintId = 1 },
                        new { ProjectId = 8, SprintId = 1 },
                        new { ProjectId = 9, SprintId = 1 },
                        new { ProjectId = 10, SprintId = 1 }
                    );
                });

            modelBuilder.Entity("WorkFlow.Models.ProjectTag", b =>
                {
                    b.Property<int>("ProjectId");

                    b.Property<int>("TagId");

                    b.HasKey("ProjectId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("ProjectTags");

                    b.HasData(
                        new { ProjectId = 1, TagId = 1 },
                        new { ProjectId = 2, TagId = 2 },
                        new { ProjectId = 3, TagId = 3 },
                        new { ProjectId = 4, TagId = 4 },
                        new { ProjectId = 5, TagId = 5 },
                        new { ProjectId = 6, TagId = 6 },
                        new { ProjectId = 7, TagId = 7 },
                        new { ProjectId = 8, TagId = 8 },
                        new { ProjectId = 9, TagId = 9 },
                        new { ProjectId = 10, TagId = 10 }
                    );
                });

            modelBuilder.Entity("WorkFlow.Models.ProjectUser", b =>
                {
                    b.Property<int>("ProjectId");

                    b.Property<int>("UserId");

                    b.HasKey("ProjectId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("ProjectUser");

                    b.HasData(
                        new { ProjectId = 1, UserId = 1 },
                        new { ProjectId = 2, UserId = 1 },
                        new { ProjectId = 3, UserId = 1 },
                        new { ProjectId = 4, UserId = 1 },
                        new { ProjectId = 5, UserId = 1 },
                        new { ProjectId = 6, UserId = 1 },
                        new { ProjectId = 7, UserId = 1 },
                        new { ProjectId = 8, UserId = 1 },
                        new { ProjectId = 9, UserId = 1 },
                        new { ProjectId = 10, UserId = 1 }
                    );
                });

            modelBuilder.Entity("WorkFlow.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new { Id = 1, Name = "Admin" },
                        new { Id = 2, Name = "User" },
                        new { Id = 3, Name = "Manager" }
                    );
                });

            modelBuilder.Entity("WorkFlow.Models.SearchHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("SearchQuary");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("SearchHistories");
                });

            modelBuilder.Entity("WorkFlow.Models.Sprint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Name");

                    b.Property<int>("Priority");

                    b.Property<DateTime>("StartDate");

                    b.Property<bool>("isDone");

                    b.HasKey("Id");

                    b.ToTable("Sprints");

                    b.HasData(
                        new { Id = 1, Description = "Describtion for sprint 1", EndDate = new DateTime(2019, 6, 28, 11, 9, 39, 237, DateTimeKind.Local), Name = "Спринт по Проект 1", Priority = 1, StartDate = new DateTime(2019, 5, 30, 11, 9, 39, 237, DateTimeKind.Local), isDone = false },
                        new { Id = 2, Description = "Describtion for sprint 2", EndDate = new DateTime(2019, 6, 26, 11, 9, 39, 237, DateTimeKind.Local), Name = "Спринт по Проект по строительству", Priority = 2, StartDate = new DateTime(2019, 6, 15, 11, 9, 39, 237, DateTimeKind.Local), isDone = false },
                        new { Id = 3, Description = "Describtion for sprint 3", EndDate = new DateTime(2019, 6, 28, 11, 9, 39, 237, DateTimeKind.Local), Name = "Спринт по Проект по искусству", Priority = 3, StartDate = new DateTime(2019, 6, 5, 11, 9, 39, 237, DateTimeKind.Local), isDone = false },
                        new { Id = 4, Description = "Describtion for sprint 4", EndDate = new DateTime(2019, 6, 29, 11, 9, 39, 237, DateTimeKind.Local), Name = "Спринт по Открываю пивко", Priority = 4, StartDate = new DateTime(2019, 5, 26, 11, 9, 39, 237, DateTimeKind.Local), isDone = false },
                        new { Id = 5, Description = "Describtion for sprint 5", EndDate = new DateTime(2019, 6, 30, 11, 9, 39, 237, DateTimeKind.Local), Name = "Спринт по Наливаю в бокал", Priority = 5, StartDate = new DateTime(2019, 5, 24, 11, 9, 39, 237, DateTimeKind.Local), isDone = false },
                        new { Id = 6, Description = "Describtion  for sprint 6", EndDate = new DateTime(2019, 7, 1, 11, 9, 39, 237, DateTimeKind.Local), Name = "Спринт по Щас мне будет легко", Priority = 2, StartDate = new DateTime(2019, 5, 24, 11, 9, 39, 237, DateTimeKind.Local), isDone = false },
                        new { Id = 7, Description = "Describtion  for sprint 7 ", EndDate = new DateTime(2019, 7, 2, 11, 9, 39, 237, DateTimeKind.Local), Name = "Спринт по Аеееее", Priority = 3, StartDate = new DateTime(2019, 5, 21, 11, 9, 39, 237, DateTimeKind.Local), isDone = false },
                        new { Id = 8, Description = "Describtion for sprint 8", EndDate = new DateTime(2019, 7, 3, 11, 9, 39, 237, DateTimeKind.Local), Name = "Спринт по Здоровье", Priority = 2, StartDate = new DateTime(2019, 5, 25, 11, 9, 39, 237, DateTimeKind.Local), isDone = false },
                        new { Id = 9, Description = "Describtion for sprint 9", EndDate = new DateTime(2019, 7, 28, 11, 9, 39, 237, DateTimeKind.Local), Name = "Спринт по Проект оздоровления нации", Priority = 2, StartDate = new DateTime(2019, 5, 23, 11, 9, 39, 237, DateTimeKind.Local), isDone = false },
                        new { Id = 10, Description = "Describtion for sprint 10", EndDate = new DateTime(2019, 7, 8, 11, 9, 39, 237, DateTimeKind.Local), Name = "Спринт по Пкция за спасение медвежат", Priority = 2, StartDate = new DateTime(2019, 5, 24, 11, 9, 39, 237, DateTimeKind.Local), isDone = false }
                    );
                });

            modelBuilder.Entity("WorkFlow.Models.SprintUser", b =>
                {
                    b.Property<int>("SprintId");

                    b.Property<int>("UserId");

                    b.HasKey("SprintId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("SprintUser");

                    b.HasData(
                        new { SprintId = 1, UserId = 1 },
                        new { SprintId = 2, UserId = 1 },
                        new { SprintId = 3, UserId = 1 },
                        new { SprintId = 4, UserId = 1 },
                        new { SprintId = 5, UserId = 1 },
                        new { SprintId = 6, UserId = 1 },
                        new { SprintId = 7, UserId = 1 },
                        new { SprintId = 8, UserId = 1 },
                        new { SprintId = 9, UserId = 1 },
                        new { SprintId = 10, UserId = 1 }
                    );
                });

            modelBuilder.Entity("WorkFlow.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new { Id = 1, Name = "Строительство" },
                        new { Id = 2, Name = "ПО" },
                        new { Id = 3, Name = "Арт" },
                        new { Id = 4, Name = "Срочно" },
                        new { Id = 5, Name = "Задержка" },
                        new { Id = 6, Name = "Авто" },
                        new { Id = 7, Name = "Нейросети" },
                        new { Id = 8, Name = "Здоровье" },
                        new { Id = 9, Name = "Пиво" },
                        new { Id = 10, Name = "Социальные сети" }
                    );
                });

            modelBuilder.Entity("WorkFlow.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CompanyId");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Users");

                    b.HasData(
                        new { Id = 1, FirstName = "Eugene", LastName = "Vajda", PasswordHash = "202CB962AC59075B964B07152D234B70", Username = "User" }
                    );
                });

            modelBuilder.Entity("WorkFlow.Models.UserRole", b =>
                {
                    b.Property<int>("RoleId");

                    b.Property<int>("UserId");

                    b.HasKey("RoleId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new { RoleId = 1, UserId = 1 }
                    );
                });

            modelBuilder.Entity("WorkFlow.Models.LogHistory", b =>
                {
                    b.HasOne("WorkFlow.Models.User", "User")
                        .WithMany("LogHistories")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("WorkFlow.Models.Notification", b =>
                {
                    b.HasOne("WorkFlow.Models.User", "User")
                        .WithMany("Notofications")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("WorkFlow.Models.ProjectInvitation", b =>
                {
                    b.HasOne("WorkFlow.Models.Invitation", "Invitation")
                        .WithMany("ProjectInvitations")
                        .HasForeignKey("InvitationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WorkFlow.Models.Project", "Project")
                        .WithMany("ProjectInvitations")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WorkFlow.Models.ProjectSprint", b =>
                {
                    b.HasOne("WorkFlow.Models.Project", "Project")
                        .WithMany("ProjectSprints")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WorkFlow.Models.Sprint", "Sprint")
                        .WithMany("ProjectSprints")
                        .HasForeignKey("SprintId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WorkFlow.Models.ProjectTag", b =>
                {
                    b.HasOne("WorkFlow.Models.Project", "Project")
                        .WithMany("ProjectTags")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WorkFlow.Models.Tag", "Tag")
                        .WithMany("ProjectTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WorkFlow.Models.ProjectUser", b =>
                {
                    b.HasOne("WorkFlow.Models.Project", "Project")
                        .WithMany("ProjectUsers")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WorkFlow.Models.User", "User")
                        .WithMany("ProjectUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WorkFlow.Models.SearchHistory", b =>
                {
                    b.HasOne("WorkFlow.Models.User", "User")
                        .WithMany("SearchHistories")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("WorkFlow.Models.SprintUser", b =>
                {
                    b.HasOne("WorkFlow.Models.Sprint", "Sprint")
                        .WithMany("SprintUsers")
                        .HasForeignKey("SprintId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WorkFlow.Models.User", "User")
                        .WithMany("SprintUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WorkFlow.Models.User", b =>
                {
                    b.HasOne("WorkFlow.Models.Company", "Company")
                        .WithMany("Users")
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("WorkFlow.Models.UserRole", b =>
                {
                    b.HasOne("WorkFlow.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WorkFlow.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
