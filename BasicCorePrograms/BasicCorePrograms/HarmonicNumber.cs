using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class HarmonicNumber
    {
        float harmonic = 1;
        public void Harmonic()
        {
            Console.WriteLine("\n*_____Harmonic Number______*");
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                for (int i = 2; i <= number; i++)
                {
                    harmonic += (float)1 / i;
                }
            }
            else { Console.WriteLine("Enter number above 0"); }

            Console.WriteLine($"{number}th harnomic number is {harmonic}");
            Program.Main();
        }
    }
}
