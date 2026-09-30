using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ReleaseDate = table.Column<DateOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Garages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Garages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleGames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VehicleId = table.Column<int>(type: "INTEGER", nullable: false),
                    GameId = table.Column<int>(type: "INTEGER", nullable: false),
                    Class = table.Column<int>(type: "INTEGER", nullable: false)
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GarageId = table.Column<int>(type: "INTEGER", nullable: false),
                    VehicleGameId = table.Column<int>(type: "INTEGER", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "TEXT", nullable: false)
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
