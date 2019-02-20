using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // fizzbuzz program
            Console.WriteLine("FizzBuzz start!!");
            FizzBuzz();
        }

        static void FizzBuzz()
        {
            var count = 1;
            var fbCount = 0;
            var fCount = 0;
            var bCount = 0;

            while(count <= 1000 )
            {
                if(count % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    fbCount++;
                }
                else if(count % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    fCount++;
                }
                else if(count % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    bCount++;
                }
                else
                {
                    Console.WriteLine(count);
                }
                count++;
            }

            Console.WriteLine($"FizzBuzz count is: {fbCount}, Fizz: {fCount}, Buzz is: {bCount}");
        }
    }
}
