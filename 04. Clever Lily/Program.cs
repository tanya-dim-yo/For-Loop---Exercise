using System;

namespace CleverLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int savedMoney = 0;
            int moneyForBirthday = 10;
            int cntToys = 0;

            for (int currentYear = 1; currentYear <= age; currentYear++)
            {
                if (currentYear % 2 == 0)
                {
                    savedMoney += (moneyForBirthday - 1);
                    moneyForBirthday += 10;
                }
                else
                {
                    cntToys++;
                }
            }

            savedMoney += cntToys * toyPrice;

            Console.WriteLine(savedMoney >= washingMachinePrice ? $"Yes! {(savedMoney - washingMachinePrice):0.00}" : $"No! {(washingMachinePrice - savedMoney):0.00}");
        }
    }
}