using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class PowerOfTwo
    {
        public void Table()
        {
            Console.WriteLine("\n*____Power Of Two_____*");
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 0 && number < 31)
            {
                for (int i = 0; i <= number; i++)
                {
                    Console.WriteLine($"2^{i} = {Math.Pow(2, i)}");
                }
            }
            else { Console.WriteLine("Number should start from 0 to 30"); Table(); }
            Program.Main();
        }
    }
}
