using System;

namespace Cap02_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, R; 

            Console.Write("Entre o primeiro valor: ");
            A = int.Parse(Console.ReadLine());
            //o método Parse() anexado ao ti´po int é usado para converter a entrada do valor fornecido pelo teclado
                //em seu equivalente inteiro, que é o tipo da variável em uso.

            Console.Write("Entre com o segundo valor: ");
            B = int.Parse(Console.ReadLine());

            R = A + B;

            Console.WriteLine();
            Console.WriteLine("Resultado = " + R);

            Console.WriteLine();
            Console.Write("Tecle <Enter> para continuar... ");
            Console.WriteLine();
        }
    }
}
