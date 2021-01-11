using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap03_Ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;

            Console.WriteLine();
            Console.Write("Programa para apresentar os valores em ordem crescente.");
            Console.WriteLine();

            Console.WriteLine("Insira o primeiro valor: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o terceiro valor: ");
            C = int.Parse(Console.ReadLine());

            // Lógica -> A, B, C --- A, C, B --- B, A, C --- B, C, A --- C, A, B --- C, B, A

            if (A < B && A < C && B < C)
                Console.WriteLine("Exibindo valores do menor para o maior: " + A + ", " + B + " e " + C + ".");
                else
                    if (A < C && A < B && C < B)
                        Console.WriteLine("Exibindo valores do menor para o maior: " + A + ", " + C + " e " + B + ".");
                else
                    if (B < A && B < C && A > C)
                        Console.WriteLine("Exibindo valores do menor para o maior: " + B + ", " + A + " e " + C + ".");
                else
                    if (B < C && C < A && A > B)
                        Console.WriteLine("Exibindo valores do menor para o maior: " + B + ", " + C + " e " + A + ".");
                else
                    if (C < A && C < B && B > A)
                        Console.WriteLine("Exibindo valores do menor para o maior: " + C + ", " + A + " e " + B + ".");
                else
                    if (C < B && C < A && A > B)
                        Console.WriteLine("Exibindo valores do menor para o maior: " + C + ", " + B + " e " + A + ".");

            Console.WriteLine();
            Console.Write("Tecle <Enter> para encerrar... ");
            Console.ReadLine();
        }
    }
}
