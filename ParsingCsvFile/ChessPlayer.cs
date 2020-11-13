using System;
using System.Collections.Generic;
using System.Text;

namespace ChessPlayers
{
    class ChessPlayer
    {
        public int Rank { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Country { get; set; }
        public int Rating { get; set; }
        public int Games { get; set; }
        public int BirthYear { get; set; }

        public override string ToString()
        {
            return $"Rank: {Rank}\n" +
                $"Full name: {FirstName} {LastName}\n" +
                $"Title: {Title}\n" +
                $"Country: {Country}\n" +
                $"Rating: {Rating}\n" +
                $"Games: {Games}\n" +
                $"BirthYear: {BirthYear}\n";
        }

        public static ChessPlayer ParseFideCsv(string line)
        {
            string[] parts = line.Split(';');
            return new ChessPlayer()
            {
                Rank = int.Parse(parts[0]),
                FirstName = parts[1].Split(',')[0].Trim(),
                LastName = parts[1].Split(',')[1].Trim(),
                Title = parts[2],
                Country = parts[3],
                Rating = int.Parse(parts[4]),                
                Games = int.Parse(parts[5]),
                BirthYear = int.Parse(parts[6]),
            };
        }

    }
}
