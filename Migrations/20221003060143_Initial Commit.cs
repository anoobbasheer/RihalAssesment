using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RihalAssesment.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "date_of_birth",
                table: "Student",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "id",
                keyValue: 1001,
                column: "date_of_birth",
                value: new DateTime(2022, 10, 3, 11, 31, 43, 308, DateTimeKind.Local).AddTicks(9604));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "date_of_birth",
                table: "Student",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "id",
                keyValue: 1001,
                column: "date_of_birth",
                value: "25-06-1991");
        }
    }
}
