using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkFlowBusinessLogicCore.Migrations
{
    public partial class addEmailToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "Users",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 3, 16, 28, 25, 369, DateTimeKind.Local), new DateTime(2019, 2, 28, 16, 28, 25, 368, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 1, 16, 28, 25, 369, DateTimeKind.Local), new DateTime(2019, 3, 20, 16, 28, 25, 369, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 3, 16, 28, 25, 369, DateTimeKind.Local), new DateTime(2019, 3, 10, 16, 28, 25, 369, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 4, 16, 28, 25, 369, DateTimeKind.Local), new DateTime(2019, 2, 27, 16, 28, 25, 369, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 5, 16, 28, 25, 369, DateTimeKind.Local), new DateTime(2019, 2, 25, 16, 28, 25, 369, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 6, 16, 28, 25, 369, DateTimeKind.Local), new DateTime(2019, 2, 23, 16, 28, 25, 369, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 7, 16, 28, 25, 369, DateTimeKind.Local), new DateTime(2019, 2, 21, 16, 28, 25, 369, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 8, 16, 28, 25, 369, DateTimeKind.Local), new DateTime(2019, 2, 20, 16, 28, 25, 369, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 3, 16, 28, 25, 369, DateTimeKind.Local), new DateTime(2019, 2, 24, 16, 28, 25, 369, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 13, 16, 28, 25, 369, DateTimeKind.Local), new DateTime(2019, 2, 19, 16, 28, 25, 369, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 3, 16, 28, 25, 369, DateTimeKind.Local), new DateTime(2019, 3, 5, 16, 28, 25, 369, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 1, 16, 28, 25, 369, DateTimeKind.Local), new DateTime(2019, 3, 21, 16, 28, 25, 369, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 3, 16, 28, 25, 369, DateTimeKind.Local), new DateTime(2019, 3, 11, 16, 28, 25, 369, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 4, 16, 28, 25, 369, DateTimeKind.Local), new DateTime(2019, 3, 1, 16, 28, 25, 369, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 5, 16, 28, 25, 369, DateTimeKind.Local), new DateTime(2019, 2, 27, 16, 28, 25, 369, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 6, 16, 28, 25, 369, DateTimeKind.Local), new DateTime(2019, 2, 27, 16, 28, 25, 369, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 7, 16, 28, 25, 369, DateTimeKind.Local), new DateTime(2019, 2, 24, 16, 28, 25, 369, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 8, 16, 28, 25, 369, DateTimeKind.Local), new DateTime(2019, 2, 28, 16, 28, 25, 369, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 5, 3, 16, 28, 25, 369, DateTimeKind.Local), new DateTime(2019, 2, 26, 16, 28, 25, 369, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 4, 13, 16, 28, 25, 369, DateTimeKind.Local), new DateTime(2019, 2, 27, 16, 28, 25, 369, DateTimeKind.Local) });
        }
    }
}
