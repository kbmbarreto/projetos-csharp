using System;

namespace Cap02_Ex09
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C1, C2;

            Console.Write("Insira o valor numérico de A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Insira o Valor de B: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine();

            C1 = B;
            C2 = A;
            A = C1;
            B = C2;

            Console.WriteLine();
            Console.Write("Mudamos o valor de A para " + C1 + ".");
            Console.WriteLine();
            Console.Write("E mudamos o valor de B para " + C2 + ".");
            Console.WriteLine();
        }
    }
}
