using System;

namespace Cap02_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            float HorasTrabalhadas, ValorHora, PercentualDesconto, SalarioBase, TotalDesconto, SalarioLiquido;

            Console.Write("Horas trabalhadas .................. : ");
            HorasTrabalhadas = float.Parse(Console.ReadLine());
            Console.Write("Valor da Hora ...................... : ");
            ValorHora = float.Parse(Console.ReadLine());
            Console.Write("Valor do percentual de desconto .... : ");
            PercentualDesconto = float.Parse(Console.ReadLine());

            SalarioBase = HorasTrabalhadas * ValorHora;
            TotalDesconto = (PercentualDesconto / 100) * SalarioBase;
            SalarioLiquido = SalarioBase - TotalDesconto;

            Console.WriteLine();
            Console.Write("Salario liquido .................... : ");
            Console.WriteLine(SalarioLiquido.ToString("##,##0.00"));
            
            // O método ToString() é usado para formatar uma saída numérica, para representar o valor do tipo
            // real, no formato 99.999,99. O símbolo # determina que, na ausencia de um numero, nada sera
            // apresentado.


            Console.WriteLine();
            Console.Write("Tecle <Enter> para encerrar ........ ");
            Console.WriteLine();
        }
    }
}
