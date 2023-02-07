using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class FlipCoin
    {
        int headCount = 0;
        int tailCount = 0;
        float headPercentage;
        float tailPercentage;
        public void Display()
        {
            Console.WriteLine("\n*_____Flip Coin_____*");

            Console.Write("Enter a number of times you want to flip coin: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("You can only enter Positive number");
            }
            else
            {
                Random rand = new Random();
                for (int i = 0; i < num; i++)
                {
                    double numCheck = rand.NextDouble();
                    if (numCheck < 0.5)
                    {
                        Console.Write("Tails ");
                        tailCount++;
                    }
                    else
                    {
                        Console.Write("Heads ");
                        headCount++;
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"Heads: {headCount} times");
                Console.WriteLine($"Tails: {tailCount} times");

                headPercentage = (float)headCount / num * 100;
                tailPercentage = (float)tailCount / num * 100;
                Console.WriteLine($"Head percentage: {headPercentage}%");
                Console.WriteLine($"Tail percentage: {tailPercentage}%");
            }
            Program.Main();
        }
    }
}
