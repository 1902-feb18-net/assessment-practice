using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int fizz = 0, buzz = 0, fizzbuzz = 0;
            for(int x = 1; x < 1001; x++)
            {
                if(x % 3 == 0 && x % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    fizzbuzz++;
                }
                else if(x % 3 == 0 && x % 5 !=0)
                {
                    Console.WriteLine("Fizz");
                    fizz++;
                }
                else if(x % 3 != 0 && x % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    buzz++;
                }
                else
                {
                    Console.WriteLine(x);
                }
            }
            Console.WriteLine($"The total number of Fizz is {fizz}.");
            Console.WriteLine($"The total number of Buzz is {buzz}.");
            Console.WriteLine($"The total number of FizzBuzz is {fizzbuzz}.");
        }
    }
}
