using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto com uso de 'For'.");
            Console.WriteLine();

            double valorInvestido;
            double taxaJuros = 0.0036;
            

            Console.WriteLine();
            Console.WriteLine("Insira o valor investido: ");
            valorInvestido = double.Parse(Console.ReadLine());
            Console.WriteLine();


            for(int contadorMes= 1; contadorMes <= 12; contadorMes = contadorMes + 1)
            {
                valorInvestido = valorInvestido + valorInvestido * taxaJuros;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido + ".");
            }

            Console.ReadLine();
        }
    }
}
