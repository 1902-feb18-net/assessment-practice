using System;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fizzbuzz start!!");
            Fizzbuzz();
        }

        static void Fizzbuzz()
        {
            var count = 1;
            var fbCount = 0;
            var fCount = 0;
            var bCount = 0;

            while(count <= 1000 )
            {
                if(count % 15 == 0)
                {
                    Console.WriteLine("Fizzbuzz");
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

            Console.WriteLine($"Fizzbuzz count is: {fbCount}, Fizz: {fCount}, Buzz is: {bCount}");
        }
    }
}
