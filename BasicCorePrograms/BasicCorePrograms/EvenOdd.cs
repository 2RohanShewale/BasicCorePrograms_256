using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class EvenOdd
    {
        public void EvenOrOdd()
        {
            Console.WriteLine("\n*_____Even Or Odd_____*");
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine($"{num} is even number");
            else
                Console.WriteLine($"{num} is Odd number");
            Program.Main();

        }
    }
}
