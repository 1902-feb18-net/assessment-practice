using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            int fizz = 0;
            int buzz = 0;
            int fizzbuzz = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (((i % 3) == 0) && ((i % 5) == 0))
                {
                    Console.WriteLine("Fizz Buzz ");
                    fizzbuzz++;
                }
                else if ((i % 3) == 0)
                {
                    Console.WriteLine("Fizz ");
                    fizz++;
                }
                else if ((i % 5) == 0)
                {
                    Console.WriteLine("Buzz ");
                    buzz++;
                }
                else
                {
                    Console.WriteLine($"{i} ");
                }
            }

            Console.WriteLine($"Fizz: {fizz}");
            Console.WriteLine($"Buzz: {buzz}");
            Console.WriteLine($"FizzBuzz: {fizzbuzz}");

        }

    }
}
