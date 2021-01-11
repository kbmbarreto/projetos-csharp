using System;
/**
 * Programa exemplo para cálculo de tabuada
 * de um valor numérico qualquer fornecido a partir
 * do teclado para operação em modo console.
 */

 /*
  * Programa............: Tabuada
  * Autor(es)...........: Kleber Barreto
  * Data................: 22/08/2019
  * Versão..............: 2.0
  * Revisão.............: 22/08/2019
  */

namespace Cap04_Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, I, R;

            Console.WriteLine("PROGRAMA - TABUADA - v2.0");
            Console.WriteLine();
            Console.Write("Informe um valor: ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (I = 1; I <= 10; I++)
            {
                // Cálculo da tabuada propriamente dito
                R = N * I;
                // Apresentação da tabuada em formato: N X I = R
                Console.WriteLine("{0,2} X {1,2} = {2,3}", N, I, R);
            }

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();
        }
    }
}
