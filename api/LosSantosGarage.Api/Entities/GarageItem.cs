namespace LosSantosGarage.Api.Entities;

public class GarageItem
{
    public int Id { get; set; }
    public int GarageId { get; set; }
    public Garage Garage { get; set; } = null!;
    public int VehicleGameId { get; set; }
    public VehicleGame VehicleGame { get; set; } = null!;
    public DateTime DateAdded { get; set; } = DateTime.UtcNow;
}
