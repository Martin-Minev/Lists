using System;
using System.Linq;
using System.Collections.Generic;

namespace List_Manipulation_Basics
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                        .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToList();
            List<string> command = Console.ReadLine()
                                    .Split(' ')
                                    .ToList();

            while (command[0].ToUpper() != "END")
            {
                switch (command[0].ToUpper())
                {
                    case "ADD":
                        numbers.Add(int.Parse(command[1]));
                        break;
                    case "REMOVE":
                        numbers.Remove(int.Parse(command[1]));
                        break;
                    case "REMOVEAT":
                        numbers.RemoveAt(int.Parse(command[1]));
                        break;
                    case "INSERT":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                }
                command = Console.ReadLine()
                                     .Split(' ')
                                     .ToList();
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write($"{numbers[i]}{' '}");
            }
        }
    }
}
