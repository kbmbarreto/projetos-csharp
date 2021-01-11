using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto sobre Laços For Encadeados.");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++) //esse For faz a contagem de anos.
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++) //esse For faz a contagem dos meses.
                {
                    valorInvestido *= fatorRendimento;
                }
                fatorRendimento += 0.0010;
            }

            Console.WriteLine("Ao término do investimento, você terá R$" + valorInvestido);
            Console.ReadLine();
        }
    }
}
