namespace Async_Await
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            async Task<string> sendMsgAsync(string msg)
            {
                Console.WriteLine("Sending msg");
                await Task.Run(() =>
                {
                    Thread.Sleep(7000);
                    Console.WriteLine($"The message {msg} was sent!");
                });
                return "Message sent";
            }

            void showAd(string product)
            {
                Console.WriteLine("ADVERT FOR NIGGERS");
                Console.WriteLine("Buy the best product in the world");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(product);
                Console.ResetColor();
                Console.WriteLine(" NOW! AND GET ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("FREE");
                Console.ResetColor();
                Console.WriteLine("NIGGERSLAVES");
            }

            showAd("NIGGER SLAVES");
            // Example usage of sendMsgAsync to avoid CS8321
            await sendMsgAsync("Hello World");

        }
    }
}
