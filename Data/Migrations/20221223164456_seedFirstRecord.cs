using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedFirstRecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Due", "Status", "Todo" },
                values: new object[] { 1, new DateTime(2022, 12, 25, 22, 14, 56, 377, DateTimeKind.Local).AddTicks(9227), 1, "Complete Java OOP Assignment" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
