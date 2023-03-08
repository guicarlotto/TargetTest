using System;

class Problema3E {
    static void Main() {
        int n1 = 1, n2 = 1, n3;
        
        Console.Write(n1 + "\n" + n2 + "\n");
        
        for (int i = 0; i < 5; i++) {
            n3 = n1 + n2;
            Console.Write(n3 + "\n");
            n1 = n2;
            n2 = n3;
        }
    }
}