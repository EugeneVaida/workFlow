using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkFlow.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Describtion", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1, "Describtion", new DateTime(2019, 2, 22, 20, 10, 25, 257, DateTimeKind.Local), "Проект 1", new DateTime(2019, 1, 19, 20, 10, 25, 249, DateTimeKind.Local) },
                    { 9, "Describtion", new DateTime(2019, 3, 24, 20, 10, 25, 258, DateTimeKind.Local), "Проект оздоровления нации", new DateTime(2019, 1, 15, 20, 10, 25, 258, DateTimeKind.Local) },
                    { 8, "Describtion", new DateTime(2019, 2, 27, 20, 10, 25, 258, DateTimeKind.Local), "Здоровье", new DateTime(2019, 1, 11, 20, 10, 25, 258, DateTimeKind.Local) },
                    { 7, "Describtion", new DateTime(2019, 2, 26, 20, 10, 25, 258, DateTimeKind.Local), "Аеееее", new DateTime(2019, 1, 12, 20, 10, 25, 258, DateTimeKind.Local) },
                    { 6, "Describtion", new DateTime(2019, 2, 25, 20, 10, 25, 258, DateTimeKind.Local), "Щас мне будет легко", new DateTime(2019, 1, 14, 20, 10, 25, 258, DateTimeKind.Local) },
                    { 10, "Describtion", new DateTime(2019, 3, 4, 20, 10, 25, 258, DateTimeKind.Local), "Пкция за спасение медвежат", new DateTime(2019, 1, 10, 20, 10, 25, 258, DateTimeKind.Local) },
                    { 4, "Describtion", new DateTime(2019, 2, 23, 20, 10, 25, 258, DateTimeKind.Local), "Открываю пивко", new DateTime(2019, 1, 18, 20, 10, 25, 258, DateTimeKind.Local) },
                    { 3, "Describtion", new DateTime(2019, 2, 22, 20, 10, 25, 258, DateTimeKind.Local), "Проект по искусству", new DateTime(2019, 1, 29, 20, 10, 25, 258, DateTimeKind.Local) },
                    { 2, "Describtion", new DateTime(2019, 2, 20, 20, 10, 25, 258, DateTimeKind.Local), "Проект по строительству", new DateTime(2019, 2, 8, 20, 10, 25, 258, DateTimeKind.Local) },
                    { 5, "Describtion", new DateTime(2019, 2, 24, 20, 10, 25, 258, DateTimeKind.Local), "Наливаю в бокал", new DateTime(2019, 1, 16, 20, 10, 25, 258, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 9, "Пиво" },
                    { 1, "Строительство" },
                    { 2, "ПО" },
                    { 3, "Арт" },
                    { 4, "Срочно" },
                    { 5, "Задержка" },
                    { 6, "Авто" },
                    { 7, "Нейросети" },
                    { 8, "Здоровье" },
                    { 10, "Социальные сети" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
