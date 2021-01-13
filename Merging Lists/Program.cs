using System;
using System.Linq;
using System.Collections.Generic;

namespace Merging_Lists
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToList();
            List<int> secondNumbers = Console.ReadLine()
                                       .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToList();
            List<int> resultNumbers = new List<int>();

            for (int i = 0; i < Math.Min(numbers.Count, secondNumbers.Count); i++)
            {
                resultNumbers.Add(numbers[i]);
                resultNumbers.Add(secondNumbers[i]);
            }

            for (int i = Math.Min(numbers.Count, secondNumbers.Count); i < Math.Max(numbers.Count, secondNumbers.Count); i++)
            {
                if (i >= numbers.Count)
                {
                    resultNumbers.Add(secondNumbers[i]);
                }
                else
                {
                    resultNumbers.Add(numbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", resultNumbers));
        }
    }
}
