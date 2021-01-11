using System;

namespace Cap03_Ex20
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, R;

            Console.WriteLine();
            Console.Write("Insira o valor de A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Insira o valor de B: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            if (A >= B)
            {
                R = A - B;
                Console.WriteLine("A diferença entre A e B é " + R + ".");
            }

            else
            {
                R = B - A;
                Console.WriteLine("A diferença entre A e B é " + R + ".");
            }

            Console.WriteLine("Pressione <Enter> para encerrar... ");
            Console.ReadLine();
        }
    }
}
