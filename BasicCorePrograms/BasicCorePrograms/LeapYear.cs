using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class LeapYear
    {
        public void Display()
        {
            Console.WriteLine("\n*_____Leap Year____*");
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                        Console.WriteLine("It is a leap year.");
                    else
                        Console.WriteLine("It is not a leap year");

                }
                else
                {
                    Console.WriteLine("It is a leap Year");
                }
            }
            else
            {
                Console.WriteLine("It's Not a leap year");
            }
            Program.Main();
        }
    }
}
