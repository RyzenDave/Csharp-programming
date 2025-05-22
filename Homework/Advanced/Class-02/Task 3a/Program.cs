namespace Task_3a.Models;


internal class Program
{
    static void Main(string[] args)
    {
        Triangle myTriangle = new Triangle(
            sideA: 3,
            sideB: 4,
            sideC: 5,
            @base: 4,
            height: 3
        );

        // Call the methods
        myTriangle.CalculateArea();      // Output: "Triangle Area: 6"
        myTriangle.CalculatePerimeter(); // Output: "Triangle Perimeter: 12"
        Circle mycircle = new Circle(
            radius: 5
            );

        mycircle.CalculatePerimeter();
        mycircle.CalculateArea();
    }
}
