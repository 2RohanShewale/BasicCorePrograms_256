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
            Console.WriteLine("1. Flipcoin\n2. Leap Year");
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

            }

            Console.ReadKey();
        }
    }
}
