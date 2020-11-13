using System;
using System.Collections.Generic;

namespace CoreLessons
{
    class ParsingRomanNumerals
    {
        static void Main(string[] args)
        {
            var romNumbers = new Dictionary<char, int>()
            {
                ['I'] = 1,
                ['V'] = 5,
                ['X'] = 10,
                ['L'] = 50,
                ['C'] = 100,
                ['D'] = 500,
                ['M'] = 1000
            };

            Console.Write("Enter Romanian Numeral: ");
            string number = Console.ReadLine().ToUpper();
            int result = 0;

            for (int i = 0; i < number.Length; i++)
            {
                if (i + 1 < number.Length && romNumbers[number[i]] < romNumbers[number[i + 1]])
                {
                    result -= romNumbers[number[i]];
                }
                else
                {
                    result += romNumbers[number[i]];
                }
            }

            Console.WriteLine($"\nResult: {result}");
        }
    }
}
