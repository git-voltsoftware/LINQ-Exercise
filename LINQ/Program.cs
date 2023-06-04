using System;
using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>
            {
                "Super Mario Bros.",
                "The Legend of Zelda",
                "Sonic the Hedgehog",
                "Mega Man",
                "Street Fighter II",
                "Final Fantasy VII",
                "Pokemon Red/Blue",
                "GoldenEye 007",
                "Resident Evil 4",
                "Grand Theft Auto V"
            };

            // Order By

            var sortedGames = videoGames.OrderBy(game => game);

            // Linq Method

            gameNames.Sort((a,b) => a.Length.CompareTo(b.Length));

            foreach (var game in sortedGames)
            {
                Console.WriteLine(game);
            }

            // Lambda expression 

            var numGamesLambda = videoGames.Count(game => true);

            Console.WriteLine($"Number of video games in this list: {numGamesLambda}");
        }
    }
}