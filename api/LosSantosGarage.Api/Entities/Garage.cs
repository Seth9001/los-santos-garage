namespace LosSantosGarage.Api.Entities;

public class Garage
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public ICollection<GarageItem> GarageItems { get; set; } = [];
}
