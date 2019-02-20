using System;

namespace FizzBuzz.UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            int length = 1000;
            int fizzNum = 0;
            int buzzNum = 0;
            int fbNum = 0;
            for (int i = 1; i <= length; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    System.Console.WriteLine("Fizzbuzz");
                    fbNum++;
                }
                else if (i % 3 == 0)
                {
                    System.Console.WriteLine("Fizz");
                    fizzNum++;  
                } 
                else if (i % 5 == 0)
                {
                    System.Console.WriteLine("Buzz");
                    buzzNum++;
                } 
                else
                {
                    System.Console.WriteLine($"{i}");
                }
            }
            System.Console.WriteLine($"There are this many Fizz: {fizzNum}");
            System.Console.WriteLine($"There are this many Buzz: {buzzNum}");
            System.Console.WriteLine($"There are this many Fizzbuzz: {fbNum}");
            
        }
    }
}
