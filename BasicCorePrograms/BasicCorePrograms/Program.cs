using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("\n*__________Basic Core Peograms__________*");
            Console.WriteLine("1. Flipcoin\n2. Leap Year\n3. Power Of Two\n4. Harmonic Number\n5. Prime Factors\n6. Quotient And Remainder\n7. Even Or Odd");
            Console.Write("Enter a Options: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.Display();
                    break;
                case 2:
                    LeapYear leapYear = new LeapYear();
                    leapYear.Display();
                    break;
                case 3:
                    PowerOfTwo power = new PowerOfTwo();
                    power.Table();
                    break;
                case 4:
                    HarmonicNumber harmonic = new HarmonicNumber();
                    harmonic.Harmonic();
                    break;
                case 5:
                    PrimeFactors prime = new PrimeFactors();
                    prime.Factors();
                    break;
                case 6:
                    QuotientRemainder quotient = new QuotientRemainder();
                    quotient.Quotient();
                    break;
                case 7:
                    EvenOdd operation = new EvenOdd();
                    operation.EvenOrOdd();
                    break;

            }

            Console.ReadKey();
        }
    }
}
