using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskBoardApp.Data.Migrations
{
    public partial class AddTasksAndBoardsAndSeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boards",
                columns: table => new 
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BoardId = table.Column<int>(type: "int", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_Boards_BoardId",
                        column: x => x.BoardId,
                        principalTable: "Boards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Boards",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Open" });

            migrationBuilder.InsertData(
                table: "Boards",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "In Progress" });

            migrationBuilder.InsertData(
                table: "Boards",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Done" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "BoardId", "CreatedOn", "Description", "OwnerId", "Title" },
                values: new object[,]
                {
                    { new Guid("949b59f4-8542-4d9c-a43f-b00abd5980c5"), 1, new DateTime(2023, 7, 19, 17, 59, 58, 78, DateTimeKind.Local).AddTicks(2702), "Implement better styling for all public pages", "e56c79c6-fff2-496b-828b-c89b0a6f9891", "Improve CSS Styles" },
                    { new Guid("ce265bc7-c3de-4332-b03e-457cd42249d7"), 3, new DateTime(2023, 2, 4, 17, 59, 58, 78, DateTimeKind.Local).AddTicks(2758), "Implement [Create Task] page for adding new tasks", "e56c79c6-fff2-496b-828b-c89b0a6f9891", "Create Tasks" },
                    { new Guid("d4686b02-a8c1-4abe-b41b-1b8cabebc66f"), 2, new DateTime(2024, 1, 4, 17, 59, 58, 78, DateTimeKind.Local).AddTicks(2747), "Create Windows Forms desktop app client for the TaskBoard RESTful API", "16ffcce9-8ef4-4e71-93ae-d361009cc50f", "Desktop Client App" },
                    { new Guid("d8ecaab3-3108-47a2-948e-31cd55338d11"), 1, new DateTime(2023, 9, 4, 17, 59, 58, 78, DateTimeKind.Local).AddTicks(2742), "Create Android client app for the RESTful API", "16ffcce9-8ef4-4e71-93ae-d361009cc50f", "Android Client App" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_BoardId",
                table: "Tasks",
                column: "BoardId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_OwnerId",
                table: "Tasks",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Boards");
        }
    }
}
