using Exercise1.Models;
using System;
using System.Collections.Generic;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Scary Movie", Genre.Comedy, 4, 2.5);
            Movie movie2 = new Movie("American Pie", Genre.Comedy, 4, 2.5);
            Movie movie3 = new Movie("Saw", Genre.Horror, 4, 2.5);
            Movie movie4 = new Movie("The Shining", Genre.Horror, 4, 2.5);
            Movie movie5 = new Movie("Rambo", Genre.Action, 4, 2.5);
            Movie movie6 = new Movie("The Terminator", Genre.Action, 4, 2.5);
            Movie movie7 = new Movie("Forrest Gump", Genre.Drama, 4, 2.5);
            Movie movie8 = new Movie("12 Angry Men", Genre.Drama, 4, 2.5);
            Movie movie9 = new Movie("Passengers", Genre.SciFi, 4, 2.5);
            Movie movie10 = new Movie("Interstellar", Genre.SciFi, 4, 2.5);
            List<Movie> MovieSet1 = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };

            Movie movie11 = new Movie("Airplane", Genre.Comedy, 4, 2.5);
            Movie movie12 = new Movie("Johnny English", Genre.Comedy, 4, 2.5);
            Movie movie13 = new Movie("The Ring", Genre.Horror, 4, 2.5);
            Movie movie14 = new Movie("Sinister", Genre.Horror, 4, 2.5);
            Movie movie15 = new Movie("RoboCop", Genre.Action, 4, 2.5);
            Movie movie16 = new Movie("Judge Dredd", Genre.Action, 4, 2.5);
            Movie movie17 = new Movie("The Social Network", Genre.Drama, 4, 2.5);
            Movie movie18 = new Movie("The Shawshank Redemption", Genre.Drama, 4, 2.5);
            Movie movie19 = new Movie("Inception", Genre.SciFi, 4, 2.5);
            Movie movie20 = new Movie("Avatar", Genre.SciFi, 4, 2.5);
            List<Movie> MovieSet2 = new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };

            Cinema cinema1 = new Cinema("Cineplex");
            cinema1.Halls = new List<int>() { 1, 2, 3, 4 };
            cinema1.Movies = MovieSet1;
            Cinema cinema2 = new Cinema("Milenium");
            cinema2.Halls = new List<int>() { 1, 2 };
            cinema2.Movies = MovieSet2;
            //try catch block
            try
            {
                Console.WriteLine("Choose a cinema:");
                Console.WriteLine($"1. {cinema1.Name}\n2. {cinema2.Name}");

                int cinemainput = int.Parse(Console.ReadLine());
                Cinema currentcinema = null;

                if (cinemainput == 1)
                {
                    currentcinema = cinema1;
                }
                else if (cinemainput == 2)
                {
                    currentcinema = cinema2;
                }
                else
                {
                    Console.WriteLine("Invalid cinema selection.");
                    return;
                }

                // Filter movies based on user choice
                Console.WriteLine("Pick if you'd like to see All movies or by genre:");
                Console.WriteLine("1. All movies");
                Console.WriteLine("2. By genre");

                int filterChoice = int.Parse(Console.ReadLine());

                if (filterChoice == 1)
                {
                    Console.WriteLine("All movies:");
                    for (int i = 0; i < currentcinema.Movies.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {currentcinema.Movies[i].Title}");
                    }
                    Console.WriteLine("Select a movie by entering its number:");
                    int movieIndex = int.Parse(Console.ReadLine()) - 1;
                    if (movieIndex >= 0 && movieIndex < currentcinema.Movies.Count)
                    {
                        Console.WriteLine($"The movie '{currentcinema.Movies[movieIndex].Title}' is playing");
                    }
                    else
                    {
                        Console.WriteLine("Invalid movie selection.");
                    }
                }s
                else if (filterChoice == 2)
                {
                    Console.WriteLine("Select a genre:");
                    Console.WriteLine("1. Horror");
                    Console.WriteLine("2. SciFi");
                    Console.WriteLine("3. Comedy");
                    Console.WriteLine("4. Action");
                    Console.WriteLine("5. Drama");
                    //didnt know how else to do this one 
                    int genreChoice = int.Parse(Console.ReadLine());
                    Genre selectedGenre;

                    switch (genreChoice)
                    {
                        case 1:
                            selectedGenre = Genre.Horror;
                            break;
                        case 2:
                            selectedGenre = Genre.SciFi;
                            break;
                        case 3:
                            selectedGenre = Genre.Comedy;
                            break;
                        case 4:
                            selectedGenre = Genre.Action;
                            break;
                        case 5:
                            selectedGenre = Genre.Drama;
                            break;
                        default:
                            Console.WriteLine("Invalid genre selection.");
                            return;
                    }
                   
                    //Makes a movie list of numbers to choose from
                    var filteredMovies = currentcinema.Movies.FindAll(m => m.Genre == selectedGenre);
                    if (filteredMovies.Count > 0)
                    {
                        Console.WriteLine($"{selectedGenre} movies:");
                        for (int i = 0; i < filteredMovies.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {filteredMovies[i].Title}");
                        }
                        Console.WriteLine("Select a movie by entering its number:");
                        int movieIndex = int.Parse(Console.ReadLine()) - 1;
                        if (movieIndex >= 0 && movieIndex < filteredMovies.Count)
                        {
                            Console.WriteLine($"The movie '{filteredMovies[movieIndex].Title}' is playing");
                        }
                        else
                        {
                            Console.WriteLine("Invalid movie selection.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No movies available for that genre.");
                    }
                }
            }

            //might not work as they should 

            catch (Exception)
            {
                Console.WriteLine("An error occurred while processing your input.");
            }
            finally
            {
                Console.WriteLine("Successful input!");
            }
        }
    }

}
