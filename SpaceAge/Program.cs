/// <summary>
/// Given an age in seconds, calculate how old someone would be on: 
/// Earth: orbital period 365.25 Earth days, or 31557600 seconds
/// Mercury: orbital period 0.2408467 Earth years
/// Venus: orbital period 0.61519726 Earth years
/// Mars: orbital period 1.8808158 Earth years
/// Jupiter: orbital period 11.862615 Earth years
/// Saturn: orbital period 29.447498 Earth years
/// Uranus: orbital period 84.016846 Earth years
/// Neptune: orbital period 164.79132 Earth years
/// </summary>
namespace SpaceAge
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int ageInSeconds = 1000000000;

            // Initiating a new class for the space age calculations
            var spaceCalc = new SpaceCalculations(ageInSeconds);

            Console.WriteLine("Select a planet!");
            string planetName = Console.ReadLine();
            switch (planetName)
            {
                case "Earth":
                    Console.WriteLine($"Your age on {planetName} = {spaceCalc.OnEarth()}");
                    break;
                case "Mercury":
                    Console.WriteLine($"Your age on {planetName} = {spaceCalc.OnMercury()}");
                    break;
                case "Venus":
                    Console.WriteLine($"Your age on {planetName} = {spaceCalc.OnVenus()}");
                    break;
                case "Mars":
                    Console.WriteLine($"Your age on {planetName} = {spaceCalc.OnMars()}");
                    break;
                case "Jupiter":
                    Console.WriteLine($"Your age on {planetName} = {spaceCalc.OnJupiter()}");
                    break;
                case "Neptune":
                    Console.WriteLine($"Your age on {planetName} = {spaceCalc.OnNeptune()}");
                    break;
                case "Uranus":
                    Console.WriteLine($"Your age on {planetName} = {spaceCalc.OnUranus()}");
                    break;
                case "Saturn":
                    Console.WriteLine($"Your age on {planetName} = {spaceCalc.OnSaturn()}");
                    break;
                default:
                    Console.WriteLine("No planet was chosen...blasting out of this solar system...goood bye!");
                    Console.ReadKey(); 
                    break;
            }

            Console.WriteLine("Program execution has completed, you may press any key to exit");

            // Making sure that the application can terminate gracefully
            Console.ReadKey(); 
        }
    }
}