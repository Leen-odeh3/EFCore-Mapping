using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations
{
    public partial class updateTabels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fname",
                table: "Instructors");

            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "Instructors",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Instructors",
                newName: "Lastname");

            migrationBuilder.AddColumn<string>(
                name: "Fname",
                table: "Instructors",
                type: "varchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");
        }
    }
}
