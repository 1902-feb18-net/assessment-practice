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
             for (int count =1; count < 1000;count++)
             {
                if (count % 3 == 0 && count % 5 == 0)
                {
                    Console.WriteLine("Fizzbuzz");
                    fizzbuzz++;
                }
                else if(count % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    fizz++;
                }
                else if(count % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    buzz++;
                }
                else
                {
                    Console.WriteLine(count);
                }
                
             }
            Console.WriteLine($"The total number of Fizz's was {fizz}");
            Console.WriteLine($"The total number of Buzz's was {buzz}");
            Console.WriteLine($"The total number of Fizzbuzz's was {fizzbuzz}");
        }
    }
}
