using System;

namespace Task6
{
    internal class Task6
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int n3 = number % 10;
            int n2 = (number / 10)%10;
            int n1 = (number / 100)%10;
            int result = 0;

            for (int i = 1; i <= n3; i++)
            {
                for (int j = 1; j <= n2; j++)
                {
                    for (int k = 1; k <= n1; k++)
                    {    result = i * j * k;
                        Console.WriteLine($"{i} * {j} * {k} = {result};");
                    }

                }

            }
        }
    }
}
