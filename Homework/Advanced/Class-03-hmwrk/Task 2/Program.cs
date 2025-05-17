using Task_2.Entities;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car();
            Vehicle motorBike = new Motorbike();
            Vehicle boat = new Boat();
            Vehicle plane = new AirPlane();

            car.DisplayInfo();       // Output: "I'm a car..."
            motorBike.DisplayInfo(); // Output: "I'm a motorbike..."
            boat.DisplayInfo();      // Output: "I'm a boat..."
            plane.DisplayInfo();     // Output: "I'm a plane..."
        }
    }
}
