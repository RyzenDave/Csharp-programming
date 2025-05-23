using Task1.Models;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var europeanCars = CarsData.Cars.Where(car => car.Origin == "Europe").ToList();
            Console.WriteLine("=== EUROPEAN CARS ===");
            foreach (var car in europeanCars)
            {
                Console.WriteLine(
                    $"Model: {car.Model}\n" +
                    $"Origin: {car.Origin}\n" +
                    $"MPG: {car.MilesPerGalon}, HP: {car.HorsePower}, Cylinders: {car.Cylinders}\n" +
                    $"Weight: {car.Weight} lbs, 0-100km/h: {car.AccelerationTime}s\n" +
                    new string('-', 30) // Separator line
                );
            }


            //new query 




            //new query





        }
    }
}
