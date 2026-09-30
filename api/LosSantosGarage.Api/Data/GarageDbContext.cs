using Microsoft.EntityFrameworkCore;
using LosSantosGarage.Api.Entities;

namespace LosSantosGarage.Api.Data;

public class GarageDbContext : DbContext
{
    public GarageDbContext(DbContextOptions<GarageDbContext> options) : base(options)
    {

    }

    public DbSet<Game> Games { get; set; }
    public DbSet<Garage> Garages { get; set; }
    public DbSet<GarageItem> GarageItems { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<VehicleGame> VehicleGames { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<VehicleGame>(entity =>
        {
            entity.HasIndex(x => new { x.VehicleId, x.GameId}).IsUnique();                     
        });
    }
}
