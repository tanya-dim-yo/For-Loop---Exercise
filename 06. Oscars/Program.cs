using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorsName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int examiners = int.Parse(Console.ReadLine());

            for (int i = 1; i <= examiners; i++)
            {
                string examinersName = Console.ReadLine();
                double examinersPoints = double.Parse(Console.ReadLine());

                academyPoints += (examinersName.Length * examinersPoints) / 2.0;

                if (academyPoints > 1250.5)
                {
                    break;
                }
            }

            if (academyPoints > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorsName} got a nominee for leading role with {academyPoints:F1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actorsName} you need {(1250.5 - academyPoints):F1} more!");
            }
        }
    }
}