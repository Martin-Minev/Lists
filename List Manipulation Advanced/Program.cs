using System;
using System.Linq;
using System.Collections.Generic;

namespace List_Manipulation_Advanced
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                        .Split(' '/*, StringSplitOptions.RemoveEmptyEntries*/)
                                        .Select(int.Parse)
                                        .ToList();
            List<string> command = Console.ReadLine()
                                    .Split(' ')
                                    .ToList();
            bool isChanged = false;

            while (command[0].ToUpper() != "END")
            {
                switch (command[0].ToUpper())
                {
                    case "ADD":
                        numbers.Add(int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "REMOVE":
                        numbers.Remove(int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "REMOVEAT":
                        numbers.RemoveAt(int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "INSERT":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "CONTAINS":
                        Console.WriteLine(numbers.Contains(int.Parse(command[1])) ? "Yes" : "No such number");
                        break;
                    case "PRINTEVEN":
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 0)));
                        break;
                    case "PRINTODD":
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 != 0)));
                        break;
                    case "GETSUM":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "FILTER":
                        string result = string.Empty;
                        switch (command[1])
                        {
                            case "<":
                                result = string.Join(" ", numbers.Where(n => n < int.Parse(command[2])));
                                break;
                            case ">":
                                result = string.Join(" ", numbers.Where(n => n > int.Parse(command[2])));
                                break;
                            case "<=":
                                result = string.Join(" ", numbers.Where(n => n <= int.Parse(command[2])));
                                break;
                            case ">=":
                                result = string.Join(" ", numbers.Where(n => n >= int.Parse(command[2])));
                                break;

                            default:
                                break;
                        }
                        Console.WriteLine(result);
                        break;
                }
                command = Console.ReadLine()
                                     .Split(' ')
                                     .ToList();
            }
            if (isChanged)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.Write($"{numbers[i]}{' '}");
                }
            }
        }
    }
}
