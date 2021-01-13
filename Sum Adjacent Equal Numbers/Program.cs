using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine()
                              .Split(' ')
                              .ToList();
            var result = new List<double>();

            foreach (var inputNum in input)
            {
                result.Add(double.Parse(inputNum));
            }

            for (var i = 0; i < result.Count - 1; i++)
            {
                if (result[i] == result[i + 1])
                {

                    result[i] = result[i] + result[i + 1];
                    result.Remove(result[i + 1]);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
