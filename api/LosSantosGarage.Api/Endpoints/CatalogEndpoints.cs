using LosSantosGarage.Api.Data;
using LosSantosGarage.Api.Dtos;
using Microsoft.EntityFrameworkCore;

namespace LosSantosGarage.Api.Endpoints;


public static class CatalogEndpoints
{
    public static void MapCatalogEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/catalog");

        group.MapGet("/", async (GarageDbContext db) =>
        {

            var items = await db.VehicleGames
            .OrderBy(vg => vg.Vehicle.Name)
            .ThenBy(vg => vg.Game.ReleaseDate)
            .Select(vg => new CatalogItemDto(
                VehicleGameId: vg.Id,
                VehicleName: vg.Vehicle.Name,
                GameName: vg.Game.Name,
                Class: vg.Class.ToString()
                )).ToListAsync();

            return Results.Ok(items);
        }).WithName("GetCatalog");
        
    }
}
