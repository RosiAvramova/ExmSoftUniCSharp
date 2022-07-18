using System;

namespace Task5
{
    internal class Task5
    {
        static void Main(string[] args)
        {
            
            int winScore =0;
            string winName = string.Empty;
            int score = 0;
            string name = Console.ReadLine();

            while (name!="END")
            {  
               score = int.Parse(Console.ReadLine());
                if (score>winScore)
                {
                    winScore=score;
                    winName = name;
                }
                 name = Console.ReadLine();
                if (winScore>=10)
                {
                    break;
                }
                

            }


           
                 Console.WriteLine($"{winName} is the best player!");

                if (winScore >=3)
                {
                    Console.WriteLine($"He has scored {winScore} goals and made a hat-trick !!!");
                }
                else
                {
                    Console.WriteLine($"He has scored {winScore} goals.");
                }
            
        }
    }
}
