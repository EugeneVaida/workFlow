using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkFlowBusinessLogicCore.Migrations
{
    public partial class AddCommentModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 12, 17, 16, 23, 511, DateTimeKind.Local), new DateTime(2019, 4, 8, 17, 16, 23, 510, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 10, 17, 16, 23, 511, DateTimeKind.Local), new DateTime(2019, 4, 28, 17, 16, 23, 511, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 12, 17, 16, 23, 511, DateTimeKind.Local), new DateTime(2019, 4, 18, 17, 16, 23, 511, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 13, 17, 16, 23, 511, DateTimeKind.Local), new DateTime(2019, 4, 7, 17, 16, 23, 511, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 14, 17, 16, 23, 511, DateTimeKind.Local), new DateTime(2019, 4, 5, 17, 16, 23, 511, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 15, 17, 16, 23, 511, DateTimeKind.Local), new DateTime(2019, 4, 3, 17, 16, 23, 511, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 16, 17, 16, 23, 511, DateTimeKind.Local), new DateTime(2019, 4, 1, 17, 16, 23, 511, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 17, 17, 16, 23, 511, DateTimeKind.Local), new DateTime(2019, 3, 31, 17, 16, 23, 511, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 6, 11, 17, 16, 23, 511, DateTimeKind.Local), new DateTime(2019, 4, 4, 17, 16, 23, 511, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 22, 17, 16, 23, 511, DateTimeKind.Local), new DateTime(2019, 3, 30, 17, 16, 23, 511, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 12, 17, 16, 23, 511, DateTimeKind.Local), new DateTime(2019, 4, 13, 17, 16, 23, 511, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 10, 17, 16, 23, 511, DateTimeKind.Local), new DateTime(2019, 4, 29, 17, 16, 23, 511, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 12, 17, 16, 23, 511, DateTimeKind.Local), new DateTime(2019, 4, 19, 17, 16, 23, 511, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 13, 17, 16, 23, 511, DateTimeKind.Local), new DateTime(2019, 4, 9, 17, 16, 23, 511, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 14, 17, 16, 23, 511, DateTimeKind.Local), new DateTime(2019, 4, 7, 17, 16, 23, 511, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 15, 17, 16, 23, 511, DateTimeKind.Local), new DateTime(2019, 4, 7, 17, 16, 23, 511, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 16, 17, 16, 23, 511, DateTimeKind.Local), new DateTime(2019, 4, 4, 17, 16, 23, 511, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 17, 17, 16, 23, 511, DateTimeKind.Local), new DateTime(2019, 4, 8, 17, 16, 23, 511, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 6, 11, 17, 16, 23, 511, DateTimeKind.Local), new DateTime(2019, 4, 6, 17, 16, 23, 511, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 22, 17, 16, 23, 511, DateTimeKind.Local), new DateTime(2019, 4, 7, 17, 16, 23, 511, DateTimeKind.Local) });
        }
    }
}
