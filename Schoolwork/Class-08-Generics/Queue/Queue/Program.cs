namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a sample queue of integers
            Queue<int> numbers = new Queue<int>(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            // 1. Filtering: Get even numbers from the queue
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));

            // 2. Transformation: Square each number in the queue
            var squaredNumbers = numbers.Select(n => n * n);
            Console.WriteLine("Squared Numbers: " + string.Join(", ", squaredNumbers));

            // 3. Sorting: Order numbers in descending order
            var descendingNumbers = numbers.OrderByDescending(n => n);
            Console.WriteLine("Descending Order: " + string.Join(", ", descendingNumbers));

            // 4. Aggregation: Compute the sum of all numbers
            int sum = numbers.Sum();
            Console.WriteLine("Sum of Numbers: " + sum);

            // 5. Partitioning: Take the first 5 elements from the queue
            var firstFive = numbers.Take(5);
            Console.WriteLine("First 5 Numbers: " + string.Join(", ", firstFive));



        }
    }
}
