using System;
using System.Collections.Generic;
using System.Linq;

class Vehicle
{
    public string Type { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int Horsepower { get; set; }
} 

class VehicleCatalogue
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<Vehicle> vehicles = new List<Vehicle>();

        while (input != "End")
        {
            Vehicle vehicle = ReadVehicle(input);

            vehicles.Add(vehicle);

            input = Console.ReadLine();
        }

        input = Console.ReadLine();
        while (input != "Close the Catalogue")
        {
            Vehicle vehicle = vehicles
                .Where(v => v.Model == input)
                .First();

            Console.WriteLine($"Type: {vehicle.Type}");
            Console.WriteLine($"Model: {vehicle.Model}");
            Console.WriteLine($"Color: {vehicle.Color}");
            Console.WriteLine($"Horsepower: {vehicle.Horsepower}");

            input = Console.ReadLine();
        }

        if (vehicles.Count(v => v.Type.ToLower() == "car") > 0)
        {
            double carAverageHorsepowers = vehicles
                .Where(v => v.Type.ToLower() == "car")
                .Select(x => x.Horsepower)
                .Average();
            Console.WriteLine($"Cars have average horsepower of: {carAverageHorsepowers:F2}.");
        }
        else
        {
            Console.WriteLine("Cars have average horsepower of: 0.00.");
        }

        if (vehicles.Count(v => v.Type.ToLower() == "truck") > 0)
        {
            double truckAverageHorsepowers = vehicles
                .Where(v => v.Type.ToLower() == "truck")
                .Select(x => x.Horsepower)
                .Average();
            Console.WriteLine($"Trucks have average horsepower of: {truckAverageHorsepowers:F2}.");
        }
        else
        {
            Console.WriteLine("Trucks have average horsepower of: 0.00.");
        }

    }

    private static Vehicle ReadVehicle(string input)
    {
        string[] vehicleInfo = input
            .Split(' ')
            .ToArray();

        // This thing below, convert first char of the string to uppercase
        vehicleInfo[0] = vehicleInfo[0].ToLower();
        vehicleInfo[0] = vehicleInfo[0]
            .First().ToString().ToUpper() + vehicleInfo[0].Substring(1);

        Vehicle person = new Vehicle()
        {
            Type = vehicleInfo[0],
            Model = vehicleInfo[1],
            Color = vehicleInfo[2],
            Horsepower = int.Parse(vehicleInfo[3])
        };

        return person;
    }
}
