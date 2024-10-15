using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskBoardApp.Data.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Board identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Board name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Task identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false, comment: "Task title"),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, comment: "Task description"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of creation"),
                    BoardId = table.Column<int>(type: "int", nullable: true, comment: "Board identifier"),
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
                },
                comment: "Board Tasks");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d050bf9f-b908-45ee-8f7d-2e2e4c11041a", 0, "e96b34d1-9fca-41a4-af13-94a1b5520fdd", null, false, false, null, null, "TEST@SOFTUNI.BG", "AQAAAAEAACcQAAAAECWE7ZwHyZBXV3Sr/E7aMiikYuSYhbQvcfltrBzWoZAG7hWsgmC5amv5rXYugriwVw==", null, false, "dacfea19-dd83-4839-9c79-ac99b44b94db", false, "test@softuni.bg" });

            migrationBuilder.InsertData(
                table: "Boards",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Open" },
                    { 2, "In progress" },
                    { 3, "Done" }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "BoardId", "CreatedOn", "Description", "OwnerId", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 3, 29, 23, 33, 29, 452, DateTimeKind.Local).AddTicks(7608), "Improve better styling for all public pages", "d050bf9f-b908-45ee-8f7d-2e2e4c11041a", "Improve CSS Styles" },
                    { 2, 1, new DateTime(2024, 5, 15, 23, 33, 29, 452, DateTimeKind.Local).AddTicks(7651), "Create Android client app for the TaskBoard RESTful API", "d050bf9f-b908-45ee-8f7d-2e2e4c11041a", "Android Client App" },
                    { 3, 2, new DateTime(2024, 9, 15, 23, 33, 29, 452, DateTimeKind.Local).AddTicks(7655), "Create Windows Forms desktop app client app for the TaskBoard RESTful API", "d050bf9f-b908-45ee-8f7d-2e2e4c11041a", "Desktop Client App" },
                    { 4, 3, new DateTime(2023, 10, 15, 23, 33, 29, 452, DateTimeKind.Local).AddTicks(7658), "Implement [Create Task] page for adding new tasks", "d050bf9f-b908-45ee-8f7d-2e2e4c11041a", "Create Tasks" }
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

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d050bf9f-b908-45ee-8f7d-2e2e4c11041a");
        }
    }
}
