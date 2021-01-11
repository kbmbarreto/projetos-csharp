using System;

namespace Cap02_Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            int Fahrenheit, Celsius;

            Console.Write("Insira a temperatura em F°: ");
            Fahrenheit = int.Parse(Console.ReadLine());

            Celsius = ((Fahrenheit - 32) * 5) / 9;

            Console.WriteLine();
            Console.Write("A temperatura " + Fahrenheit + " F° convertida em C° é: " + Celsius +".");
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Pressione <qualquer tecla> para sair do programa.");
            Console.WriteLine();
        }
    }
}
