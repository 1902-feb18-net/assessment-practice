using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int fizz = 0;
            int buzz = 0;
            int fizzbuzz = 0;

            for(int i=1; i <= 1000;i++)
            {
                if(i % 3 == 0 && i % 5 != 0 )
                {
                    Console.WriteLine("Fizz");
                    fizz ++;
                }
                else if(i % 5 == 0 && i % 3 != 0)
                {
                    Console.WriteLine("Buzz");
                    buzz++;
                }
                else if(i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");   
                    fizzbuzz++;
                }
                else
                {
                    Console.WriteLine(i);
                }


            }
                Console.WriteLine($"the number of fizz is {fizz}");
                Console.WriteLine($"the nubmer of buzz is {buzz}");
                Console.WriteLine($"the number of fizzbuzz is {fizzbuzz}");
        }

    }
}
