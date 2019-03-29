using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkFlowBusinessLogic.Migrations
{
    public partial class addDoneToSprint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isDone",
                table: "Sprints",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 2, 5, 46, 56, 248, DateTimeKind.Local), new DateTime(2019, 2, 27, 5, 46, 56, 247, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 3, 31, 5, 46, 56, 248, DateTimeKind.Local), new DateTime(2019, 3, 19, 5, 46, 56, 248, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 2, 5, 46, 56, 248, DateTimeKind.Local), new DateTime(2019, 3, 9, 5, 46, 56, 248, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 3, 5, 46, 56, 248, DateTimeKind.Local), new DateTime(2019, 2, 26, 5, 46, 56, 248, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 4, 5, 46, 56, 248, DateTimeKind.Local), new DateTime(2019, 2, 24, 5, 46, 56, 248, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 5, 5, 46, 56, 248, DateTimeKind.Local), new DateTime(2019, 2, 22, 5, 46, 56, 248, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 6, 5, 46, 56, 248, DateTimeKind.Local), new DateTime(2019, 2, 20, 5, 46, 56, 248, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 7, 5, 46, 56, 248, DateTimeKind.Local), new DateTime(2019, 2, 19, 5, 46, 56, 248, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 2, 5, 46, 56, 248, DateTimeKind.Local), new DateTime(2019, 2, 23, 5, 46, 56, 248, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 12, 5, 46, 56, 248, DateTimeKind.Local), new DateTime(2019, 2, 18, 5, 46, 56, 248, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 2, 5, 46, 56, 248, DateTimeKind.Local), new DateTime(2019, 3, 4, 5, 46, 56, 248, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 3, 31, 5, 46, 56, 248, DateTimeKind.Local), new DateTime(2019, 3, 20, 5, 46, 56, 248, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 2, 5, 46, 56, 248, DateTimeKind.Local), new DateTime(2019, 3, 10, 5, 46, 56, 248, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 3, 5, 46, 56, 248, DateTimeKind.Local), new DateTime(2019, 2, 28, 5, 46, 56, 248, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 4, 5, 46, 56, 248, DateTimeKind.Local), new DateTime(2019, 2, 26, 5, 46, 56, 248, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 5, 5, 46, 56, 248, DateTimeKind.Local), new DateTime(2019, 2, 26, 5, 46, 56, 248, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 6, 5, 46, 56, 248, DateTimeKind.Local), new DateTime(2019, 2, 23, 5, 46, 56, 248, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 7, 5, 46, 56, 248, DateTimeKind.Local), new DateTime(2019, 2, 27, 5, 46, 56, 248, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 2, 5, 46, 56, 248, DateTimeKind.Local), new DateTime(2019, 2, 25, 5, 46, 56, 248, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 12, 5, 46, 56, 248, DateTimeKind.Local), new DateTime(2019, 2, 26, 5, 46, 56, 248, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isDone",
                table: "Sprints");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 1, 16, 55, 4, 942, DateTimeKind.Local), new DateTime(2019, 2, 26, 16, 55, 4, 942, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 3, 30, 16, 55, 4, 942, DateTimeKind.Local), new DateTime(2019, 3, 18, 16, 55, 4, 942, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 1, 16, 55, 4, 942, DateTimeKind.Local), new DateTime(2019, 3, 8, 16, 55, 4, 942, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 2, 16, 55, 4, 942, DateTimeKind.Local), new DateTime(2019, 2, 25, 16, 55, 4, 942, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 3, 16, 55, 4, 942, DateTimeKind.Local), new DateTime(2019, 2, 23, 16, 55, 4, 942, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 4, 16, 55, 4, 942, DateTimeKind.Local), new DateTime(2019, 2, 21, 16, 55, 4, 942, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 5, 16, 55, 4, 942, DateTimeKind.Local), new DateTime(2019, 2, 19, 16, 55, 4, 942, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 6, 16, 55, 4, 942, DateTimeKind.Local), new DateTime(2019, 2, 18, 16, 55, 4, 942, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 1, 16, 55, 4, 942, DateTimeKind.Local), new DateTime(2019, 2, 22, 16, 55, 4, 942, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 55, 4, 942, DateTimeKind.Local), new DateTime(2019, 2, 17, 16, 55, 4, 942, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 1, 16, 55, 4, 943, DateTimeKind.Local), new DateTime(2019, 3, 3, 16, 55, 4, 943, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 3, 30, 16, 55, 4, 943, DateTimeKind.Local), new DateTime(2019, 3, 19, 16, 55, 4, 943, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 1, 16, 55, 4, 943, DateTimeKind.Local), new DateTime(2019, 3, 9, 16, 55, 4, 943, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 2, 16, 55, 4, 943, DateTimeKind.Local), new DateTime(2019, 2, 27, 16, 55, 4, 943, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 3, 16, 55, 4, 943, DateTimeKind.Local), new DateTime(2019, 2, 25, 16, 55, 4, 943, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 4, 16, 55, 4, 943, DateTimeKind.Local), new DateTime(2019, 2, 25, 16, 55, 4, 943, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 5, 16, 55, 4, 943, DateTimeKind.Local), new DateTime(2019, 2, 22, 16, 55, 4, 943, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 6, 16, 55, 4, 943, DateTimeKind.Local), new DateTime(2019, 2, 26, 16, 55, 4, 943, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 1, 16, 55, 4, 943, DateTimeKind.Local), new DateTime(2019, 2, 24, 16, 55, 4, 943, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 55, 4, 943, DateTimeKind.Local), new DateTime(2019, 2, 25, 16, 55, 4, 943, DateTimeKind.Local) });
        }
    }
}
