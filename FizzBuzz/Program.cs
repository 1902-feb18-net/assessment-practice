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

            for(int ii = 1; ii <= 1000; ii++)
            {
                if(ii % 3 == 0 && ii % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                    fizzbuzz++;
                }
                else if(ii % 3 == 0 && ii % 5 != 0) 
                {
                    Console.WriteLine("fizz");
                    fizz++;
                }
                else if (ii % 3 != 0 && ii % 5 == 0)
                {
                    Console.WriteLine("buzz");
                    buzz++;
                }
                else
                {
                    Console.WriteLine(ii);
                }
            }

            Console.WriteLine($"Total counts Fizz: {fizz} Buzz: {buzz} FizzBuzz: {fizzbuzz}");
        }
    }
}
