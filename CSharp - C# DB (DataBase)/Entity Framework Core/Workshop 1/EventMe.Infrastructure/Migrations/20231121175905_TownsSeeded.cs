using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventMe.Infrastructure.Migrations
{
    public partial class TownsSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Towns",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "София" },
                    { 2, "Пловдив" },
                    { 3, "Варна" },
                    { 4, "Бутгас" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
