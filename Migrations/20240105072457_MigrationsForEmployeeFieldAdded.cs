using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Employeeskillmanagment.Migrations
{
    /// <inheritdoc />
    public partial class MigrationsForEmployeeFieldAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "Employees",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Firstname",
                table: "Employees",
                newName: "FirstName");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employees",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DOJ",
                table: "Employees",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DOJ", "Designation", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateOnly(2022, 11, 3), "Developer", "sonalipandagre2@gmail.com", "Sonali", "Pandagre" },
                    { 2, new DateOnly(2022, 11, 3), "Tester", "rashmi@gmail.com", "Rashmi", "Bansal" },
                    { 3, new DateOnly(2022, 10, 3), "Designer", "aditya@gmail.com", "Mayuri", "Shirbhate" },
                    { 4, new DateOnly(2021, 10, 3), "Architecture", "animasahu10@gmail.com", "Anima", "Sahu" },
                    { 5, new DateOnly(2020, 10, 4), "Sr. Developer", "divydas20@gmail.com", "Divya", "das" },
                    { 6, new DateOnly(2021, 12, 4), "Frotend Developer", "ankushpandagre100@gmail.com", "Ankush", "Pandagre" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Employees",
                newName: "Lastname");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Employees",
                newName: "Firstname");

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "Employees",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DOJ",
                table: "Employees",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "TEXT");
        }
    }
}
