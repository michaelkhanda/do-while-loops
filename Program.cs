using System;

namespace DOWHILELOOP2_ContinueandBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, total = 0;


            do
            {
                Console.WriteLine("Enter a number:");
                int score = int.Parse(Console.ReadLine());
                if ((score > 100) || (score < 0))
                continue;
                total = total + score;
                i++;

            } while (i < 5);
            Console.WriteLine(total);
        }
    }
}
