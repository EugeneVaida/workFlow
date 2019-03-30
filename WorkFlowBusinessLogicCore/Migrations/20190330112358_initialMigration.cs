using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkFlowBusinessLogicCore.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sprints",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    isDone = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sprints", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true),
                    CompanyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectSprint",
                columns: table => new
                {
                    ProjectId = table.Column<int>(nullable: false),
                    SprintId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectSprint", x => new { x.ProjectId, x.SprintId });
                    table.ForeignKey(
                        name: "FK_ProjectSprint_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectSprint_Sprints_SprintId",
                        column: x => x.SprintId,
                        principalTable: "Sprints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTags",
                columns: table => new
                {
                    ProjectId = table.Column<int>(nullable: false),
                    TagId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTags", x => new { x.ProjectId, x.TagId });
                    table.ForeignKey(
                        name: "FK_ProjectTags_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LogHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LogDate = table.Column<DateTime>(nullable: false),
                    Platform = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LogHistories_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Messsage = table.Column<string>(nullable: true),
                    IsRead = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectUser",
                columns: table => new
                {
                    ProjectId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectUser", x => new { x.ProjectId, x.UserId });
                    table.ForeignKey(
                        name: "FK_ProjectUser_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SearchHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SearchQuary = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SearchHistories_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SprintUser",
                columns: table => new
                {
                    SprintId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SprintUser", x => new { x.SprintId, x.UserId });
                    table.ForeignKey(
                        name: "FK_SprintUser_Sprints_SprintId",
                        column: x => x.SprintId,
                        principalTable: "Sprints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SprintUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.RoleId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Adress", "Name", "Telephone" },
                values: new object[,]
                {
                    { 1, "Чонгарский бульвар дом 402", "Макдоналдс", "+8 587 475 350" },
                    { 2, "Ленинградский проспект", "РесоГарантия", "+8 555 35 35" },
                    { 3, "Ул. Пушкина дом 32", "HolyDev", "+7 456 7899 00" },
                    { 4, "Ул. Ялтинская дом 68", "ФранчайзКомпани", "+8 909 807 654" },
                    { 5, "Ул. Солнечная дом 2", "WorkFlow", "+8 999 807 699" },
                    { 6, "Ул. Цветочная дом 84", "ПаркВысокихТехнологий", "+8 678 897 699" },
                    { 7, "Ул. Якуба Колоса дом 5", "SprintSolutions", "+8 999 837 699" },
                    { 8, "Проспект Рокоссовского дом 132", "MediaStars", "+8 678 807 549" },
                    { 9, "Ул. Лазурная дом 4", "StarClub", "+8 999 374 400" },
                    { 10, "Кутузовский проспект дом 1", "PineApple", "+8 688 807 471" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Description", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 9, null, new DateTime(2019, 5, 3, 14, 23, 57, 844, DateTimeKind.Local), "Проект оздоровления нации", new DateTime(2019, 2, 24, 14, 23, 57, 844, DateTimeKind.Local) },
                    { 8, null, new DateTime(2019, 4, 8, 14, 23, 57, 844, DateTimeKind.Local), "Здоровье", new DateTime(2019, 2, 20, 14, 23, 57, 844, DateTimeKind.Local) },
                    { 7, null, new DateTime(2019, 4, 7, 14, 23, 57, 844, DateTimeKind.Local), "Аеееее", new DateTime(2019, 2, 21, 14, 23, 57, 844, DateTimeKind.Local) },
                    { 6, null, new DateTime(2019, 4, 6, 14, 23, 57, 844, DateTimeKind.Local), "Щас мне будет легко", new DateTime(2019, 2, 23, 14, 23, 57, 844, DateTimeKind.Local) },
                    { 1, null, new DateTime(2019, 4, 3, 14, 23, 57, 844, DateTimeKind.Local), "Проект 1", new DateTime(2019, 2, 28, 14, 23, 57, 844, DateTimeKind.Local) },
                    { 4, null, new DateTime(2019, 4, 4, 14, 23, 57, 844, DateTimeKind.Local), "Открываю пивко", new DateTime(2019, 2, 27, 14, 23, 57, 844, DateTimeKind.Local) },
                    { 3, null, new DateTime(2019, 4, 3, 14, 23, 57, 844, DateTimeKind.Local), "Проект по искусству", new DateTime(2019, 3, 10, 14, 23, 57, 844, DateTimeKind.Local) },
                    { 2, null, new DateTime(2019, 4, 1, 14, 23, 57, 844, DateTimeKind.Local), "Проект по строительству", new DateTime(2019, 3, 20, 14, 23, 57, 844, DateTimeKind.Local) },
                    { 10, null, new DateTime(2019, 4, 13, 14, 23, 57, 844, DateTimeKind.Local), "Пкция за спасение медвежат", new DateTime(2019, 2, 19, 14, 23, 57, 844, DateTimeKind.Local) },
                    { 5, null, new DateTime(2019, 4, 5, 14, 23, 57, 844, DateTimeKind.Local), "Наливаю в бокал", new DateTime(2019, 2, 25, 14, 23, 57, 844, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "Manager" },
                    { 2, "User" },
                    { 1, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Sprints",
                columns: new[] { "Id", "Description", "EndDate", "Name", "Priority", "StartDate", "isDone" },
                values: new object[,]
                {
                    { 9, "Describtion for sprint 9", new DateTime(2019, 5, 3, 14, 23, 57, 845, DateTimeKind.Local), "Спринт по Проект оздоровления нации", 2, new DateTime(2019, 2, 26, 14, 23, 57, 845, DateTimeKind.Local), false },
                    { 8, "Describtion for sprint 8", new DateTime(2019, 4, 8, 14, 23, 57, 845, DateTimeKind.Local), "Спринт по Здоровье", 2, new DateTime(2019, 2, 28, 14, 23, 57, 845, DateTimeKind.Local), false },
                    { 7, "Describtion  for sprint 7 ", new DateTime(2019, 4, 7, 14, 23, 57, 845, DateTimeKind.Local), "Спринт по Аеееее", 3, new DateTime(2019, 2, 24, 14, 23, 57, 845, DateTimeKind.Local), false },
                    { 6, "Describtion  for sprint 6", new DateTime(2019, 4, 6, 14, 23, 57, 845, DateTimeKind.Local), "Спринт по Щас мне будет легко", 2, new DateTime(2019, 2, 27, 14, 23, 57, 845, DateTimeKind.Local), false },
                    { 10, "Describtion for sprint 10", new DateTime(2019, 4, 13, 14, 23, 57, 845, DateTimeKind.Local), "Спринт по Пкция за спасение медвежат", 2, new DateTime(2019, 2, 27, 14, 23, 57, 845, DateTimeKind.Local), false },
                    { 4, "Describtion for sprint 4", new DateTime(2019, 4, 4, 14, 23, 57, 845, DateTimeKind.Local), "Спринт по Открываю пивко", 4, new DateTime(2019, 3, 1, 14, 23, 57, 845, DateTimeKind.Local), false },
                    { 3, "Describtion for sprint 3", new DateTime(2019, 4, 3, 14, 23, 57, 845, DateTimeKind.Local), "Спринт по Проект по искусству", 3, new DateTime(2019, 3, 11, 14, 23, 57, 845, DateTimeKind.Local), false },
                    { 2, "Describtion for sprint 2", new DateTime(2019, 4, 1, 14, 23, 57, 845, DateTimeKind.Local), "Спринт по Проект по строительству", 2, new DateTime(2019, 3, 21, 14, 23, 57, 845, DateTimeKind.Local), false },
                    { 1, "Describtion for sprint 1", new DateTime(2019, 4, 3, 14, 23, 57, 844, DateTimeKind.Local), "Спринт по Проект 1", 1, new DateTime(2019, 3, 5, 14, 23, 57, 844, DateTimeKind.Local), false },
                    { 5, "Describtion for sprint 5", new DateTime(2019, 4, 5, 14, 23, 57, 845, DateTimeKind.Local), "Спринт по Наливаю в бокал", 5, new DateTime(2019, 2, 27, 14, 23, 57, 845, DateTimeKind.Local), false }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 10, "Социальные сети" },
                    { 1, "Строительство" },
                    { 2, "ПО" },
                    { 3, "Арт" },
                    { 4, "Срочно" },
                    { 5, "Задержка" },
                    { 6, "Авто" },
                    { 7, "Нейросети" },
                    { 8, "Здоровье" },
                    { 9, "Пиво" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CompanyId", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 1, null, "Eugene", "Vajda", "202CB962AC59075B964B07152D234B70", null, "User" });

            migrationBuilder.InsertData(
                table: "ProjectSprint",
                columns: new[] { "ProjectId", "SprintId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 5, 1 },
                    { 6, 1 },
                    { 7, 1 },
                    { 8, 1 },
                    { 9, 1 },
                    { 10, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProjectTags",
                columns: new[] { "ProjectId", "TagId" },
                values: new object[,]
                {
                    { 10, 10 },
                    { 9, 9 },
                    { 8, 8 },
                    { 7, 7 },
                    { 6, 6 },
                    { 3, 3 },
                    { 4, 4 },
                    { 2, 2 },
                    { 1, 1 },
                    { 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "ProjectUser",
                columns: new[] { "ProjectId", "UserId" },
                values: new object[,]
                {
                    { 7, 1 },
                    { 10, 1 },
                    { 9, 1 },
                    { 8, 1 },
                    { 6, 1 },
                    { 1, 1 },
                    { 4, 1 },
                    { 3, 1 },
                    { 2, 1 },
                    { 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "SprintUser",
                columns: new[] { "SprintId", "UserId" },
                values: new object[,]
                {
                    { 10, 1 },
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 5, 1 },
                    { 6, 1 },
                    { 7, 1 },
                    { 8, 1 },
                    { 9, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_LogHistories_UserId",
                table: "LogHistories",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSprint_SprintId",
                table: "ProjectSprint",
                column: "SprintId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTags_TagId",
                table: "ProjectTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectUser_UserId",
                table: "ProjectUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SearchHistories_UserId",
                table: "SearchHistories",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SprintUser_UserId",
                table: "SprintUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CompanyId",
                table: "Users",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogHistories");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "ProjectSprint");

            migrationBuilder.DropTable(
                name: "ProjectTags");

            migrationBuilder.DropTable(
                name: "ProjectUser");

            migrationBuilder.DropTable(
                name: "SearchHistories");

            migrationBuilder.DropTable(
                name: "SprintUser");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Sprints");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
