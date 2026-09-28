namespace LosSantosGarage.Api.Entities;

public class VehicleGame
{
    public int Id { get; set; }
    public int VehicleId { get; set; }
    public Vehicle Vehicle { get; set; } = null!;
    public int GameId { get; set; }
    public Game Game { get; set; } = null!;
    public required VehicleClass Class { get; set; }
    public ICollection<GarageItem> GarageItems { get; set; } = [];
}
