namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Shapes circle = new Circle(5);
                circle.Display();

                Console.WriteLine();

                Shapes triangle = new Triangle(3, 4, 5);
                triangle.Display();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            //nezz kako da upotrebim classes vo main.
        }
    }
}
