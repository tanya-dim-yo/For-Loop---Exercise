using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int openedTabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int i = 1; i <= openedTabs; i++)
            {
                string website = Console.ReadLine();

                if (website == "Facebook")
                {
                    salary -= 150.0;
                }
                else if (website == "Instagram")
                {
                    salary -= 100.0;
                }
                else if (website == "Reddit")
                {
                    salary -= 50.0;
                }

                if (salary <= 0)
                {
                    break;
                }
            }

            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(Math.Round(salary));
            }
        }
    }
}