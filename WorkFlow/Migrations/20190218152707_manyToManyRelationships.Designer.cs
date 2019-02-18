﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorkFlow.Models;

namespace WorkFlow.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20190218152707_manyToManyRelationships")]
    partial class manyToManyRelationships
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WorkFlow.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress");

                    b.Property<string>("Name");

                    b.Property<string>("Telephone");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("WorkFlow.Models.LogHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Describtion");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("WorkFlow.Models.ProjectSprint", b =>
                {
                    b.Property<int>("ProjectId");

                    b.Property<int>("SprintId");

                    b.HasKey("ProjectId", "SprintId");

                    b.HasIndex("SprintId");

                    b.ToTable("ProjectSprint");
                });

            modelBuilder.Entity("WorkFlow.Models.ProjectTag", b =>
                {
                    b.Property<int>("ProjectId");

                    b.Property<int>("TagId");

                    b.HasKey("ProjectId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("ProjectTag");
                });

            modelBuilder.Entity("WorkFlow.Models.ProjectUser", b =>
                {
                    b.Property<int>("ProjectId");

                    b.Property<int>("UserId");

                    b.HasKey("ProjectId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("ProjectUser");
                });

            modelBuilder.Entity("WorkFlow.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("WorkFlow.Models.SearchHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SearchQuary");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("SearchHistories");
                });

            modelBuilder.Entity("WorkFlow.Models.Sprint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Describtion");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Name");

                    b.Property<int>("Priority");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.ToTable("Sprints");
                });

            modelBuilder.Entity("WorkFlow.Models.SprintUser", b =>
                {
                    b.Property<int>("SprintId");

                    b.Property<int>("UserId");

                    b.HasKey("SprintId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("SprintUser");
                });

            modelBuilder.Entity("WorkFlow.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("WorkFlow.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompanyId");

                    b.Property<string>("Login");

                    b.Property<string>("Password");

                    b.Property<int?>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
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

                    b.HasOne("WorkFlow.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");
                });
#pragma warning restore 612, 618
        }
    }
}
