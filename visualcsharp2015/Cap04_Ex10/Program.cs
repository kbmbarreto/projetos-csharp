using System;

/* O programa a seguir mostra a apreentação de valores evoluídos (avançados), com
 * passo de contagem de dois em dois com o uso do operador, += com a contagem iniciada em um
 * e encerrada em dez. O programa usa o operador +=, mas poderia fazer uso de qualquer um dos outros,
 * desde que levado em consideração o contexto de aplicação de cada um deles.
 */

// teste

namespace Cap04_Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int I = 1; I <= 10; I += 2)
                Console.WriteLine("I = {0}", I);
            Console.WriteLine();

            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();
        }
    }
}
