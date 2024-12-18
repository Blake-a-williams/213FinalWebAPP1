using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _213FinalWebAPP.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedApplicationClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrentPets",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DogHomeAlone",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DogName",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmploymentEmployer",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmploymentOccupation",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fit",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HouseType",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Other",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PastPets",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RefName",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RefName2",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RefNumber",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RefNumber2",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RefRelationship",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RefRelationship2",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rent",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Residents",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResidentsUnder21",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sleep",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Training",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UserAge",
                table: "AdoptionApplication",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Yard",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "CurrentPets",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "DogHomeAlone",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "DogName",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "EmploymentEmployer",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "EmploymentOccupation",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "Fit",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "HouseType",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "Other",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "PastPets",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "RefName",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "RefName2",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "RefNumber",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "RefNumber2",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "RefRelationship",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "RefRelationship2",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "Rent",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "Residents",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "ResidentsUnder21",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "Sleep",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "Training",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "UserAge",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "Yard",
                table: "AdoptionApplication");
        }
    }
}
