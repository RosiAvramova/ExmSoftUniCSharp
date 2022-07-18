using System;

namespace ExmSoftUniCSharp
{
    internal class preparations
    {
        static void Main(string[] args)
        {
            double paper = 5.80;
            double cloth = 7.20;
            double glue = 1.20;
            double totalPrice = 0;
            int numOfPaper = int.Parse(Console.ReadLine());
            int numOfCloth = int.Parse(Console.ReadLine());
            double numOfGlue = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());
            double paperPrice = numOfPaper * paper;
            double cottonPrice = numOfCloth * cloth;
            double gluePrice = numOfGlue * glue;
            totalPrice = ((paperPrice + cottonPrice + gluePrice)*(1-discount/100.0));
            

            Console.WriteLine($"{totalPrice:f3}");
        }
    }
}
