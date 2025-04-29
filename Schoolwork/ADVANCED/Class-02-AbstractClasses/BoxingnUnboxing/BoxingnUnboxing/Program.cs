namespace BoxingnUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int number = 42;          // Value type (lives in stack)
            object boxed = number;    // Boxing! (now on heap)
        }
    }
}
