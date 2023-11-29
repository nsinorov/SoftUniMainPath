using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Footballers.Migrations
{
    public partial class PositionAndSkillTypesNamesChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Position",
                table: "Footballers",
                newName: "PositionType");

            migrationBuilder.RenameColumn(
                name: "BestSkill",
                table: "Footballers",
                newName: "BestSkillType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PositionType",
                table: "Footballers",
                newName: "Position");

            migrationBuilder.RenameColumn(
                name: "BestSkillType",
                table: "Footballers",
                newName: "BestSkill");
        }
    }
}
