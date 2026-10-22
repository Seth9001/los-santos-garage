using LosSantosGarage.Api.Data;
using LosSantosGarage.Api.Dtos;
using LosSantosGarage.Api.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace LosSantosGarage.Api.Endpoints;

public static class GarageEndpoints
{
    private const int DefaultGarageId = 1;

    private static readonly Expression<Func<GarageItem, GarageItemDto>> ToGarageItemDto = gi => new GarageItemDto(
        GarageItemId: gi.Id,
        VehicleName: gi.VehicleGame.Vehicle.Name,
        GameName: gi.VehicleGame.Game.Name,
        Class: gi.VehicleGame.Class.ToString(),
        DateAdded: gi.DateAdded);


    public static void MapGarageEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/garage");

        group.MapGet("/", async (GarageDbContext db) =>
        {
            var items = await db.GarageItems
            .Where(gi => gi.GarageId == DefaultGarageId)
            .OrderByDescending(gi => gi.DateAdded)
            .Select(ToGarageItemDto)
            .ToListAsync();
            return Results.Ok(items);
        }).WithName("GetGarage");

        group.MapPost("/", async (AddGarageItemRequest request, GarageDbContext db) =>
            {
                var vehicleGameExists = await db.VehicleGames.AnyAsync(vg => vg.Id == request.VehicleGameId);
                if (!vehicleGameExists)
                    return Results.BadRequest($"Vehicle game with ID {request.VehicleGameId} does not exist.");
                var garageItem = new GarageItem { GarageId = DefaultGarageId, VehicleGameId = request.VehicleGameId };
                db.GarageItems.Add(garageItem);
                await db.SaveChangesAsync();

                var dto = await db.GarageItems
                .Where(gi => gi.Id == garageItem.Id)
                .Select(ToGarageItemDto)
                .FirstAsync();

                return Results.Created($"/api/garage/{garageItem.Id}", dto);
            }).WithName("AddGarageItem");

        group.MapDelete("/{id:int}", async (int id, GarageDbContext db) =>
        {
            var garageItem = await db.GarageItems
            .Where(gi => gi.Id == id && gi.GarageId == DefaultGarageId).FirstOrDefaultAsync();
            if (garageItem == null)
            {
                return Results.NotFound($"Garage item of ID: {id} does not exist");
            }
            db.GarageItems.Remove(garageItem);
            await db.SaveChangesAsync();
            return Results.NoContent();
        }).WithName("RemoveGarageItem");
    }
}
