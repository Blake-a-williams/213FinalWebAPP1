using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _213FinalWebAPP.Migrations
{
    /// <inheritdoc />
    public partial class AddAvailabilityToDogClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Availability",
                table: "Dog",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Availability",
                table: "Dog");
        }
    }
}
