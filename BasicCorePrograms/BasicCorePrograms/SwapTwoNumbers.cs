using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class SwapTwoNumbers
    {
        public void swap()
        {
            Console.WriteLine("\n*_____Swap Two Numbers_____*");
            Console.WriteLine("Enter numbers");
            Console.Write("A: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int extra = firstNumber;
            firstNumber = secondNumber;
            secondNumber = extra;

            Console.WriteLine("After Swap");

            Console.WriteLine("A: " + firstNumber);
            Console.WriteLine("B: " + secondNumber);

            Program.Main();
        }
    }
}
