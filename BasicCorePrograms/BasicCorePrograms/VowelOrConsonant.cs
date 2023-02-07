using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class VowelOrConsonant
    {
        string vowels = "aeiou";
        bool isVowel = false;
        public void VowelConsonant()
        {
            Console.WriteLine("\n*_____Vowel Or Consonant_____*");
            Console.Write("Enter an Alphabet: ");
            char alphabet = (Convert.ToChar(Console.ReadLine().ToLower()));

            for (int i = 0; i < vowels.Length; i++)
            {
                if (alphabet == vowels[i])
                {
                    isVowel = true;
                    break;
                }
            }

            if (isVowel)
                Console.WriteLine("It is Vowel");
            else
                Console.WriteLine("It is Consonant");
            Program.Main();
        }
    }
}
