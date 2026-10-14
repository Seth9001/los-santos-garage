using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LosSantosGarage.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Garages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VehicleGames",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VehicleGames",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VehicleGames",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VehicleGames",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VehicleGames",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VehicleGames",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VehicleGames",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VehicleGames",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "VehicleGames",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "VehicleGames",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "VehicleGames",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "VehicleGames",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "VehicleGames",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "VehicleGames",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "VehicleGames",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "VehicleGames",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "VehicleGames",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "VehicleGames",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "VehicleGames",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "VehicleGames",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "VehicleGames",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "VehicleGames",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "VehicleGames",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "VehicleGames",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "VehicleGames",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "VehicleGames",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "VehicleGames",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "VehicleGames",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "VehicleGames",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "VehicleGames",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
