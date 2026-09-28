namespace LosSantosGarage.Api.Entities;

public class Vehicle
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public ICollection<VehicleGame> VehicleGames { get; set; } = new List<VehicleGame>();
}
