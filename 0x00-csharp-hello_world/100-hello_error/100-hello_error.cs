using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
		TextWriter errorWritter = Console.Error;
        errorWritter.WriteLine("and that piece of art is useful - Dora Korpar, 2015-10-19");
        Environment.ExitCode = 1;
    }
}
