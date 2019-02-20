using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int fizz = 0;
            int buzz = 0;
            int fizzbuzz = 0;
            for (int ii = 1; ii <= 1000; ii++)
            {
                if( ii % 3 == 0 && ii % 5 == 0)
                {
                    fizzbuzz++;
                    Console.WriteLine("FizzBuzz");
                }
                else if( ii % 3 == 0 && ii % 5 != 0)
                {
                    fizz++;
                    Console.WriteLine("Fizz");
                } 
                else if (ii % 3 != 0 && ii % 5 == 0)
                {
                    buzz++;
                    Console.WriteLine("Buzz");
                } 
                else
                {
                    Console.WriteLine(ii);    
                }
            }

            Console.WriteLine($"Totals: Fizz: {fizz} Buzz: {buzz} FizzBuzz: {fizzbuzz}");
        }
    }
}
