namespace Async
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            void SendMessages()
            {
                Console.WriteLine("Getting ready...");
                Thread.Sleep(1000);
                Console.WriteLine("Msg arrived!");
                Thread.Sleep(1000);
                Console.WriteLine("Second msg arrived!");
                Thread.Sleep(1000);
                Console.WriteLine("Third msg arrived");
                Console.WriteLine("All msgs recieved!");
                Console.ReadLine();
                
            }
            SendMessages();
            void SendMessagesWithThreads()
            {
                Console.WriteLine("Getting ready...");
                Thread namedThread = new Thread(() => 
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("First msg arrived!");
                });
                namedThread.Start();
                new Thread (() =>
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Second msg arrived!");
                }).Start();
                new Thread(() =>
                {
                    Thread.Sleep(3000);
                    Console.WriteLine("Third msg arrived!");
                }).Start();
                Console.WriteLine("All MSGS are received!");
                Console.ReadLine();
            }
            SendMessagesWithThreads();
        }
    }
}
