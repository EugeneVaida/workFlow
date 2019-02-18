using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkFlow.Migrations
{
    public partial class addDateToMainTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Adress", "Name", "Telephone" },
                values: new object[,]
                {
                    { 1, "Чонгарский бульвар дом 402", "Макдоналдс", null },
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

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 2, 23, 0, 34, 35, 934, DateTimeKind.Local), new DateTime(2019, 1, 20, 0, 34, 35, 933, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 2, 21, 0, 34, 35, 934, DateTimeKind.Local), new DateTime(2019, 2, 9, 0, 34, 35, 934, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 2, 23, 0, 34, 35, 934, DateTimeKind.Local), new DateTime(2019, 1, 30, 0, 34, 35, 934, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 2, 24, 0, 34, 35, 934, DateTimeKind.Local), new DateTime(2019, 1, 19, 0, 34, 35, 934, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 2, 25, 0, 34, 35, 934, DateTimeKind.Local), new DateTime(2019, 1, 17, 0, 34, 35, 934, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 2, 26, 0, 34, 35, 934, DateTimeKind.Local), new DateTime(2019, 1, 15, 0, 34, 35, 934, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 2, 27, 0, 34, 35, 934, DateTimeKind.Local), new DateTime(2019, 1, 13, 0, 34, 35, 934, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 2, 28, 0, 34, 35, 934, DateTimeKind.Local), new DateTime(2019, 1, 12, 0, 34, 35, 934, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 3, 25, 0, 34, 35, 934, DateTimeKind.Local), new DateTime(2019, 1, 16, 0, 34, 35, 934, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 3, 5, 0, 34, 35, 934, DateTimeKind.Local), new DateTime(2019, 1, 11, 0, 34, 35, 934, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Sprints",
                columns: new[] { "Id", "Describtion", "EndDate", "Name", "Priority", "StartDate" },
                values: new object[,]
                {
                    { 1, "Describtion for sprint 1", new DateTime(2019, 2, 23, 0, 34, 35, 934, DateTimeKind.Local), "Спринт по Проект 1", 1, new DateTime(2019, 1, 25, 0, 34, 35, 934, DateTimeKind.Local) },
                    { 2, "Describtion for sprint 2", new DateTime(2019, 2, 21, 0, 34, 35, 934, DateTimeKind.Local), "Спринт по Проект по строительству", 2, new DateTime(2019, 2, 10, 0, 34, 35, 934, DateTimeKind.Local) },
                    { 3, "Describtion for sprint 3", new DateTime(2019, 2, 23, 0, 34, 35, 934, DateTimeKind.Local), "Спринт по Проект по искусству", 3, new DateTime(2019, 1, 31, 0, 34, 35, 934, DateTimeKind.Local) },
                    { 4, "Describtion for sprint 4", new DateTime(2019, 2, 24, 0, 34, 35, 934, DateTimeKind.Local), "Спринт по Открываю пивко", 4, new DateTime(2019, 1, 21, 0, 34, 35, 934, DateTimeKind.Local) },
                    { 5, "Describtion for sprint 5", new DateTime(2019, 2, 25, 0, 34, 35, 934, DateTimeKind.Local), "Спринт по Наливаю в бокал", 5, new DateTime(2019, 1, 19, 0, 34, 35, 934, DateTimeKind.Local) },
                    { 6, "Describtion  for sprint 6", new DateTime(2019, 2, 26, 0, 34, 35, 934, DateTimeKind.Local), "Спринт по Щас мне будет легко", 2, new DateTime(2019, 1, 19, 0, 34, 35, 934, DateTimeKind.Local) },
                    { 7, "Describtion  for sprint 7 ", new DateTime(2019, 2, 27, 0, 34, 35, 934, DateTimeKind.Local), "Спринт по Аеееее", 3, new DateTime(2019, 1, 16, 0, 34, 35, 934, DateTimeKind.Local) },
                    { 8, "Describtion for sprint 8", new DateTime(2019, 2, 28, 0, 34, 35, 934, DateTimeKind.Local), "Спринт по Здоровье", 2, new DateTime(2019, 1, 20, 0, 34, 35, 934, DateTimeKind.Local) },
                    { 9, "Describtion for sprint 9", new DateTime(2019, 3, 25, 0, 34, 35, 934, DateTimeKind.Local), "Спринт по Проект оздоровления нации", 2, new DateTime(2019, 1, 18, 0, 34, 35, 934, DateTimeKind.Local) },
                    { 10, "Describtion for sprint 10", new DateTime(2019, 3, 5, 0, 34, 35, 934, DateTimeKind.Local), "Спринт по Пкция за спасение медвежат", 2, new DateTime(2019, 1, 19, 0, 34, 35, 934, DateTimeKind.Local) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 2, 22, 20, 10, 25, 257, DateTimeKind.Local), new DateTime(2019, 1, 19, 20, 10, 25, 249, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 2, 20, 20, 10, 25, 258, DateTimeKind.Local), new DateTime(2019, 2, 8, 20, 10, 25, 258, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 2, 22, 20, 10, 25, 258, DateTimeKind.Local), new DateTime(2019, 1, 29, 20, 10, 25, 258, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 2, 23, 20, 10, 25, 258, DateTimeKind.Local), new DateTime(2019, 1, 18, 20, 10, 25, 258, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 2, 24, 20, 10, 25, 258, DateTimeKind.Local), new DateTime(2019, 1, 16, 20, 10, 25, 258, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 2, 25, 20, 10, 25, 258, DateTimeKind.Local), new DateTime(2019, 1, 14, 20, 10, 25, 258, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 2, 26, 20, 10, 25, 258, DateTimeKind.Local), new DateTime(2019, 1, 12, 20, 10, 25, 258, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 2, 27, 20, 10, 25, 258, DateTimeKind.Local), new DateTime(2019, 1, 11, 20, 10, 25, 258, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 3, 24, 20, 10, 25, 258, DateTimeKind.Local), new DateTime(2019, 1, 15, 20, 10, 25, 258, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 3, 4, 20, 10, 25, 258, DateTimeKind.Local), new DateTime(2019, 1, 10, 20, 10, 25, 258, DateTimeKind.Local) });
        }
    }
}
