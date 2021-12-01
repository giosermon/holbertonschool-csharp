using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 0; n <= 100; n++){
                if (n % 3 == 0 && n % 5 == 0)
                    Console.Write("FizzBuzz");
                else if (n % 3 == 0)
                    Console.Write("Fizz");
                else if (n % 5 == 0)
                    Console.Write("Buzz");
                else
                    Console.Write("{0} ", n);
                if (n != 100)
                    Console.Write(" ");
            }
            Console.Write("");
        }
    }
}
