using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment2EFBasics.Migrations
{
    /// <inheritdoc />
    public partial class UpdateScheduleMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Schedule",
                keyColumn: "Id",
                keyValue: 1,
                column: "Subject",
                value: "Maths");

            migrationBuilder.UpdateData(
                table: "Schedule",
                keyColumn: "Id",
                keyValue: 2,
                column: "Subject",
                value: "Literature");

            migrationBuilder.UpdateData(
                table: "Schedule",
                keyColumn: "Id",
                keyValue: 3,
                column: "Subject",
                value: "Networking");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Schedule",
                keyColumn: "Id",
                keyValue: 1,
                column: "Subject",
                value: "2022");

            migrationBuilder.UpdateData(
                table: "Schedule",
                keyColumn: "Id",
                keyValue: 2,
                column: "Subject",
                value: "2019");

            migrationBuilder.UpdateData(
                table: "Schedule",
                keyColumn: "Id",
                keyValue: 3,
                column: "Subject",
                value: "2022");
        }
    }
}
