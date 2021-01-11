using System;

/* Programa que demonstra o uso do operador de incremento antes e depois de determinada variável.
 */

namespace Cap04_Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            int R, A, B1 = 0, B2 = 0;

            Console.Write("Insira o valor para a variável <A>: ");
            A = int.Parse(Console.ReadLine());
            R = A + B1++;
            Console.WriteLine();

            Console.Write("R = {0}", R);
            R = A + B1++;
            Console.WriteLine();
            Console.Write("R = {0}", R);
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Insira o valor para a variável <A>: ");
            A = int.Parse(Console.ReadLine());
            R = A + ++B2;
            Console.WriteLine();
            Console.Write("R = {0}", R);
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();
        }
    }
}
