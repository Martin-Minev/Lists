using System;
using System.Linq;
using System.Collections.Generic;

namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                        .Split(' '/*, StringSplitOptions.RemoveEmptyEntries*/)
                                        .Select(int.Parse)
                                        .ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.Remove(numbers[i]);
                    i--;
                }
            }
            numbers.Reverse();

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
        }
    }
}
