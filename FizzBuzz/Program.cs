using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int fizz = 0,
            buzz = 0,
            fizzbuzz = 0;

            for(int i=1; i<1001; i++) 
            {
                if( (i%3)==0 && (i%5)!=0)
                {
                    Console.WriteLine("Fizz");
                    fizz++;
                } else if ( (i%5)==0 && (i%3)!=0) 
                {
                    Console.WriteLine("Buzz");
                    buzz++;
                } else if ( (i%3)==0 && (i%5)==0)
                {
                    Console.WriteLine("Fizzbuzz");
                    fizzbuzz++;
                } else 
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine($"Fizz count was {fizz}");
            Console.WriteLine($"Buzz count was {buzz}");
            Console.WriteLine($"Fizzbuzz count was {fizzbuzz}");

        }
    }
}
