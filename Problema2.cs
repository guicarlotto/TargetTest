using System;

class Problema2 
{
    static void Main()
    {
        Console.WriteLine("Digite um número: ");
        string nVal = Console.ReadLine();

        int n = Convert.ToInt32(nVal);

        int a = 0, b = 1, c = 0;

        while (c < n)
        {
            c = a + b;
            a = b;
            b = c;

            Console.WriteLine(a + " " + b);
        }

            Console.WriteLine("\n");
            
        if (c == n)
        {
            Console.WriteLine(n + " Pertence à sequêecia Fibonacci");
        } else
        {
            Console.WriteLine(n + " Não pertence à sequência Fibonacci");
        }
    }
}

