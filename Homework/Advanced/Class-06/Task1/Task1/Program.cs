using Task1.Models;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region EUROCARS
            var europeanCars = CarsData.Cars.Where(car => car.Origin == "Europe").ToList();
            Console.WriteLine("============  EUROPEAN CARS ===============");
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
            #endregion
            #region MORE_THAN_6_CYLINDERS
            var sixCylinder = CarsData.Cars.Where(car => car.Cylinders > 6).ToList();
            Console.WriteLine("================== MORE THAN 6 CYLINDERS ====================");
            foreach (var car in sixCylinder)
            {
                Console.WriteLine(
                    $"Model: {car.Model}\n" +
                    $"Origin: {car.Origin}\n" +
                    $"MPG: {car.MilesPerGalon}, HP: {car.HorsePower}, Cylinders: {car.Cylinders}\n" +
                    $"Weight: {car.Weight} lbs, 0-100km/h: {car.AccelerationTime}s\n" +
                    new string('-', 30) // Separator line
                );
            }
            var fourBangerOver110HP = CarsData.Cars
                .Where(car => car.Cylinders == 4 && car.HorsePower > 110)
                .ToList();
            #endregion
            #region 4_bangers_over_110HP
            Console.WriteLine("================== 4 BANGERS OVER 110HP ====================");
            foreach (var car in fourBangerOver110HP)
            {
                Console.WriteLine(
                    $"Model: {car.Model}\n" +
                    $"Origin: {car.Origin}\n" +
                    $"MPG: {car.MilesPerGalon}, HP: {car.HorsePower}, Cylinders: {car.Cylinders}\n" +
                    $"Weight: {car.Weight} lbs, 0-100km/h: {car.AccelerationTime}s\n" +
                    new string('-', 30) // Separator line
                );
            }
            #endregion
            #region Origin
            Console.WriteLine("================== CAR COUNTS BY ORIGIN ====================");
            var originCounts = CarsData.Cars
                .GroupBy(car => car.Origin)
                .Select(g => $"{g.Key} {g.Count()} models")
                .ToList();
            Console.WriteLine(string.Join("\n", originCounts));
            #endregion
            #region 220HPAVGCONSUMPTION



            var over220HPAVGCONSUMPTION = CarsData.Cars
                .Where(car => car.HorsePower > 200)
                .ToList();

            if (over220HPAVGCONSUMPTION.Any())
            {
                var minConsumption = over220HPAVGCONSUMPTION.Min(car => car.MilesPerGalon);
                var maxConsumption = over220HPAVGCONSUMPTION.Max(car => car.MilesPerGalon);
                var avgConsumption = over220HPAVGCONSUMPTION.Average(car => car.MilesPerGalon);

                Console.WriteLine("================== 200+ HP CARS FUEL CONSUMPTION ====================");
                Console.WriteLine($"Min MPG: {minConsumption}");
                Console.WriteLine($"Avg MPG: {avgConsumption:F2}");
                Console.WriteLine($"Max MPG: {maxConsumption}");
            }
            #endregion
            #region Top_3SlowToFast
            Console.WriteLine("=================== TOP 3 FASTEST =====================");
            var top3Fastest = CarsData.Cars
                .OrderBy(car => car.AccelerationTime) // Lower AccelerationTime = faster
                .Take(3)
                .ToList();
            foreach (var car in top3Fastest)
            {
                Console.WriteLine(
                    $"Model: {car.Model}\n" +
                    $"Origin: {car.Origin}\n" +
                    $"MPG: {car.MilesPerGalon}, HP: {car.HorsePower}, Cylinders: {car.Cylinders}\n" +
                    $"Weight: {car.Weight} lbs, 0-100km/h: {car.AccelerationTime}s\n" +
                    new string('-', 30) // Separator line
                );
            }
            #endregion
            #region TOTALWEIGHT6BANGER
            var totalWeight6Banger = CarsData.Cars
                .Where(car => car.Cylinders == 6)
                .Sum(car => car.Weight)
                        ;


            Console.WriteLine("================== TOTAL WEIGHT OF 6-CYLINDER CARS ====================");
            Console.WriteLine($"Total Weight: {totalWeight6Banger} lbs");
            #endregion

            #region MPG_EVENAMOUNT
            var evenCylinders = CarsData.Cars
              .Where(car => car.Cylinders % 2 == 0)
               .ToList();


            Console.WriteLine("================== EVEN CYLINDER CARS ====================");
            if(evenCylinders.Any())
            {
                var avgConsumption = evenCylinders.Average(car => car.MilesPerGalon);
                Console.WriteLine($"Avg MPG of even cylinder cars: {avgConsumption:F2}");
            }

            




            #endregion

        }

    }
}
