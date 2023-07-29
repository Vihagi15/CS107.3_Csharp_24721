using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            int vowelCount = CountVowels(input);

            Console.WriteLine($"Number of vowels in the string: {vowelCount}");
        }

        static int CountVowels(string str)
        {
            int count = 0;

            foreach (char ch in str)
            {
                if (IsVowel(ch))
                {
                    count++;
                }
            }

            return count;
        }

        static bool IsVowel(char ch)
        {
            char lowerChar = char.ToLower(ch);
            return lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' || lowerChar == 'o' || lowerChar == 'u';
        }
    
    }
}
