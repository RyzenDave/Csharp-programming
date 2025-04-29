using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ___Language_integrated_queries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>
                {
                    new Dog { Name = "Buddy",   Color = "Black",  Age = 1 },
                    new Dog { Name = "Charlie", Color = "White",  Age = 2 },
                    new Dog { Name = "Max",     Color = "Brown",  Age = 3 },
                    new Dog { Name = "Cooper",  Color = "Golden", Age = 4 },
                    new Dog { Name = "Oskar",   Color = "Spotted",Age = 5 },
                    new Dog { Name = "Rocky",   Color = "Gray",   Age = 6 },
                    // Duplicate for grouping example:
                    new Dog { Name = "Milo",    Color = "Black",  Age = 3 }
                };

            Console.WriteLine("Dogs whose names start with 'C':");
            PrintDogs(FilterByStartingLetter(dogs, 'C'));
            Console.WriteLine();

            Console.WriteLine("Dogs grouped by same age (age groups with more than one):");
            PrintGroupedDogs(GroupDogsByAge(dogs).Where(group => group.Count() > 1));
            Console.WriteLine();

            Console.WriteLine("Dogs whose names have exactly 5 letters:");
            PrintDogs(GetDogsWithNameLengthEqual(dogs, 5));
            Console.WriteLine();

            Console.WriteLine("Dogs ordered by age:");
            PrintDogs(OrderDogsByAge(dogs));
            Console.WriteLine();

            Console.WriteLine("Dogs whose color contains 'ack':");
            PrintDogs(FilterDogsByColorContains(dogs, "ack"));
            Console.WriteLine();
        }

        static void PrintDogs(IEnumerable<Dog> dogs)
        {
            var enumerator = dogs.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Name);
            }
        }

        static void PrintGroupedDogs(IEnumerable<IGrouping<int, Dog>> groupedDogs)
        {
            var enumerator = groupedDogs.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var group = enumerator.Current;
                Console.WriteLine($"Age {group.Key}: {string.Join(", ", group.Select(d => d.Name))}");
            }
        }

        // Returns dogs whose name starts with the specified letter (case-insensitive).
        static IEnumerable<Dog> FilterByStartingLetter(List<Dog> dogs, char letter)
        {
            return dogs.Where(dog => dog.Name.StartsWith(letter.ToString(), StringComparison.OrdinalIgnoreCase));
        }

        // Groups dogs by age.
        static IEnumerable<IGrouping<int, Dog>> GroupDogsByAge(List<Dog> dogs)
        {
            return dogs.GroupBy(dog => dog.Age);
        }

        // Returns dogs whose name has an exact length.
        static IEnumerable<Dog> GetDogsWithNameLengthEqual(List<Dog> dogs, int length)
        {
            return dogs.Where(dog => dog.Name.Length == length);
        }

        // Returns dogs ordered by their age.
        static IEnumerable<Dog> OrderDogsByAge(List<Dog> dogs)
        {
            return dogs.OrderBy(dog => dog.Age);
        }

        // Returns dogs whose color contains the provided substring (case-insensitive).
        static IEnumerable<Dog> FilterDogsByColorContains(List<Dog> dogs, string substring)
        {
            return dogs.Where(dog => dog.Color.IndexOf(substring, StringComparison.OrdinalIgnoreCase) >= 0);
        }
    }

}
