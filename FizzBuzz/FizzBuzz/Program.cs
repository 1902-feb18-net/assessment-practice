using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int Fcount = 0;
            int Bcount = 0;
            int FBcount = 0;

            for ( int count =1; count < 1001; count++)
            {
                if ( count % 3 == 0 && count % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                    Fcount++;
                    
                }
                else if ( count % 5 == 0 && count % 3 != 0)
                {
                    Console.WriteLine("Buzz");
                    Bcount++;
                }
                else if ( count % 3 == 0 && count % 5 == 0 )
                {
                    Console.WriteLine("FizzBuzz");    
                    FBcount++;               
                }
                else
                {
                    Console.WriteLine(count);
                }
            }
                Console.WriteLine("Fizz count : " + Fcount);
                Console.WriteLine("Buzz count : " + Bcount);
                Console.WriteLine("FizzBuzz count : " + FBcount);
        }
    }
}
