using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment2EFBasics.Migrations
{
    /// <inheritdoc />
    public partial class StudentMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "Cohort", "FirstName", "LastName" },
                values: new object[] { 3, "2022", "Phi", "Vo" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
