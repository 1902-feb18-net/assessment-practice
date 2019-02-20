using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
           int fizz=0;
            int buzz=0;
            int fizzbuzz=0;
            for (int x = 1; x <= 1000; x++)
            {
                if ((x % 5 == 0) && (x % 3 == 0))
                {
                    Console.WriteLine("FizzBuzz: ");
                    fizzbuzz++;
                }

                else if (x % 3 == 0)
                {
                    fizz++;
                    Console.WriteLine("Fizz");

                }
                else if (x % 5 == 0)
                {

                    buzz++;
                    Console.WriteLine("Buzz");
                                 
                }               
                else
                    Console.WriteLine(x);


            }
            Console.WriteLine($"There are {fizzbuzz} Fizzbuzz");

            Console.WriteLine($"There are {fizz} Fizz");
            Console.WriteLine($"There are {buzz} Buzz");
            Console.ReadLine();
        }
    }
}
