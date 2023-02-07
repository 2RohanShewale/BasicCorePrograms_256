using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class Largest
    {
        int max = 0;
        public void LargestAmongThree()
        {
            Console.WriteLine("\n*_____Largest Among Three_____*");
            Console.Write("Enter 1st Number: "); int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd Number: "); int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 3rd Number: "); int thirdNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > max)
                max = firstNumber;
            if (secondNumber > max)
                max = secondNumber;
            if (thirdNumber > max)
                max = thirdNumber;

            Console.WriteLine($"{max} is the largest.");
            Program.Main();
        }
    }
}
