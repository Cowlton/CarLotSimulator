using System;

namespace CarLotSimulator;

public class Car
{
    public string Year {get; set; }
    public string Make {get; set; }
    public string Model {get; set; }
    public string EngineNoise {get; set; }
    public string HonkNoise {get; set; }
    public bool IsDriveable {get; set; }

    public void MakeEngineNoise(string engineNoise)
    {
        Console.WriteLine($"This car goes {engineNoise}");
    }

    public void MakeHonkNoise(string honkNoise)
    {
        Console.WriteLine($"The horn of this car gose {honkNoise}");
    }

    public Car(string year, string make, string model, string engineNoise, string honkNoise)
    {
        Year = year;
        Make = make;
        Model = model;
        EngineNoise = engineNoise;
        HonkNoise = honkNoise;
    }

    public Car()
    {
        
    }
    
}