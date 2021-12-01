using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 0; n < 99; n++)
            {   
                string hex = n.ToString("x");
                Console.WriteLine("{0} = 0x{1}", n, hex);
            }
        }
    }
}
