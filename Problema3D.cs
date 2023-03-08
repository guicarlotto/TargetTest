using System;

class Problema3D
{
    static void Main()
    {
        Console.WriteLine("d)");

        int a = 4, inc = 12;

        Console.WriteLine(a + "\n");

        for (int i = 0; i < 4; i++)
        {
            a = a + inc;
            inc = inc + 8;
            
            Console.WriteLine(a + "\n");
        }

    }
}