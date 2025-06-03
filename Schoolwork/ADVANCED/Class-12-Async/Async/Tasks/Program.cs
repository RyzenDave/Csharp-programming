namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("app starting...");

            //single task example 

            Task myTask = new Task(() => 
            {
                Console.WriteLine("Task started...");
                Thread.Sleep(2000);
                Console.WriteLine("Task completed!");
            });
            myTask.Start();

            // Single task with a return type

            Task<int> taskWvalue = new Task<int>(() =>
            {
                Console.WriteLine("Task with return started...");
                Thread.Sleep(2000);
                Console.WriteLine("Task with return completed!");
                return 10;
            });

            Console.ReadLine();
            
            taskWvalue.Start();

            

        }
         
    }
}
