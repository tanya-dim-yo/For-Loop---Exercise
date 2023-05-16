using System;

namespace TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberTournaments = double.Parse(Console.ReadLine());
            int totalPoints = int.Parse(Console.ReadLine());
            double pointsTournaments = 0;
            double tournamentsWinner = 0;

            for (int i = 1; i <= numberTournaments; i++)
            {
                string level = Console.ReadLine();

                if (level == "SF")
                {
                    totalPoints += 720;
                    pointsTournaments += 720;
                }
                else if (level == "F")
                {
                    totalPoints += 1200;
                    pointsTournaments += 1200;
                }
                else if (level == "W")
                {
                    totalPoints += 2000;
                    pointsTournaments += 2000;
                    tournamentsWinner++;
                }
            }

            double averagePoints = Math.Floor(pointsTournaments / numberTournaments);
            double percentWinner = (tournamentsWinner * 100.0) / numberTournaments;

            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{percentWinner:F2}%");
        }
    }
}