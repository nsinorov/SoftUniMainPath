using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventMe.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Towns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Идентификатор на града")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Име на града")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towns", x => x.Id);
                },
                comment: "Град");

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Идентификатор на мястото")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TownId = table.Column<int>(type: "int", nullable: false, comment: "Идентификатор на града"),
                    StreetAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Адрес на мястото")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Towns_TownId",
                        column: x => x.TownId,
                        principalTable: "Towns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Място на провеждане на събитието");

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Идентификатор на събитието")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Име на събитието"),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Начало на събитието"),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Край на събитието"),
                    PlaceId = table.Column<int>(type: "int", nullable: false, comment: "Идентификатор на мястото"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "Събитието е активно"),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Дата на изтриване")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Addresses_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Събитие");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_TownId",
                table: "Addresses",
                column: "TownId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_PlaceId",
                table: "Events",
                column: "PlaceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Towns");
        }
    }
}
