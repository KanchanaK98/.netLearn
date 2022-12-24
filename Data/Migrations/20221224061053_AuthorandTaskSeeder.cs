using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class AuthorandTaskSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthordID",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Kanchana Kariyawasam" },
                    { 2, "Buddhini Perera" },
                    { 3, "Sasindu Kariyawasam" },
                    { 4, "Parakrama Kariyawasam" }
                });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthordID", "Due" },
                values: new object[] { 1, new DateTime(2022, 12, 26, 11, 40, 52, 762, DateTimeKind.Local).AddTicks(7655) });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "AuthordID", "Due", "Status", "Todo" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2022, 12, 27, 11, 40, 52, 762, DateTimeKind.Local).AddTicks(7672), 0, "Complete Database Assignment" },
                    { 3, 2, new DateTime(2022, 12, 30, 11, 40, 52, 762, DateTimeKind.Local).AddTicks(7674), 1, "Complete XML Tutorial" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "AuthordID",
                table: "Tasks");

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Due",
                value: new DateTime(2022, 12, 25, 22, 14, 56, 377, DateTimeKind.Local).AddTicks(9227));
        }
    }
}
