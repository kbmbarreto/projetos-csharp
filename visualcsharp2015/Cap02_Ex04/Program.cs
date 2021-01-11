using System;

namespace Cap02_Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1, N2, N3, N4,
                ADICAO1, ADICAO2, ADICAO3, ADICAO4, ADICAO5, ADICAO6,
                MULTI1, MULTI2, MULTI3, MULTI4, MULTI5, MULTI6;

            Console.Write("Entre com o primeiro valor: ");
            N1 = int.Parse(Console.ReadLine());

            Console.Write("Entre com o segundo valor: ");
            N2 = int.Parse(Console.ReadLine());

            Console.Write("Entre com o terceiro valor: ");
            N3 = int.Parse(Console.ReadLine());

            Console.Write("Entre com o quarto valor: ");
            N4 = int.Parse(Console.ReadLine());

            ADICAO1 = N1 + N2;
            ADICAO2 = N1 + N3;
            ADICAO3 = N1 + N4;
            ADICAO4 = N2 + N3;
            ADICAO5 = N2 + N4;
            ADICAO6 = N3 + N4;

            MULTI1 = N1 * N2;
            MULTI2 = N1 * N3;
            MULTI3 = N1 * N4;
            MULTI4 = N2 * N3;
            MULTI5 = N2 * N4;
            MULTI6 = N3 * N4;

            Console.WriteLine();
            Console.Write("Resultado da soma de " + N1 + " com " + N2 + ": " + ADICAO1 + ", e o resultado da soma de " + N1 + " com " + N3 + " : " + ADICAO2) ;
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Resultado da soma de " + N1 + " com " + N4 + ": " + ADICAO3 + ", e o resultado da soma de " + N2 + " com " + N3 + ": " + ADICAO4);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Resultado da soma de " + N2 + " com " + N4 + ": " + ADICAO5 + ", e o resultado da soma de " + N3 + " com " + N4 + ": " + ADICAO6);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Resultado da multiplicação de " + N1 + " com " + N2 + ": " + MULTI1 + ", e o resultado da multiplicação de " + N1 + " com " + N3 + ": " + MULTI2);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Resultado da multiplicação de " + N1 + " com " + N4 + ": " + MULTI3 + ", e o resultado da multiplicação de " + N2 + " com " + N3 + ": " + MULTI4);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Resultado da multiplicação de " + N2 + " com " + N4 + ": " + MULTI5 + ", e o resultado da multiplicação de " + N3 + " com " + N4 + ": " + MULTI6);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Pressione <enter> para sair do programa.");
            Console.WriteLine();
        }
    }
}
