using System;

namespace Cap02_Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            int GASTO_LITRO = 12, DISTANCIA, TEMPO, VELOCIDADE, LITROS_USADOS;

            Console.Write("Insira o tempo que será gasto na viagem: ");
            TEMPO = int.Parse(Console.ReadLine());

            Console.Write("Insira a velocidade média de sua viagem: ");
            VELOCIDADE = int.Parse(Console.ReadLine());

            Console.Write("Insira a distância (em Km) que será percorrida em sua viagem: ");
            DISTANCIA = int.Parse(Console.ReadLine());

            DISTANCIA = TEMPO * VELOCIDADE;
            LITROS_USADOS = DISTANCIA / GASTO_LITRO;

            Console.WriteLine();
            Console.Write("Conforme informado, sua velocidade média é " + VELOCIDADE);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("O tempo gasto na viagem é " + TEMPO);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("A distância percorrida será " + DISTANCIA);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Serão utilizados " + LITROS_USADOS + " litros de combustível.");
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Pressione <enter> para sair do programa.");
            Console.WriteLine();
        }
    }
}
