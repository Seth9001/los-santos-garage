using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LosSantosGarage.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Garages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Garages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleGames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    Class = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleGames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleGames_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehicleGames_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GarageItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GarageId = table.Column<int>(type: "int", nullable: false),
                    VehicleGameId = table.Column<int>(type: "int", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarageItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GarageItems_Garages_GarageId",
                        column: x => x.GarageId,
                        principalTable: "Garages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GarageItems_VehicleGames_VehicleGameId",
                        column: x => x.VehicleGameId,
                        principalTable: "VehicleGames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Name", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "GTA III", new DateOnly(2001, 10, 22) },
                    { 2, "GTA Vice City", new DateOnly(2002, 10, 29) },
                    { 3, "GTA San Andreas", new DateOnly(2004, 10, 26) },
                    { 4, "GTA IV", new DateOnly(2008, 4, 29) },
                    { 5, "GTA V", new DateOnly(2013, 9, 17) }
                });

            migrationBuilder.InsertData(
                table: "Garages",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Seth's Garage" });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Infernus" },
                    { 2, "Banshee" },
                    { 3, "Sanchez" },
                    { 4, "Sultan" },
                    { 5, "Cheetah" },
                    { 6, "Patriot" },
                    { 7, "PCJ-600" }
                });

            migrationBuilder.InsertData(
                table: "VehicleGames",
                columns: new[] { "Id", "Class", "GameId", "VehicleId" },
                values: new object[,]
                {
                    { 1, 1, 1, 2 },
                    { 2, 1, 2, 2 },
                    { 3, 1, 3, 2 },
                    { 4, 1, 4, 2 },
                    { 5, 1, 5, 2 },
                    { 6, 4, 3, 4 },
                    { 7, 4, 4, 4 },
                    { 8, 1, 5, 4 },
                    { 9, 7, 2, 7 },
                    { 10, 7, 3, 7 },
                    { 11, 7, 4, 7 },
                    { 12, 7, 5, 7 },
                    { 13, 2, 1, 1 },
                    { 14, 2, 2, 1 },
                    { 15, 2, 3, 1 },
                    { 16, 2, 4, 1 },
                    { 17, 2, 5, 1 },
                    { 18, 7, 2, 3 },
                    { 19, 7, 3, 3 },
                    { 20, 7, 4, 3 },
                    { 21, 7, 5, 3 },
                    { 22, 2, 1, 5 },
                    { 23, 2, 2, 5 },
                    { 24, 2, 3, 5 },
                    { 25, 2, 5, 5 },
                    { 26, 5, 1, 6 },
                    { 27, 5, 2, 6 },
                    { 28, 5, 3, 6 },
                    { 29, 5, 4, 6 },
                    { 30, 5, 5, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GarageItems_GarageId",
                table: "GarageItems",
                column: "GarageId");

            migrationBuilder.CreateIndex(
                name: "IX_GarageItems_VehicleGameId",
                table: "GarageItems",
                column: "VehicleGameId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleGames_GameId",
                table: "VehicleGames",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleGames_VehicleId_GameId",
                table: "VehicleGames",
                columns: new[] { "VehicleId", "GameId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GarageItems");

            migrationBuilder.DropTable(
                name: "Garages");

            migrationBuilder.DropTable(
                name: "VehicleGames");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
