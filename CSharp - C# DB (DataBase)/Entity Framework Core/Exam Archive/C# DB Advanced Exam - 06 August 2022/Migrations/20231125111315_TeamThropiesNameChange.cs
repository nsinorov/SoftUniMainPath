using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Footballers.Migrations
{
    public partial class TeamThropiesNameChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Thropies",
                table: "Teams",
                newName: "Trophies");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Throphies",
                table: "Teams",
                newName: "Trophies");
        }
    }
}
