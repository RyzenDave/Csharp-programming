
















class Program
{
    static void SayHello(string person)
    {
        Console.WriteLine($"Hello there dear, {person}");
    }

    static void SayGoodBye(string person)
    {
        Console.WriteLine($"Goodbye {person}, see you next time!");
    }

    static void PrintNumber(int number)
    {
        Console.WriteLine(number);
    }

    public delegate void SayDelegate(string person);

    static void SayWhatever(string whatever, SayDelegate sayDel)
    {
        Console.WriteLine("ChatBot says");
        sayDel(whatever);
    }

    public delegate int CalculatorDelegate(int a, int b);

    static void MasterCalculator(int a, int b, CalculatorDelegate calcDel)
    {
        int result = calcDel(a, b);
        Console.WriteLine($"Result: {result}");
    }

    static void Main(string[] args)
    {
        #region Delegates - Declare and Instantiating a delegate
        SayDelegate sayHelloDel = new SayDelegate(SayHello);
        SayDelegate sayGoodByeDel = new SayDelegate(SayGoodBye);
        SayDelegate sayWoowDel = new SayDelegate(x => Console.WriteLine($"Woooow {x}"));

        //SayDelegate printNumDel = new SayDelegate(PrintNumber);   ---> this will not work, because the signature of the PrintNumber method doesn't fit with the signature of the SayDelegate delegate

        sayHelloDel("Bob");
        sayGoodByeDel("Martin");
        sayWoowDel("Slave");
        #endregion
        #region Passing a method to a delegate parameter
        Console.WriteLine("=== Passing a delegate as a parameter to another method ===");
        SayWhatever("bob", SayHello);
        SayWhatever("Martin", SayGoodBye);
        SayWhatever("Ana", x =>
        {
            Console.WriteLine($"Hi {x}, Before the ChatBOt says somethin welcome on behalf of our company!");
        });
        #endregion
        #region Making a high order method
        MasterCalculator(123, 234, (a, b) => a + b);
        #endregion
    }
}
