using Task2.Models;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car();
            Vehicle motorBike = new Motorbike();
            Vehicle boat = new Boat();
            Vehicle plane = new AirPlane();

            car.DisplayInfo();       
            motorBike.DisplayInfo(); 
            boat.DisplayInfo();      
            plane.DisplayInfo();

            car.Move();
            motorBike.Move();
            boat.Move();
            plane.Move();
        }
    }
}
