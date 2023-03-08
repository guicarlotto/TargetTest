using System;
using System.Linq;
 
public static class reverseClass
{
    public static string reverse(this string str) {
        return new string(str.Reverse().ToArray());
    }
}

class Problema5 {
    static void Main()
    {
        Console.WriteLine("Escreva uma frase:");

        string sVal = Console.ReadLine();

        string reverse = sVal.reverse();

        Console.WriteLine("\n Sua frase ao contrário: " + reverse);
    }
}
