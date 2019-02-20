using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
           int x = 1;
           int fizz = 0;
           int buzz = 0;
           int fizzbuzz = 0;

           while (x != 1001)
           {
               if(x % 3 == 0 && x % 5 != 0)
               {
                   Console.WriteLine("Fizz ");
                   fizz++;
               }
               else if(x % 5 == 0 && x % 3 != 0)
               {
                   Console.WriteLine("Buzz ");
                   buzz++;
               }
               else if(x % 3 == 0 && x % 5 == 0)
               {
                   Console.WriteLine("FizzBuzz ");
                   fizzbuzz++;
               }
               else 
               {
                   Console.WriteLine(x);
               }
               x++;
           }

           Console.WriteLine($"Total Number of Fizz: {fizz}");
           Console.WriteLine($"Total Number of Buzz: {buzz}");
           Console.WriteLine($"Total Number of FizzBuzz: {fizzbuzz}");
        }
    }
}