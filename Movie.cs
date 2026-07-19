using System;

/*
Name: Zulisa Cruz
Date Completed: July 18, 2026
Description: This program displays a movie title and running time.
The running time defaults to 90 minutes when it is not provided.
Resources Used: Course materials and class notes.
*/

namespace Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMovie("The Lion King");

            Console.WriteLine();

            DisplayMovie("Avengers: Endgame", 181);
        }

        static void DisplayMovie(string movieName, int minutes = 90)
        {
            Console.WriteLine($"Movie: {movieName}");
            Console.WriteLine($"Running Time: {minutes} minutes");
        }
    }
}