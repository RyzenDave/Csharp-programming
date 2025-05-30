namespace QinshiftClass10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = num1;
            num2 = 50;

            Console.WriteLine(num1);
            Console.WriteLine(num2);

            List<int> intlist = new List<int> { 1,2, 3, 4, 5 };
            List<int> intlist2 = intlist ;
            intlist[1] = 1000;
            intlist[2] = 2131532647;   
            intlist.ForEach(n => Console.WriteLine(n));
            intlist2.ForEach(n => Console.WriteLine(n));

            User user1 = new User("Alice", "Smith", 28);
            User user2 = new User("Bob", "Johnson", 35);
            User user3 = new User("Charlie", "Williams", 22);
            User user4 = new User("Diana", "Brown", 41);
            User user5 = new User("Ethan", "Davis", 30);
            User john = new User("John", "Doe", 20);

            User john2 = john;
            john2.Age = 70;

            john.PrintInfo();
            john2.PrintInfo();

            Console.WriteLine(" -- OBJ LIFECYCLE STUFFS --");

            void TestObject()
            {
                User bob = new User("Bob", "Smith", 30);
                User john = new User("Johns", "Johnson", 25);
                Console.WriteLine("Logic with bob object...");
                bob.PrintInfo();
                Console.WriteLine("mor logik");
                john.PrintInfo();
            }
        }
    }
}
