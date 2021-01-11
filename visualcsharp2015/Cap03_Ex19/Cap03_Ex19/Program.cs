using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap03_Ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1, N2, N3, N4, MEDIA, EXAME, MEF;

            Console.WriteLine("Programa para cálculo de média.");
            Console.WriteLine();

            Console.WriteLine("Insira a primeira nota: ");
            N1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a segunda nota: ");
            N2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a terceira nota: ");
            N3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quarta nota: ");
            N4 = double.Parse(Console.ReadLine());

            MEDIA = (N1 + N2 + N3 + N4) / 4;

            if (MEDIA >= 7)
            {
                Console.WriteLine();
                Console.WriteLine("O aluno está aprovado, e a média dele é " + MEDIA + ".");
                Console.WriteLine();
            }

            if (MEDIA < 7)
            {
                Console.WriteLine();
                Console.WriteLine("A média foi menor que 7, por favor, insira a nota de exame: ");
                EXAME = double.Parse(Console.ReadLine());

                MEF = (MEDIA + EXAME);

                if (MEF >= 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("O aluno passou ´por exame, com a média " + MEF + ".");
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Mesmo com exame, o aluno está reprovado. A nota foi " + MEF + ".");
                    Console.WriteLine();
                }

            }

            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para sair... ");
            Console.ReadKey();
        }
    }
}
