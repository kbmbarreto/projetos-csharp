using System;

namespace Cap02_Ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            double PI = 3.14159, Volume;
            int Altura, Raio;

            Console.Write("Insira a altura do recipiente: ");
            Altura = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Insira o Raio do recipiente: ");
            Raio = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Volume = PI * (Raio * Raio) * Altura;

            Console.Write("O volume de seu recipiente equivale ao valor " + Volume + ".");
            Console.WriteLine();
            Console.Write("Pressione <qualquer tecla> para sair do programa.");
            Console.WriteLine();
        }
    }
}
