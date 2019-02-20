using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int countFizz = 0;
            int countBuzz = 0;
            int countFizzBuzz = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if ((i % 3 == 0) && (i % 5 != 0))
                {
                    Console.WriteLine("Fizz");
                    countFizz++;
                }
                else if ((i % 5 == 0) && (i % 3 != 0))
                {
                    Console.WriteLine("Buzz");
                    countBuzz++;
                }
                else if ((i % 5 == 0) && (i % 3 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                    countFizzBuzz++;
                }
                else if ((i % 5 != 0) && (i % 3 != 0))
                {
                    Console.WriteLine(i);        
                }
            }
            Console.WriteLine("Fizz: {0}", countFizz);
            Console.WriteLine("Buzz: {0}", countBuzz);
            Console.WriteLine("FizzBuzz: {0}", countFizzBuzz);
        }
    }
}
