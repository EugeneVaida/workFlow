using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkFlowBusinessLogic.Migrations
{
    public partial class projectModelRename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Describtion",
                table: "Projects",
                newName: "Description");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { null, new DateTime(2019, 4, 1, 16, 55, 4, 942, DateTimeKind.Local), new DateTime(2019, 2, 26, 16, 55, 4, 942, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { null, new DateTime(2019, 3, 30, 16, 55, 4, 942, DateTimeKind.Local), new DateTime(2019, 3, 18, 16, 55, 4, 942, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { null, new DateTime(2019, 4, 1, 16, 55, 4, 942, DateTimeKind.Local), new DateTime(2019, 3, 8, 16, 55, 4, 942, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { null, new DateTime(2019, 4, 2, 16, 55, 4, 942, DateTimeKind.Local), new DateTime(2019, 2, 25, 16, 55, 4, 942, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { null, new DateTime(2019, 4, 3, 16, 55, 4, 942, DateTimeKind.Local), new DateTime(2019, 2, 23, 16, 55, 4, 942, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { null, new DateTime(2019, 4, 4, 16, 55, 4, 942, DateTimeKind.Local), new DateTime(2019, 2, 21, 16, 55, 4, 942, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { null, new DateTime(2019, 4, 5, 16, 55, 4, 942, DateTimeKind.Local), new DateTime(2019, 2, 19, 16, 55, 4, 942, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { null, new DateTime(2019, 4, 6, 16, 55, 4, 942, DateTimeKind.Local), new DateTime(2019, 2, 18, 16, 55, 4, 942, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { null, new DateTime(2019, 5, 1, 16, 55, 4, 942, DateTimeKind.Local), new DateTime(2019, 2, 22, 16, 55, 4, 942, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { null, new DateTime(2019, 4, 11, 16, 55, 4, 942, DateTimeKind.Local), new DateTime(2019, 2, 17, 16, 55, 4, 942, DateTimeKind.Local) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Projects",
                newName: "Describtion");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Describtion", "EndDate", "StartDate" },
                values: new object[] { "Describtion", new DateTime(2019, 3, 30, 9, 4, 4, 119, DateTimeKind.Local), new DateTime(2019, 2, 24, 9, 4, 4, 119, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Describtion", "EndDate", "StartDate" },
                values: new object[] { "Describtion", new DateTime(2019, 3, 28, 9, 4, 4, 119, DateTimeKind.Local), new DateTime(2019, 3, 16, 9, 4, 4, 119, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Describtion", "EndDate", "StartDate" },
                values: new object[] { "Describtion", new DateTime(2019, 3, 30, 9, 4, 4, 119, DateTimeKind.Local), new DateTime(2019, 3, 6, 9, 4, 4, 119, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Describtion", "EndDate", "StartDate" },
                values: new object[] { "Describtion", new DateTime(2019, 3, 31, 9, 4, 4, 119, DateTimeKind.Local), new DateTime(2019, 2, 23, 9, 4, 4, 119, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Describtion", "EndDate", "StartDate" },
                values: new object[] { "Describtion", new DateTime(2019, 4, 1, 9, 4, 4, 119, DateTimeKind.Local), new DateTime(2019, 2, 21, 9, 4, 4, 119, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Describtion", "EndDate", "StartDate" },
                values: new object[] { "Describtion", new DateTime(2019, 4, 2, 9, 4, 4, 119, DateTimeKind.Local), new DateTime(2019, 2, 19, 9, 4, 4, 119, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Describtion", "EndDate", "StartDate" },
                values: new object[] { "Describtion", new DateTime(2019, 4, 3, 9, 4, 4, 119, DateTimeKind.Local), new DateTime(2019, 2, 17, 9, 4, 4, 119, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Describtion", "EndDate", "StartDate" },
                values: new object[] { "Describtion", new DateTime(2019, 4, 4, 9, 4, 4, 119, DateTimeKind.Local), new DateTime(2019, 2, 16, 9, 4, 4, 119, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Describtion", "EndDate", "StartDate" },
                values: new object[] { "Describtion", new DateTime(2019, 4, 29, 9, 4, 4, 119, DateTimeKind.Local), new DateTime(2019, 2, 20, 9, 4, 4, 119, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Describtion", "EndDate", "StartDate" },
                values: new object[] { "Describtion", new DateTime(2019, 4, 9, 9, 4, 4, 119, DateTimeKind.Local), new DateTime(2019, 2, 15, 9, 4, 4, 119, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 3, 30, 9, 4, 4, 119, DateTimeKind.Local), new DateTime(2019, 3, 1, 9, 4, 4, 119, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 3, 28, 9, 4, 4, 119, DateTimeKind.Local), new DateTime(2019, 3, 17, 9, 4, 4, 119, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 3, 30, 9, 4, 4, 119, DateTimeKind.Local), new DateTime(2019, 3, 7, 9, 4, 4, 119, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 3, 31, 9, 4, 4, 119, DateTimeKind.Local), new DateTime(2019, 2, 25, 9, 4, 4, 119, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 1, 9, 4, 4, 119, DateTimeKind.Local), new DateTime(2019, 2, 23, 9, 4, 4, 119, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 2, 9, 4, 4, 119, DateTimeKind.Local), new DateTime(2019, 2, 23, 9, 4, 4, 119, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 3, 9, 4, 4, 119, DateTimeKind.Local), new DateTime(2019, 2, 20, 9, 4, 4, 119, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 4, 9, 4, 4, 119, DateTimeKind.Local), new DateTime(2019, 2, 24, 9, 4, 4, 119, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 29, 9, 4, 4, 119, DateTimeKind.Local), new DateTime(2019, 2, 22, 9, 4, 4, 119, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 9, 9, 4, 4, 119, DateTimeKind.Local), new DateTime(2019, 2, 23, 9, 4, 4, 119, DateTimeKind.Local) });
        }
    }
}
