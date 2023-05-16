using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberGroups = int.Parse(Console.ReadLine());
            int climbersMusala = 0;
            int climbersMontblanc = 0;
            int climbersKilimanjaro = 0;
            int climbersK2 = 0;
            int climbersEverest = 0;
            int totalClimbers = 0;
            double percentMusala = 0;
            double percentMontblanc = 0;
            double percentKilimanjaro = 0;
            double percentK2 = 0;
            double percentEverest = 0;

            for (int i = 1; i <= numberGroups; i++)
            {
                int peopleGroup = int.Parse(Console.ReadLine());

                if (peopleGroup <= 5)
                {
                    climbersMusala += peopleGroup;
                    totalClimbers += peopleGroup;
                }
                else if (peopleGroup > 5 && peopleGroup <= 12)
                {
                    climbersMontblanc += peopleGroup;
                    totalClimbers += peopleGroup;
                }
                else if (peopleGroup > 12 && peopleGroup <= 25)
                {
                    climbersKilimanjaro += peopleGroup;
                    totalClimbers += peopleGroup;
                }
                else if (peopleGroup > 25 && peopleGroup <= 40)
                {
                    climbersK2 += peopleGroup;
                    totalClimbers += peopleGroup;
                }
                else
                {
                    climbersEverest += peopleGroup;
                    totalClimbers += peopleGroup;
                }
            }

            percentMusala = (climbersMusala * 100.0) / totalClimbers;
            percentMontblanc = (climbersMontblanc * 100.0) / totalClimbers;
            percentKilimanjaro = (climbersKilimanjaro * 100.0) / totalClimbers;
            percentK2 = (climbersK2 * 100.0) / totalClimbers;
            percentEverest = (climbersEverest * 100.0) / totalClimbers;

            Console.WriteLine($"{percentMusala:F2}%");
            Console.WriteLine($"{percentMontblanc:F2}%");
            Console.WriteLine($"{percentKilimanjaro:F2}%");
            Console.WriteLine($"{percentK2:F2}%");
            Console.WriteLine($"{percentEverest:F2}%");
        }
    }
}