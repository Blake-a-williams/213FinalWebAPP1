using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _213FinalWebAPP.Migrations
{
    /// <inheritdoc />
    public partial class updateApplicationValidationAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "AdoptionApplication",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "YardDetails",
                table: "AdoptionApplication",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "YardDetails",
                table: "AdoptionApplication");
        }
    }
}
