using System;
using System.Collections.Generic;
using System.Linq;

namespace Gauss__Trick
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine()
                                         .Split()
                                         .Select(double.Parse)
                                         .ToList();
            int maxIndex = nums.Count / 2;

            for (int i = 0; i < maxIndex; i++)
            {
                nums[i] += nums[nums.Count - 1];
                nums.Remove(nums[nums.Count - 1]);
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
