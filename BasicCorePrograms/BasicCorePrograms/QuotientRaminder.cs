using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class QuotientRemainder
    {
        int quotient = 0;
        int remainder = 0;
        public void Quotient()
        {
            Console.WriteLine("\n*_____Quotient And Remainder_____*");
            Console.Write("Enter A Divident: ");
            int divident = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter A Divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            quotient = divident / divisor;
            remainder = divident % divisor;

            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine("Remainder: " + remainder);

            Program.Main();
        }
    }
}
