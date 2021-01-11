using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Calculadora de Poupança ***");

            double valorInvestido;
            int contadorMes = 1;
            
                Console.WriteLine();
                Console.Write("Insira o valor aplicado em sua poupança: ");
                valorInvestido = double.Parse(Console.ReadLine());
                Console.WriteLine();

            while (contadorMes <= 12)

            {

                //0.36% = 0.0036

                valorInvestido = valorInvestido + valorInvestido * 0.0036;

                Console.WriteLine("Após "+ contadorMes + " meses, você terá R$" + valorInvestido + ".");

                contadorMes = contadorMes += 1;
            }

            Console.ReadLine();
        }
    }
}
