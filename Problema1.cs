using System;

class Problema1
{
    static void Main()
    {
        int INDICE = 13, SOMA = 0, K = 0;

        while (K < INDICE)
        {
            K = K + 1;
            SOMA = SOMA + K;
        }

        Console.WriteLine("Valor da soma = " + SOMA);

    }
}