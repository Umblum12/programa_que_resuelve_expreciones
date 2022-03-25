using System;

namespace programa_que_resuelve_expreciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarado de variables
            int r1, r2, r3, r4, a = 15, b = 30, c = 120, x;

            //Colocar el procedimiento
            if ( a == 15 & b == 30 & c == 120)
            {
                r1 = a + (b * c) / 5;
                r2 = a + b *(c + b);
                r3 = c - b + a *(b / a);
                r4 = x = 6 * (a + b + c);
            }
            else
            {
                return;
            }

            //Imprimir en pantalla el resultado
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("C = " + c);
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("si a = 15 y b = 30 y c = 120: enotnces: ");
            Console.WriteLine("A + (B * C) / 5 = ");
            Console.WriteLine("A + B * (C + B) = ");
            Console.WriteLine("C - B + A * (B / A) = ");
            Console.WriteLine("X = 6 (A + B + C) = ");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Resultaso N.1: " + r1);
            Console.WriteLine("Resultaso N.2: " + r2);
            Console.WriteLine("Resultaso N.3: " + r3);
            Console.WriteLine("Resultaso N.4: " + r4);
            Console.WriteLine("--------------------------------------------------------");
            Console.ReadKey(true);
        }
    }
}
