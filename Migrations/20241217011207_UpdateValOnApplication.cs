using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _213FinalWebAPP.Migrations
{
    /// <inheritdoc />
    public partial class UpdateValOnApplication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ResidentsUnder21",
                table: "AdoptionApplication",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(55)",
                oldMaxLength: 55);

            migrationBuilder.AlterColumn<string>(
                name: "PastPets",
                table: "AdoptionApplication",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ResidentsUnder21",
                table: "AdoptionApplication",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(55)",
                oldMaxLength: 55,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PastPets",
                table: "AdoptionApplication",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);
        }
    }
}
