using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostodeRenda_IF_ELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  De 1900.0 até 2800.0, o IR é de 7.5% e pode deduzir na declaração o valor de R$ 142;
                De 2800.01 até 3751.0, o IR é de 15% e pode deduzir R$ 350;
                De 3751.01 até 4664.00, o IR é de 22.5% e pode deduzir R$ 636. */

            double salario;

            Console.WriteLine("Insira o valor do salário mensal, o formato é R$ XXXX.XX (insira o ponto para separar os centavos)");
            salario = double.Parse(Console.ReadLine());

            if (salario < 1900.0)
            {
                Console.WriteLine("Valor abaixo de R$ 1.900,00, os calculos deste programa vão de R$ 1.900,00 até R$ 4.664,00. Me pague que eu faço outro programa :)");
            }
            else
            {
                if (salario >= 1900.0 && salario <= 2800.0)
                {
                    Console.WriteLine("o salario mensal é de " + salario + ", o IR é de 7.5% e pode deduzir na declaração o valor de R$ 142,00.");
                }
                else
                {
                    if (salario >= 2800.01 && salario <= 3751.0)
                    {
                        Console.WriteLine("o salario mensal é de " + salario + ", o IR é de 15% e pode deduzir R$ 350,00.");
                    }
                    else
                    {
                        if (salario >= 3751.01 && salario <= 4664.00)
                        {
                            Console.WriteLine("o salario mensal é de " + salario + ", o IR é de 22.5% e pode deduzir R$ 636,00.");
                        }
                        else
                        {
                            Console.WriteLine("Está ganhando mais que R$ 4.664,00! Me paga que eu faço um aplicativo gráfico pra você :)");
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
