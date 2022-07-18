using System;

namespace Task2
{
    internal class Task2
    {
        static void Main(string[] args)
        {
            int missingDays = int.Parse(Console.ReadLine());
            int totalFoot = int.Parse(Console.ReadLine());
            double deerOne = double.Parse(Console.ReadLine());  
            double deerTwo = double.Parse(Console.ReadLine());
            double deerTree = double.Parse(Console.ReadLine());
            double needetFoot = (deerOne + deerTwo + deerTree) * missingDays;
            if (needetFoot<=totalFoot)
            {
                double leftFoofTWO = totalFoot - needetFoot;
                Console.WriteLine($"{Math.Floor(leftFoofTWO)} kilos of food left.");
            }
            else 
            {
                double leftFoot =needetFoot - totalFoot;
                
                Console.WriteLine($"{Math.Ceiling(Math.Abs(leftFoot))} more kilos of food are needed.");
            }
        }
    }
}
