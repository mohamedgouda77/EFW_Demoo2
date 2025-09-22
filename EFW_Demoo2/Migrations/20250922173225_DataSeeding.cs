using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFW_Demoo2.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DeptId", "DateofCreation", "DepartmentName" },
                values: new object[,]
                {
                    { 10, new DateTime(2025, 9, 22, 20, 32, 25, 98, DateTimeKind.Local).AddTicks(2339), "IT" },
                    { 20, new DateTime(2025, 9, 22, 20, 32, 25, 98, DateTimeKind.Local).AddTicks(2386), "HR" },
                    { 30, new DateTime(2025, 9, 22, 20, 32, 25, 98, DateTimeKind.Local).AddTicks(2389), "Payroll" },
                    { 40, new DateTime(2025, 9, 22, 20, 32, 25, 98, DateTimeKind.Local).AddTicks(2392), "Admin" },
                    { 50, new DateTime(2025, 9, 22, 20, 32, 25, 98, DateTimeKind.Local).AddTicks(2394), "Support" },
                    { 60, new DateTime(2025, 9, 22, 20, 32, 25, 98, DateTimeKind.Local).AddTicks(2396), "Sales" },
                    { 70, new DateTime(2025, 9, 22, 20, 32, 25, 98, DateTimeKind.Local).AddTicks(2399), "Marketing" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DeptId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DeptId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DeptId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DeptId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DeptId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DeptId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DeptId",
                keyValue: 70);
        }
    }
}
