using System;

namespace Cap02_Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            int Celsius, Fahrenheit;

            Console.Write("Digite a temperatura em C°: ");
            Celsius = int.Parse(Console.ReadLine());

            Fahrenheit = (9 * Celsius + 160) / 5;

            Console.WriteLine();
            Console.Write("A temperatura " + Celsius + " convertida em Fahrenheit é " + Fahrenheit +".");
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Pressione <qualquer tecla> para sair do programa.");
            Console.WriteLine();
        }
    }
}
