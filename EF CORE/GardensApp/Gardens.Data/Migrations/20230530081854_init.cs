using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gardens.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gardens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    GardenType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gardens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GardenNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GardenId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GardenNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GardenNotes_Gardens_GardenId",
                        column: x => x.GardenId,
                        principalTable: "Gardens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "GardenOwner",
                columns: table => new
                {
                    GardenId = table.Column<int>(type: "int", nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GardenOwner", x => new { x.GardenId, x.OwnerId });
                    table.ForeignKey(
                        name: "FK_GardenOwner_Gardens_GardenId",
                        column: x => x.GardenId,
                        principalTable: "Gardens",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GardenOwner_Owners_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owners",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Gardens",
                columns: new[] { "Id", "Detail", "GardenType", "Name" },
                values: new object[] { 1, null, "Flower Garden", "My Garden" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Bio", "FirstName", "LastName" },
                values: new object[] { 1, null, "John", "Doe" });

            migrationBuilder.InsertData(
                table: "GardenNotes",
                columns: new[] { "Id", "CreatedAt", "GardenId", "Note" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "My beautiful flowers in May." });

            migrationBuilder.InsertData(
                table: "GardenOwner",
                columns: new[] { "GardenId", "OwnerId", "Role" },
                values: new object[] { 1, 1, "Admin" });

            migrationBuilder.CreateIndex(
                name: "IX_GardenNotes_GardenId",
                table: "GardenNotes",
                column: "GardenId");

            migrationBuilder.CreateIndex(
                name: "IX_GardenOwner_OwnerId",
                table: "GardenOwner",
                column: "OwnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GardenNotes");

            migrationBuilder.DropTable(
                name: "GardenOwner");

            migrationBuilder.DropTable(
                name: "Gardens");

            migrationBuilder.DropTable(
                name: "Owners");
        }
    }
}
