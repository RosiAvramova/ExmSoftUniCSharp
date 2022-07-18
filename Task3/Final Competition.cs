using System;

namespace Task3
{
    internal class Task3
    {
        static void Main(string[] args)
        {
            int dancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string seasson = Console.ReadLine();
            string place = Console.ReadLine();
            double money = 0;

            if (place== "Bulgaria")
            {
                money = points * dancers;
                if (seasson== "summer")
                {
                    money = money * (1 - 5.0 / 100);
                }
                else if (seasson== "winter")
                {
                    money = money * (1 - 8.0 / 100);
                }
            }
            else if (place == "Abroad")
            {
                money = (dancers * points)*1.5;
                if (seasson == "summer")
                {
                    money = money * (1 - 10.0 / 100);
                }
                else if (seasson == "winter")
                {
                    money = money * (1 - 15.0 / 100);
                }
            }
            double leftMoney = money * 0.25;
            double charity = money * 0.75;
            double moneyForDancers = leftMoney / dancers;
            Console.WriteLine($"Charity - {charity:f2}");
            Console.WriteLine($"Money per dancer - {moneyForDancers:f2}");

        }
    }
}
