using System;

class Line
{
    public static void PrintLine(int length)
    {
        if (length <= 0)
            Console.WriteLine();
        else{
            for (int n = 0; n < length; n++)
                Console.Write('_');
            }
        Console.WriteLine();
    }
}
