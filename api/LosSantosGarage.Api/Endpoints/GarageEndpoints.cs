using LosSantosGarage.Api.Data;
using LosSantosGarage.Api.Dtos;
using Microsoft.EntityFrameworkCore;

namespace LosSantosGarage.Api.Endpoints;

public static class GarageEndpoints
{
    private const int DefaultGarageId = 1; 
    public static void MapGarageEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/garage");

        group.MapGet("/", async (GarageDbContext db) =>
        {
            var items = await db.GarageItems
            .Where(gi => gi.GarageId == DefaultGarageId)
            .OrderByDescending(gi => gi.DateAdded)         
            .Select(gi => new GarageItemDto(
                GarageItemId: gi.Id,
                VehicleName: gi.VehicleGame.Vehicle.Name,
                GameName: gi.VehicleGame.Game.Name,
                Class: gi.VehicleGame.Class.ToString(),
                DateAdded: gi.DateAdded
                )).ToListAsync();
            return Results.Ok(items);
        }).WithName("GetGarage");
    }
}
