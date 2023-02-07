using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class PrimeFactors
    {
        public void Factors()
        {
            Console.WriteLine("\n*_____Prime Factors_____*");
            Console.Write("Enter a Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The prime factors of {number} are ");
            while (number % 2 == 0)
            {
                number /= 2;
                Console.Write(2 + " ");
            }
            for (int i = 3; i <= number / 2; i++)
            {
                while (number % i == 0)
                {
                    number /= i;
                    Console.Write(i + " ");
                }
            }
            if (number != 1)
                Console.Write(number);

            Program.Main();
        }
    }
}
