using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap03_Ex017
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, X1, X2, DELTA;

            Console.WriteLine();
            Console.Write("Programa para calcular equação do segundo grau.");
            Console.WriteLine();

            Console.Write("Insira o valor A: ");
            A = double.Parse(Console.ReadLine());
            Console.Write("Insira o valor B: ");
            B = double.Parse(Console.ReadLine());
            Console.Write("Insira o valor C: ");
            C = double.Parse(Console.ReadLine());

            DELTA = Math.Pow(B, 2) - 4 * A * C;

            if (DELTA >= 0)
            {
                X1 = (-B + Math.Pow(DELTA, (1.0 / 2.0))) / (2 * A);
                X2 = (-B - Math.Pow(DELTA, (1.0 / 2.0))) / (2 * A);

                Console.WriteLine();
                Console.Write("O resultado de X1 é: " + X1);
                Console.WriteLine();
                Console.Write("O resultado de X2 é: " + X2);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.Write("Esta equação não possui raízes reais.");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Presione <enter> para sair do programa... ");
            Console.ReadLine();
        }
    }
}
