using Error_Handling.Models;
using System.Linq.Expressions;

namespace Error_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exceptions
            Console.WriteLine("===== Number Examples =====");
            Console.WriteLine("enter a number:");
            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine($"The number you entered is {number}");
            }
            catch (Exception ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("wrong input tryagain");
                Console.WriteLine($"Exception mesage: {ex.Message}");
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("The number example finished!");
                Console.ReadLine();
            }
            Console.WriteLine("==== Self thrown exception ====");
            Console.WriteLine("Enter a letter a or b");

            try
            {
                string letter = Console.ReadLine().ToLower().Trim();
                if (letter == "a" || letter == "b")
                {
                    Console.WriteLine("Congrats, you have entered A or B!");
                }
                else
                {
                    throw new Exception("That was not letter a or letter b, sorry!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine($"More info about the exception: {ex?.InnerException?.Message}");
            }
            finally
            {
                Console.WriteLine("Press any key to exit.");
                Console.ReadLine();
            }
            Console.WriteLine("===== Handling specific exceptions! =====");
            try
            {
                Console.WriteLine("Enter some character!");
                string? input = Console.ReadLine();
                char char1 = char.Parse(input);
                Console.WriteLine($"You have entered the character: {char1}");

                int[] numbers = new int[2] { 1, 2 };
                numbers[2] = 4;

                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("The diffusion of the numbers is :" + num1 / num2);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("that is not an array index!");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("dont try to devide by zero, thats stoopid");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Type Error");
            }
            #endregion

            #region Exceptions from Methods
            // Example: Calling HumanSkill1 with a Human having no skills triggers an exception.
            try
            {
                Human humanWithoutSkills = new Human { Name = "John", Skills = new List<Skill>() };
                HumanSkill1(humanWithoutSkills);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in HumanSkill1: {ex.Message}");
            }

            static void HumanSkill1(Human human)
            {
                if (human == null)
                {
                    throw new ArgumentNullException(nameof(human), "Human parameter cannot be null.");
                }

                if (human.Skills == null || human.Skills.Count == 0)
                {
                    throw new Exception("Human has no skills!");
                }

                Console.WriteLine($"Human {human.Name} has the following skills:");
                foreach (var skill in human.Skills)
                {
                    Console.WriteLine($"- {skill.Name}: {skill.Points} points");
                }
            }
            #endregion
        }
    }
}
