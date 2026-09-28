namespace LosSantosGarage.Api.Entities;

public class Game
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required DateOnly ReleaseDate { get; set; }
    public ICollection<VehicleGame> VehicleGames { get; set; } = new List<VehicleGame>();
}
