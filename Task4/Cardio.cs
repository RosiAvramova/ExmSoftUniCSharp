using System;

namespace Task4
{
    internal class Cardio
    {
        static void Main(string[] args)
        {
            int runningDays = int.Parse(Console.ReadLine());
            double passedKillo = double.Parse(Console.ReadLine());
            double totalPassedKilo = passedKillo;


            for (int i = 1; i <= runningDays; i++)
            {
                int purcent = int.Parse(Console.ReadLine());
                double current = passedKillo * (1 + purcent / 100.0);
                passedKillo = current;
                totalPassedKilo += passedKillo;
            }
            if (totalPassedKilo >= 1000)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(totalPassedKilo - 1000)} more kilometers!");
            }
            else
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - totalPassedKilo)} more kilometers");
            }
        }
    }
}
