using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int CountFizz = 0;
            int CountBuzz = 0;
            int CountFizzBuzz = 0;
            for(int i = 1; i <= 1000; i++)
            {
                if(i % 3 == 0)
                {
                    if(i % 5 == 0)
                    {
                        Console.WriteLine($"{i} FizzBuzz");
                        CountFizzBuzz++;
                    } else
                    {
                        Console.WriteLine($"{i} Fizz");
                        CountFizz++;
                    }
                } else
                {
                    if(i % 5 == 0)
                    {
                        Console.WriteLine($"{i} Buzz");
                        CountBuzz++;
                    } else
                    {
                        Console.WriteLine($"{i}");
                    }
                }
            }
            Console.WriteLine($"Total Fizz: {CountFizz}");
            Console.WriteLine($"Total Buzz: {CountBuzz}");
            Console.WriteLine($"Total FizzBuzz: {CountFizzBuzz}");
        }
    }
}
