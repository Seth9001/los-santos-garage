using LosSantosGarage.Api.Entities;
namespace LosSantosGarage.Api.Data;

public static class SeedData
{
    public static Game[] GetGames() => [
        new Game{ Id = 1, Name = "GTA III", ReleaseDate= new DateOnly(2001, 10, 22) },
        new Game{ Id = 2, Name = "GTA Vice City", ReleaseDate =    new DateOnly(2002, 10, 29)},
        new Game{ Id = 3, Name = "GTA San Andreas", ReleaseDate = new DateOnly(2004, 10, 26)},
        new Game{ Id = 4, Name = "GTA IV", ReleaseDate = new DateOnly(2008, 04, 29)},
        new Game{ Id = 5, Name = "GTA V", ReleaseDate = new DateOnly(2013, 09, 17)},
        ];

    public static Vehicle[] GetVehicles() => [

        new Vehicle{ Id=1, Name = "Infernus" },
        new Vehicle{ Id = 2, Name = "Banshee"},
        new Vehicle{ Id=3, Name = "Sanchez"},
        new Vehicle{ Id=4, Name="Sultan"},
        new Vehicle{ Id=5, Name="Cheetah"},
         new Vehicle{ Id=6, Name="Patriot"},
         new Vehicle{ Id=7, Name="PCJ-600"},
        ];

    public static VehicleGame[] GetVehicleGames() => [
        //Banshee
        new VehicleGame{ Id = 1, VehicleId = 2, GameId = 1, Class = VehicleClass.Sports },
        new VehicleGame{ Id = 2, VehicleId = 2, GameId = 2, Class = VehicleClass.Sports },
        new VehicleGame{ Id = 3, VehicleId = 2, GameId = 3, Class = VehicleClass.Sports },
        new VehicleGame{ Id = 4, VehicleId = 2, GameId = 4, Class = VehicleClass.Sports },
        new VehicleGame{ Id = 5, VehicleId = 2, GameId = 5, Class = VehicleClass.Sports },

        //Sultan
        new VehicleGame{ Id=6, VehicleId= 4, GameId = 3, Class=VehicleClass.Sedan},
        new VehicleGame{ Id=7, VehicleId= 4, GameId = 4, Class=VehicleClass.Sedan},
        new VehicleGame{ Id=8, VehicleId= 4, GameId = 5, Class=VehicleClass.Sports},

        //PCJ-600
        new VehicleGame{ Id=9, VehicleId = 7, GameId = 2, Class = VehicleClass.Motorcycle},
        new VehicleGame{ Id=10, VehicleId = 7, GameId = 3, Class = VehicleClass.Motorcycle},
        new VehicleGame{ Id=11, VehicleId = 7, GameId = 4, Class = VehicleClass.Motorcycle},
        new VehicleGame{ Id=12, VehicleId = 7, GameId = 5, Class = VehicleClass.Motorcycle},

        //Infernus
        new VehicleGame{ Id=13, VehicleId=1, GameId = 1, Class= VehicleClass.Super},
        new VehicleGame{ Id=14, VehicleId=1, GameId = 2, Class= VehicleClass.Super},
        new VehicleGame{ Id=15, VehicleId=1, GameId = 3, Class= VehicleClass.Super},
        new VehicleGame{ Id=16, VehicleId=1, GameId = 4, Class= VehicleClass.Super},
        new VehicleGame{ Id=17, VehicleId=1, GameId = 5, Class= VehicleClass.Super},

        //Sanchez
        new VehicleGame{ Id=18, VehicleId=3, GameId = 2, Class= VehicleClass.Motorcycle},
        new VehicleGame{ Id=19, VehicleId=3, GameId = 3, Class= VehicleClass.Motorcycle},
        new VehicleGame{ Id=20, VehicleId=3, GameId = 4, Class= VehicleClass.Motorcycle},
        new VehicleGame{ Id=21, VehicleId=3, GameId = 5, Class= VehicleClass.Motorcycle},

        //Cheetah
        new VehicleGame{ Id=22, VehicleId=5, GameId = 1, Class= VehicleClass.Super},
        new VehicleGame{ Id=23, VehicleId=5, GameId = 2, Class= VehicleClass.Super},
        new VehicleGame{ Id=24, VehicleId=5, GameId = 3, Class= VehicleClass.Super},
        new VehicleGame{ Id=25, VehicleId=5, GameId = 5, Class= VehicleClass.Super},

        //Patriot
        new VehicleGame{ Id=26, VehicleId=6, GameId = 1, Class= VehicleClass.SUV},
        new VehicleGame{ Id=27, VehicleId=6, GameId = 2, Class= VehicleClass.SUV},
        new VehicleGame{ Id=28, VehicleId=6, GameId = 3, Class= VehicleClass.SUV},
        new VehicleGame{ Id=29, VehicleId=6, GameId = 4, Class= VehicleClass.SUV},
        new VehicleGame{ Id=30, VehicleId=6, GameId = 5, Class= VehicleClass.SUV},
        ];

    public static Garage[] GetGarages() => [
        new Garage{ Id=1, Name="Seth's Garage" }
        ];
}
