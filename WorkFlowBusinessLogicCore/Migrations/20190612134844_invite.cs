using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkFlowBusinessLogicCore.Migrations
{
    public partial class invite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Invitation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GUID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invitation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectInvitation",
                columns: table => new
                {
                    ProjectId = table.Column<int>(nullable: false),
                    InvitationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectInvitation", x => new { x.ProjectId, x.InvitationId });
                    table.ForeignKey(
                        name: "FK_ProjectInvitation_Invitation_InvitationId",
                        column: x => x.InvitationId,
                        principalTable: "Invitation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectInvitation_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 6, 16, 16, 48, 44, 145, DateTimeKind.Local), new DateTime(2019, 5, 13, 16, 48, 44, 145, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 6, 14, 16, 48, 44, 145, DateTimeKind.Local), new DateTime(2019, 6, 2, 16, 48, 44, 145, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 6, 16, 16, 48, 44, 145, DateTimeKind.Local), new DateTime(2019, 5, 23, 16, 48, 44, 145, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 6, 17, 16, 48, 44, 145, DateTimeKind.Local), new DateTime(2019, 5, 12, 16, 48, 44, 145, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 6, 18, 16, 48, 44, 145, DateTimeKind.Local), new DateTime(2019, 5, 10, 16, 48, 44, 145, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 6, 19, 16, 48, 44, 145, DateTimeKind.Local), new DateTime(2019, 5, 8, 16, 48, 44, 145, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 6, 20, 16, 48, 44, 145, DateTimeKind.Local), new DateTime(2019, 5, 6, 16, 48, 44, 145, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 6, 21, 16, 48, 44, 145, DateTimeKind.Local), new DateTime(2019, 5, 5, 16, 48, 44, 145, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 7, 16, 16, 48, 44, 145, DateTimeKind.Local), new DateTime(2019, 5, 9, 16, 48, 44, 145, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 6, 26, 16, 48, 44, 145, DateTimeKind.Local), new DateTime(2019, 5, 4, 16, 48, 44, 145, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 6, 16, 16, 48, 44, 145, DateTimeKind.Local), new DateTime(2019, 5, 18, 16, 48, 44, 145, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 6, 14, 16, 48, 44, 145, DateTimeKind.Local), new DateTime(2019, 6, 3, 16, 48, 44, 145, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 6, 16, 16, 48, 44, 145, DateTimeKind.Local), new DateTime(2019, 5, 24, 16, 48, 44, 145, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 6, 17, 16, 48, 44, 145, DateTimeKind.Local), new DateTime(2019, 5, 14, 16, 48, 44, 145, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 6, 18, 16, 48, 44, 145, DateTimeKind.Local), new DateTime(2019, 5, 12, 16, 48, 44, 145, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 6, 19, 16, 48, 44, 145, DateTimeKind.Local), new DateTime(2019, 5, 12, 16, 48, 44, 145, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 6, 20, 16, 48, 44, 145, DateTimeKind.Local), new DateTime(2019, 5, 9, 16, 48, 44, 145, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 6, 21, 16, 48, 44, 145, DateTimeKind.Local), new DateTime(2019, 5, 13, 16, 48, 44, 145, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 7, 16, 16, 48, 44, 145, DateTimeKind.Local), new DateTime(2019, 5, 11, 16, 48, 44, 145, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 6, 26, 16, 48, 44, 145, DateTimeKind.Local), new DateTime(2019, 5, 12, 16, 48, 44, 145, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectInvitation_InvitationId",
                table: "ProjectInvitation",
                column: "InvitationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectInvitation");

            migrationBuilder.DropTable(
                name: "Invitation");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 14, 11, 16, 34, 795, DateTimeKind.Local), new DateTime(2019, 4, 10, 11, 16, 34, 794, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 12, 11, 16, 34, 795, DateTimeKind.Local), new DateTime(2019, 4, 30, 11, 16, 34, 795, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 14, 11, 16, 34, 795, DateTimeKind.Local), new DateTime(2019, 4, 20, 11, 16, 34, 795, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 15, 11, 16, 34, 795, DateTimeKind.Local), new DateTime(2019, 4, 9, 11, 16, 34, 795, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 16, 11, 16, 34, 795, DateTimeKind.Local), new DateTime(2019, 4, 7, 11, 16, 34, 795, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 17, 11, 16, 34, 795, DateTimeKind.Local), new DateTime(2019, 4, 5, 11, 16, 34, 795, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 18, 11, 16, 34, 795, DateTimeKind.Local), new DateTime(2019, 4, 3, 11, 16, 34, 795, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 19, 11, 16, 34, 795, DateTimeKind.Local), new DateTime(2019, 4, 2, 11, 16, 34, 795, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 6, 13, 11, 16, 34, 795, DateTimeKind.Local), new DateTime(2019, 4, 6, 11, 16, 34, 795, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 24, 11, 16, 34, 795, DateTimeKind.Local), new DateTime(2019, 4, 1, 11, 16, 34, 795, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 14, 11, 16, 34, 795, DateTimeKind.Local), new DateTime(2019, 4, 15, 11, 16, 34, 795, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 12, 11, 16, 34, 795, DateTimeKind.Local), new DateTime(2019, 5, 1, 11, 16, 34, 795, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 14, 11, 16, 34, 795, DateTimeKind.Local), new DateTime(2019, 4, 21, 11, 16, 34, 795, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 15, 11, 16, 34, 795, DateTimeKind.Local), new DateTime(2019, 4, 11, 11, 16, 34, 795, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 16, 11, 16, 34, 795, DateTimeKind.Local), new DateTime(2019, 4, 9, 11, 16, 34, 795, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 17, 11, 16, 34, 795, DateTimeKind.Local), new DateTime(2019, 4, 9, 11, 16, 34, 795, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 18, 11, 16, 34, 795, DateTimeKind.Local), new DateTime(2019, 4, 6, 11, 16, 34, 795, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 19, 11, 16, 34, 795, DateTimeKind.Local), new DateTime(2019, 4, 10, 11, 16, 34, 795, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 6, 13, 11, 16, 34, 795, DateTimeKind.Local), new DateTime(2019, 4, 8, 11, 16, 34, 795, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 24, 11, 16, 34, 795, DateTimeKind.Local), new DateTime(2019, 4, 9, 11, 16, 34, 795, DateTimeKind.Local) });
        }
    }
}
