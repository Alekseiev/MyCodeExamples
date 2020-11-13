using System;
using System.IO;
using System.Linq;

namespace ChessPlayers
{
    class Program
    {
        static void Main(string[] args)
        {
            RusPlayers("Top20ChessPlayers.csv");
        }

        static void RusPlayers(string pathToDir)
        {
            var rusPlayers = File.ReadAllLines(pathToDir)
                .Skip(1)
                .Select(ChessPlayer.ParseFideCsv)
                .Where(player => player.Country == "RUS")
                .OrderByDescending(player => player.Rating)
                .ToList();

            foreach (var player in rusPlayers)
            {
                Console.WriteLine(player);
            }
        }
    }
}
